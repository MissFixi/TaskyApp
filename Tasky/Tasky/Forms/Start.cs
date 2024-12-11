using TaskyAPI;
using TaskyAPI.Services;
using TaskyAPI.Repositories;
using TaskyAPI.Context;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using Tasky.Objects;
using Tasky.Forms;

namespace Tasky;

public partial class Start : Form
{
    private readonly IUTaskService _service;
    private readonly IUTaskRepository _tasksRepository;
    private readonly IUserRepository _userRepository;
    private Employee employee;

    public Start(IUTaskRepository uTaskRepository, IUserRepository userRepository, IUTaskService uTaskService)
    {
        _tasksRepository = uTaskRepository;
        _userRepository = userRepository;
        _service = uTaskService;
        InitializeComponent();
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
                if (await employee.IsMgr((UserRepository)_userRepository))
                {
                    this.Hide();
                    new MainMgr(employee, _tasksRepository, _userRepository, _service).ShowDialog();
                }
                else
                {
                    this.Hide();
                    new MainEmployee(employee, _tasksRepository, _userRepository, _service).ShowDialog();
                }
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