using TaskyAPI;
using TaskyAPI.Services;
using TaskyAPI.Repositories;
using TaskyAPI.Context;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using Tasky.Objects;

namespace Tasky;

public partial class Start : Form
{
    private readonly IUTaskService _service;
    private readonly IUTaskRepository _tasksRepository;
    private readonly IUserRepository _userRepository;
    private Employee employee;
    
    public Start()
    {
        InitializeComponent();
        var TaskyDbContext = new TaskyAppDbContext();
        _tasksRepository = new UTaskRepository(TaskyDbContext);
        _userRepository = new UserRepository(TaskyDbContext);
        _service = new UTaskService(_tasksRepository, _userRepository);
    }

    //should be started by Enter on idTextBox
    private async void signInButton_Click(object sender, EventArgs e)
    {
        try
        {
            string idString = idTextBox.Text;
            int idUser = int.Parse(idString);
            Boolean DoesUserExist = await _userRepository.DoesUserExistAsync(idUser);
            if (!DoesUserExist)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Niepoprawne id";
            }
            else
            {
                employee = new Employee(idUser);
            }

        }
        catch (FormatException)
        {
            errorLabel.Text = "WprowadŸ prawid³ow¹ liczbê ca³kowit¹.";
        }
        catch (OverflowException)
        {
            errorLabel.Text = "Podana liczba jest zbyt du¿a lub zbyt ma³a";
        }


    }
}