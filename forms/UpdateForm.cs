using System.Data;
using System.Windows.Forms;
using UkrPoshta.database;

namespace UkrPoshta.forms
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            GetTables();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Підтвердити зміни ?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Connection.UpdateTables("SELECT * FROM Employees", dgvEmployee.DataSource as DataTable);
                Connection.UpdateTables("SELECT * FROM Positions", dgvPosition.DataSource as DataTable);
                Connection.UpdateTables("SELECT * FROM Departments", dgvDepartment.DataSource as DataTable);
                GetTables();
            }
            else if (dialogResult == DialogResult.No)
            {
                GetTables();
            }
        }

        private void GetTables()
        {
            dgvEmployee.DataSource = Connection.Query("SELECT * FROM Employees");
            dgvPosition.DataSource = Connection.Query("SELECT * FROM Positions");
            dgvDepartment.DataSource = Connection.Query("SELECT * FROM Departments");
            DataGridViewColumn columnPosition = dgvPosition.Columns[0];
            columnPosition.Width = 60;
            DataGridViewColumn columnDepartments = dgvDepartment.Columns[0];
            columnDepartments.Width = 60;
        }
    }
}
