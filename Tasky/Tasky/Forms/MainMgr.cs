using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tasky.Objects;
using TaskyAPI.Repositories;
using TaskyAPI.RequestModels;
using TaskyAPI.Services;

namespace Tasky.Forms
{
    public partial class MainMgr : Form
    {
        private Employee employee;
        private readonly IUTaskService _service;
        private readonly IUTaskRepository _tasksRepository;
        private readonly IUserRepository _userRepository;
        public MainMgr(Employee employee, IUTaskRepository uTaskRepository, IUserRepository userRepository, IUTaskService uTaskService)
        {
            this.employee = employee;
            _tasksRepository = uTaskRepository;
            _userRepository = userRepository;
            _service = uTaskService;
            InitializeComponent();
            ShowSubordinatesTasks();
        }

        public async void ShowSubordinatesTasks()
        {
            try
            {
                //listview columns add, clear columns and view
                var subordinates = await _userRepository.GetSubordinatesTasksAsync(employee.getId());
                var tasklist = subordinates.Where(u => u.UTasks != null)
                    .SelectMany(u => u.UTasks.Select(t => new ListViewItem(new[]
                {
                    u.IdUser.ToString(),
                    u.FirstName,
                    u.LastName,
                    t.Heading,
                    t.Priority.ToString(),
                    t.StartDate.ToShortDateString(),
                    t.EndDate.HasValue ? t.EndDate.Value.ToShortDateString() : "Nie zakończono",
                    t.IsPublic ? "Publiczne" : "Prywatne"
                }
                ))).ToArray();

                userTasksListView.Items.Clear();

                userTasksListView.Items.AddRange(tasklist);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public async void ShowStatistics()
        {
            var statistics = await _userRepository.GetStatisticsAsync(employee.getId());
            //listview columns add
            userTasksListView.Clear();
            userTasksListView.Columns.Clear();
            userTasksListView.Columns.Add("Month", 120);
            userTasksListView.Columns.Add("FirstName", 150);
            userTasksListView.Columns.Add("LastName", 150);
            userTasksListView.Columns.Add("TasksCount", 120);

            var statisticsArray = statistics.Select(u => new ListViewItem(new[]
            {
                u.Month.ToString(),
                u.FirstName,
                u.LastName,
                u.TasksCount.ToString()
            }))
                .ToArray();
            userTasksListView.Items.AddRange(statisticsArray);
            //sort by month
            //switch case for month
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowStatistics();
        }
    }
}
