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
        }
    }
}
