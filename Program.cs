using UkrPoshta.database;

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

            var employeesForm = new EmployeesForm();
            var mainForm = new MainForm(formControler, employeesForm);

            formControler.HomeForm = employeesForm;
            formControler.ShowHomeForm();
        }
    }
}