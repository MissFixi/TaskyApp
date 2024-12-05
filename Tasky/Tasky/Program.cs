using TaskyAPI.Repositories;
using TaskyAPI;
using TaskyAPI.Context;
using TaskyAPI.Services;

namespace Tasky;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        /*Application.Run(new Start());*/
        var taskyDbContext = new TaskyAppDbContext();
        var tasksRepository = new UTaskRepository(taskyDbContext);
        var userRepository = new UserRepository(taskyDbContext);
        var service = new UTaskService(tasksRepository, userRepository);
        var loginForm = new Start(tasksRepository, userRepository, service);
        loginForm.ShowDialog();
    }
}