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

            var updateForm = new UpdateForm();
            var employeesForm = new EmployeesForm();
            var mainForm = new MainForm(formControler, employeesForm, updateForm);

            formControler.HomeForm = updateForm;
            formControler.ShowHomeForm();
        }
    }
}