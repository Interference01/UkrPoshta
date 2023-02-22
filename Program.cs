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
            ApplicationConfiguration.Initialize();

            var formControler = new FormContoler();

            var employeesForm = new EmployeesForm(formControler);
            var updateForm = new UpdateForm(formControler);
            var salaryForm = new SalaryForm(formControler);
            var mainForm = new MainForm(formControler, employeesForm, updateForm, salaryForm);

            formControler.HomeForm = mainForm;
            formControler.ShowHomeForm();
        }
    }
}