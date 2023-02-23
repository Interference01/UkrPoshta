using UkrPoshta.database;
using UkrPoshta.forms;
using UkrPoshta.repository;

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

            var formControler = new FormContoler();
            var connection = new DBRepository();
            var exceptionHandlerConnection = new DecoratorExeptionHandler(connection);

            var repoEmployees = new RepoEmployees(connection);
            var repoPositions = new RepoPositions(connection);
            var repoDepartments = new RepoDepartments(connection);

            var employeesForm = new EmployeesForm(formControler, repoEmployees, repoPositions, repoDepartments);
            var updateForm = new UpdateForm(formControler, repoEmployees, repoPositions,  repoDepartments);
            var salaryForm = new SalaryForm(formControler, repoEmployees, repoPositions, repoDepartments);
            var mainForm = new MainForm(formControler, employeesForm, updateForm, salaryForm);

            formControler.HomeForm = mainForm;
            formControler.ShowHomeForm();
        }
    }
}