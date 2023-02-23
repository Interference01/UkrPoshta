using System.Diagnostics;
using System.Windows.Forms;
using UkrPoshta.database;
using UkrPoshta.repository;

namespace UkrPoshta.forms
{
    public partial class SalaryForm : Form
    {
        FormContoler formControler;
        IRepository repository;

        public SalaryForm(FormContoler formControler, IRepository repository)
        {
            InitializeComponent();
            this.formControler = formControler;
            this.repository = repository;
        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {
            //Settings combobox departments
            cbDepartment.DataSource = repository.GetTableFromDatabase(GetString.SelectAllFromDepartments());
            cbDepartment.ValueMember = "DepartmentID";
            cbDepartment.DisplayMember = "Name";
            cbDepartment.SelectedItem = null;
        }

        private void cbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var departmentID = cbDepartment.SelectedValue;

            dgvSalary.DataSource = repository.GetTableFromDatabase(GetString.SelectFromEmployeesSalary() +
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
