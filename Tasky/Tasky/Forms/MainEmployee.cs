using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tasky.Objects;
using TaskyAPI.Models;
using TaskyAPI.Repositories;
using TaskyAPI.RequestModels;
using TaskyAPI.Services;

namespace Tasky
{
    public partial class MainEmployee : Form
    {
        private Employee employee;
        private readonly IUTaskService _service;
        private readonly IUTaskRepository _tasksRepository;
        private readonly IUserRepository _userRepository;
        public MainEmployee(Employee employee, IUTaskRepository uTaskRepository, IUserRepository userRepository, IUTaskService uTaskService)
        {
            this.employee = employee;
            _tasksRepository = uTaskRepository;
            _userRepository = userRepository;
            _service = uTaskService;
            InitializeComponent();
            ShowTasks();
        }

        public async void ShowTasks()
        {
            try
            {
                var userTasks = await _tasksRepository.GetTasksForUserAsync(employee.getId());
                var tasklist = userTasks.Select(t => new ListViewItem(new[]
                {
                    t.IdTask.ToString(),
                    t.Heading,
                    t.Priority.ToString(),
                    t.Description,
                    t.StartDate.ToShortDateString(),
                    t.EndDate.HasValue ? t.EndDate.Value.ToShortDateString() : "Nie zakończono",
                    t.IsPublic ? "Publiczne" : "Prywatne"
                }
                )).ToArray();

                userTasksListView.Items.Clear();

                userTasksListView.Items.AddRange(tasklist);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
