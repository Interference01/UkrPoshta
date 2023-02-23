using System.Data;
using UkrPoshta.database;
using UkrPoshta.repository;

namespace UkrPoshta.forms
{
    public partial class UpdateForm : Form
    {
        FormContoler formControler;
        IRepository repository;

        public UpdateForm(FormContoler formControler, IRepository repository)
        {
            InitializeComponent();
            this.formControler = formControler;
            this.repository = repository;
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
                repository.UpdateTables(GetString.SelectAllFromEmployees(), dgvEmployee.DataSource as DataTable);
                repository.UpdateTables(GetString.SelectAllFromPositions(), dgvPosition.DataSource as DataTable);
                repository.UpdateTables(GetString.SelectAllFromDepartments(), dgvDepartment.DataSource as DataTable);
                GetAllTables();
            }
            else if (dialogResult == DialogResult.No)
            {
                GetAllTables();
            }
        }

        private void GetAllTables()
        {
            dgvEmployee.DataSource = repository.GetTableFromDatabase(GetString.SelectAllFromEmployees());
            dgvPosition.DataSource = repository.GetTableFromDatabase(GetString.SelectAllFromPositions());
            dgvDepartment.DataSource = repository.GetTableFromDatabase(GetString.SelectAllFromDepartments());

            // Set width for ID column
            DataGridViewColumn columnPosition = dgvPosition.Columns[0];
            columnPosition.Width = 60;
            DataGridViewColumn columnDepartments = dgvDepartment.Columns[0];
            columnDepartments.Width = 60;
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            formControler.ShowHomeForm();
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            GetAllTables();
        }
    }
}
