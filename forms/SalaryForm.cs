using System.Diagnostics;
using UkrPoshta.database;
using UkrPoshta.repository;

namespace UkrPoshta.forms
{
    public partial class SalaryForm : Form
    {
        private readonly FormContoler formControler;
        private readonly IRepoEmployees repoEmployees;
        private readonly IRepoPositions repoPositions;
        private readonly IRepoDepartaments repoDepartments;

        public SalaryForm(FormContoler formControler, IRepoEmployees repoEmployees, IRepoPositions repoPositions, IRepoDepartaments repoDepartments)
        {
            InitializeComponent();
            this.formControler = formControler;
            this.repoEmployees = repoEmployees;
            this.repoPositions = repoPositions;
            this.repoDepartments = repoDepartments;
        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {
            //Settings combobox departments
            cbDepartment.DataSource = repoDepartments.GetDepartments();
            cbDepartment.ValueMember = "DepartmentID";
            cbDepartment.DisplayMember = "Name";
            cbDepartment.SelectedItem = null;
        }

        private void cbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var departmentID = cbDepartment.SelectedValue;

            dgvSalary.DataSource = repoEmployees.GetSalary((int)departmentID);
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
