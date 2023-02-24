using System.Data;
using UkrPoshta.database;
using UkrPoshta.repository;

namespace UkrPoshta.forms
{
    public partial class UpdateForm : Form
    {
        private readonly FormContoler formControler;
        private readonly IRepoEmployees repoEmployees;
        private readonly IRepoPositions repoPositions;
        private readonly IRepoDepartaments repoDepartments;

        public UpdateForm(FormContoler formControler, IRepoEmployees repoEmployees, IRepoPositions repoPositions, IRepoDepartaments repoDepartments)
        {
            InitializeComponent();
            this.formControler = formControler;
            this.repoEmployees = repoEmployees;
            this.repoPositions = repoPositions;
            this.repoDepartments = repoDepartments;
        }


        private void UpdateForm_Load(object sender, EventArgs e)
        {
            GetAllTables();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Підтвердити зміни ?", "", MessageBoxButtons.YesNo); // зробити MessageBox красивішим
            if (dialogResult == DialogResult.Yes)
            {
                repoEmployees.UpdateTableEmployees(dgvEmployee.DataSource as DataTable);
                repoPositions.UpdateTablePositions(dgvPosition.DataSource as DataTable);
                repoDepartments.UpdateTableDepartments(dgvDepartment.DataSource as DataTable);
                GetAllTables();
            }
            else if (dialogResult == DialogResult.No)
            {
                GetAllTables();
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            formControler.ShowHomeForm();
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            GetAllTables();
        }

        private void GetAllTables()
        {
            dgvEmployee.DataSource = repoEmployees.GetEmployees();
            dgvPosition.DataSource = repoPositions.GetPositions();
            dgvDepartment.DataSource = repoDepartments.GetDepartments();

            // Set width for ID column
            DataGridViewColumn columnPosition = dgvPosition.Columns[0];
            columnPosition.Width = 60;
            DataGridViewColumn columnDepartments = dgvDepartment.Columns[0];
            columnDepartments.Width = 60;
        }
    }
}
