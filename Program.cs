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
            ApplicationConfiguration.Initialize(); // Зробити вимикання програми ы запуск знов при натисканні кнопки "НАЗАД"

            var formControler = new FormContoler(); // Зробити нормальний MessageBox in UpdateForm
            var connection = new Connection();
            var exceptionHandlerConnection = new DecoratorExeptionHandler(connection);

            var employeesForm = new EmployeesForm(formControler, connection);
            var updateForm = new UpdateForm(formControler, connection);
            var salaryForm = new SalaryForm(formControler, connection);
            var mainForm = new MainForm(formControler, employeesForm, updateForm, salaryForm);

            formControler.HomeForm = mainForm;
            formControler.ShowHomeForm();
        }
    }
}