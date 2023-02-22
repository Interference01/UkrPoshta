using UkrPoshta.database;
using UkrPoshta.forms;

namespace UkrPoshta
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); // ������� ���������� ������ ��������� ������ � Connection_ ������� 

            var formControler = new FormContoler(); // ������� ���������� MessageBox in UpdateForm
            var connection = new Connection();

            var employeesForm = new EmployeesForm(formControler, connection);
            var updateForm = new UpdateForm(formControler, connection);
            var salaryForm = new SalaryForm(formControler, connection);
            var mainForm = new MainForm(formControler, employeesForm, updateForm, salaryForm);

            formControler.HomeForm = mainForm;
            formControler.ShowHomeForm();
        }
    }
}