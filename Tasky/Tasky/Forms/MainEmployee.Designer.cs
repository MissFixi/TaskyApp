namespace Tasky
{
    partial class MainEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("");
            userTasksListView = new ListView();
            IdTask = new ColumnHeader();
            Heading = new ColumnHeader();
            Priority = new ColumnHeader();
            Description = new ColumnHeader();
            StartDate = new ColumnHeader();
            EndDate = new ColumnHeader();
            IsPublic = new ColumnHeader();
            buttonShowTasks = new Button();
            buttonPublicTasks = new Button();
            buttonAddTask = new Button();
            buttonDeleteTask = new Button();
            buttonFinishTask = new Button();
            buttonEditTask = new Button();
            welcomeLabel = new Label();
            bottomLabel = new Label();
            signOutLabel = new Label();
            SuspendLayout();
            // 
            // userTasksListView
            // 
            userTasksListView.Columns.AddRange(new ColumnHeader[] { IdTask, Heading, Priority, Description, StartDate, EndDate, IsPublic });
            userTasksListView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            userTasksListView.Location = new Point(279, 70);
            userTasksListView.Name = "userTasksListView";
            userTasksListView.Size = new Size(1048, 680);
            userTasksListView.TabIndex = 2;
            userTasksListView.UseCompatibleStateImageBehavior = false;
            userTasksListView.View = View.Details;
            // 
            // IdTask
            // 
            IdTask.Tag = "Id";
            IdTask.Text = "Id";
            IdTask.Width = 50;
            // 
            // Heading
            // 
            Heading.Tag = "Heading";
            Heading.Text = "Heading";
            Heading.Width = 150;
            // 
            // Priority
            // 
            Priority.Tag = "Priority";
            Priority.Text = "Priority";
            Priority.Width = 70;
            // 
            // Description
            // 
            Description.Tag = "Description";
            Description.Text = "Description";
            Description.Width = 300;
            // 
            // StartDate
            // 
            StartDate.Tag = "StartDate";
            StartDate.Text = "StartDate";
            StartDate.Width = 120;
            // 
            // EndDate
            // 
            EndDate.Tag = "FinishDate";
            EndDate.Text = "FinishDate";
            EndDate.Width = 160;
            // 
            // IsPublic
            // 
            IsPublic.Tag = "IsPublic";
            IsPublic.Text = "IsPublic";
            IsPublic.Width = 120;
            // 
            // buttonShowTasks
            // 
            buttonShowTasks.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonShowTasks.Location = new Point(12, 70);
            buttonShowTasks.Name = "buttonShowTasks";
            buttonShowTasks.Size = new Size(261, 61);
            buttonShowTasks.TabIndex = 3;
            buttonShowTasks.Text = "Show your tasks";
            buttonShowTasks.UseVisualStyleBackColor = true;
            // 
            // buttonPublicTasks
            // 
            buttonPublicTasks.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonPublicTasks.Location = new Point(12, 137);
            buttonPublicTasks.Name = "buttonPublicTasks";
            buttonPublicTasks.Size = new Size(261, 61);
            buttonPublicTasks.TabIndex = 4;
            buttonPublicTasks.Text = "Show public tasks";
            buttonPublicTasks.UseVisualStyleBackColor = true;
            // 
            // buttonAddTask
            // 
            buttonAddTask.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonAddTask.Location = new Point(12, 204);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new Size(261, 61);
            buttonAddTask.TabIndex = 5;
            buttonAddTask.Text = "+ Add new task";
            buttonAddTask.UseVisualStyleBackColor = true;
            buttonAddTask.Click += AddTask;
            // 
            // buttonDeleteTask
            // 
            buttonDeleteTask.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonDeleteTask.Location = new Point(12, 271);
            buttonDeleteTask.Name = "buttonDeleteTask";
            buttonDeleteTask.Size = new Size(261, 61);
            buttonDeleteTask.TabIndex = 6;
            buttonDeleteTask.Text = "- Delete task";
            buttonDeleteTask.UseVisualStyleBackColor = true;
            // 
            // buttonFinishTask
            // 
            buttonFinishTask.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonFinishTask.Location = new Point(12, 405);
            buttonFinishTask.Name = "buttonFinishTask";
            buttonFinishTask.Size = new Size(261, 61);
            buttonFinishTask.TabIndex = 7;
            buttonFinishTask.Text = "Finish task";
            buttonFinishTask.UseVisualStyleBackColor = true;
            // 
            // buttonEditTask
            // 
            buttonEditTask.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonEditTask.Location = new Point(12, 338);
            buttonEditTask.Name = "buttonEditTask";
            buttonEditTask.Size = new Size(261, 61);
            buttonEditTask.TabIndex = 8;
            buttonEditTask.Text = "Edit task";
            buttonEditTask.UseVisualStyleBackColor = true;
            // 
            // welcomeLabel
            // 
            welcomeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            welcomeLabel.Location = new Point(1077, 9);
            welcomeLabel.MinimumSize = new Size(250, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(250, 30);
            welcomeLabel.TabIndex = 9;
            welcomeLabel.Text = "Welcome User";
            welcomeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // bottomLabel
            // 
            bottomLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bottomLabel.AutoSize = true;
            bottomLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bottomLabel.Location = new Point(1205, 856);
            bottomLabel.Name = "bottomLabel";
            bottomLabel.Size = new Size(122, 21);
            bottomLabel.TabIndex = 10;
            bottomLabel.Text = "TaskyApp ver0.1";
            // 
            // signOutLabel
            // 
            signOutLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            signOutLabel.AutoSize = true;
            signOutLabel.Font = new Font("Segoe UI", 10F);
            signOutLabel.Location = new Point(1241, 39);
            signOutLabel.Name = "signOutLabel";
            signOutLabel.RightToLeft = RightToLeft.Yes;
            signOutLabel.Size = new Size(86, 28);
            signOutLabel.TabIndex = 14;
            signOutLabel.Text = "Sign out";
            // 
            // MainEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1339, 886);
            Controls.Add(signOutLabel);
            Controls.Add(bottomLabel);
            Controls.Add(welcomeLabel);
            Controls.Add(buttonEditTask);
            Controls.Add(buttonFinishTask);
            Controls.Add(buttonDeleteTask);
            Controls.Add(buttonAddTask);
            Controls.Add(buttonPublicTasks);
            Controls.Add(buttonShowTasks);
            Controls.Add(userTasksListView);
            MinimumSize = new Size(1361, 841);
            Name = "MainEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tasky";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView userTasksListView;
        private ColumnHeader IdTask;
        private ColumnHeader Heading;
        private ColumnHeader Priority;
        private ColumnHeader Description;
        private ColumnHeader StartDate;
        private ColumnHeader EndDate;
        private ColumnHeader IsPublic;
        private Button buttonShowTasks;
        private Button buttonPublicTasks;
        private Button buttonAddTask;
        private Button buttonDeleteTask;
        private Button buttonFinishTask;
        private Button buttonEditTask;
        private Label welcomeLabel;
        private Label bottomLabel;
        private Label signOutLabel;
    }
}