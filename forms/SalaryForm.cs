using System.Diagnostics;
using System.Windows.Forms;
using UkrPoshta.database;

namespace UkrPoshta.forms
{
    public partial class SalaryForm : Form
    {
        FormContoler formControler;

        public SalaryForm(FormContoler formControler)
        {
            InitializeComponent();
            this.formControler = formControler;
        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {

            //Settings combobox departments
            cbDepartment.DataSource = Connection.Query("SELECT * FROM Departments");
            cbDepartment.ValueMember = "DepartmentID";
            cbDepartment.DisplayMember = "Name";
            cbDepartment.SelectedItem = null;
        }

        private void cbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var departmentID = cbDepartment.SelectedValue == null ? "" : cbDepartment.SelectedValue;

            dgvSalary.DataSource = Connection.Query("SELECT e.Name as [Ім'я], e.LastName as Прізвище, p.Name as Посада, d.Name as Відділ, e.Salary as Оклад " +
                "FROM Employees e " +
                "join Departments d on e.DepartmentID=d.DepartmentID " +
                "join Positions p on e.PositionID=p.PositionID " +
                "WHERE d.DepartmentID =" + departmentID +
                " UNION ALL " +
                "SELECT NULL, NULL, NULL, 'Всього', SUM(e.Salary) FROM Employees e " +
                "join Departments d on e.DepartmentID=d.DepartmentID WHERE d.DepartmentID =" + departmentID); 
        }

        private void bSaveTXT_Click(object sender, EventArgs e)
        {
            using (var streamWriter = new StreamWriter($"{Environment.CurrentDirectory}\\Звіт\\Звіт {DateTime.UtcNow: dd.mm.yyyy hh-mm-ss}.txt"))
            {
                for (int i = 0; i < dgvSalary.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvSalary.Columns.Count; j++)
                    {
                        streamWriter.Write($"{dgvSalary.Rows[i].Cells[j].Value.ToString()}");

                        if (!(j == dgvSalary.Columns.Count - 1))
                        {
                            streamWriter.Write("       ");
                        }
                    }
                    streamWriter.WriteLine("\n");
                }
                streamWriter.Close();
            }
        }

        private void bOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", $"{Environment.CurrentDirectory}\\Звіт");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            formControler.ShowHomeForm();
        }
    }
}
