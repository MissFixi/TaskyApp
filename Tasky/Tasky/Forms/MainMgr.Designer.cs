namespace Tasky.Forms
{
    partial class MainMgr
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
            userTasksListView = new ListView();
            IdUser = new ColumnHeader();
            FirstName = new ColumnHeader();
            LastName = new ColumnHeader();
            TaskHeading = new ColumnHeader();
            TaskPriority = new ColumnHeader();
            StartDate = new ColumnHeader();
            EndDate = new ColumnHeader();
            Type = new ColumnHeader();
            statisticsButton = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonAddTask = new Button();
            buttonDeleteTask = new Button();
            buttonEditTask = new Button();
            buttonFinishTask = new Button();
            bottomLabel = new Label();
            welcomeLabel = new Label();
            signOutLabel = new Label();
            SuspendLayout();
            // 
            // userTasksListView
            // 
            userTasksListView.Columns.AddRange(new ColumnHeader[] { IdUser, FirstName, LastName, TaskHeading, TaskPriority, StartDate, EndDate, Type });
            userTasksListView.Location = new Point(279, 70);
            userTasksListView.Name = "userTasksListView";
            userTasksListView.Size = new Size(1048, 680);
            userTasksListView.TabIndex = 0;
            userTasksListView.UseCompatibleStateImageBehavior = false;
            userTasksListView.View = View.Details;
            // 
            // IdUser
            // 
            IdUser.Tag = "IdUser";
            IdUser.Text = "IdUser";
            IdUser.Width = 70;
            // 
            // FirstName
            // 
            FirstName.Tag = "FirstName";
            FirstName.Text = "FirstName";
            FirstName.Width = 120;
            // 
            // LastName
            // 
            LastName.Tag = "LastName";
            LastName.Text = "LastName";
            LastName.Width = 150;
            // 
            // TaskHeading
            // 
            TaskHeading.Tag = "TaskHeading";
            TaskHeading.Text = "TaskHeading";
            TaskHeading.Width = 150;
            // 
            // TaskPriority
            // 
            TaskPriority.Tag = "TaskPriority";
            TaskPriority.Text = "TaskPriority";
            TaskPriority.Width = 110;
            // 
            // StartDate
            // 
            StartDate.Tag = "StartDate";
            StartDate.Text = "StartDate";
            StartDate.Width = 110;
            // 
            // EndDate
            // 
            EndDate.Tag = "EndDate";
            EndDate.Text = "EndDate";
            EndDate.Width = 110;
            // 
            // Type
            // 
            Type.Tag = "Type";
            Type.Text = "Type";
            Type.Width = 120;
            // 
            // statisticsButton
            // 
            statisticsButton.Font = new Font("Segoe UI", 14F);
            statisticsButton.Location = new Point(12, 168);
            statisticsButton.Name = "statisticsButton";
            statisticsButton.Size = new Size(261, 61);
            statisticsButton.TabIndex = 1;
            statisticsButton.Text = "Show statistics";
            statisticsButton.UseVisualStyleBackColor = true;
            statisticsButton.Click += button1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(12, 70);
            button1.Name = "button1";
            button1.Size = new Size(261, 92);
            button1.TabIndex = 2;
            button1.Text = "Show subordinates tasks";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(12, 235);
            button2.Name = "button2";
            button2.Size = new Size(261, 61);
            button2.TabIndex = 3;
            button2.Text = "Show your tasks";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(12, 302);
            button3.Name = "button3";
            button3.Size = new Size(261, 61);
            button3.TabIndex = 4;
            button3.Text = "Show public tasks";
            button3.UseVisualStyleBackColor = true;
            // 
            // buttonAddTask
            // 
            buttonAddTask.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonAddTask.Location = new Point(12, 369);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new Size(261, 61);
            buttonAddTask.TabIndex = 6;
            buttonAddTask.Text = "+ Add new task";
            buttonAddTask.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTask
            // 
            buttonDeleteTask.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonDeleteTask.Location = new Point(12, 436);
            buttonDeleteTask.Name = "buttonDeleteTask";
            buttonDeleteTask.Size = new Size(261, 61);
            buttonDeleteTask.TabIndex = 7;
            buttonDeleteTask.Text = "- Delete task";
            buttonDeleteTask.UseVisualStyleBackColor = true;
            // 
            // buttonEditTask
            // 
            buttonEditTask.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonEditTask.Location = new Point(12, 503);
            buttonEditTask.Name = "buttonEditTask";
            buttonEditTask.Size = new Size(261, 61);
            buttonEditTask.TabIndex = 9;
            buttonEditTask.Text = "Edit task";
            buttonEditTask.UseVisualStyleBackColor = true;
            // 
            // buttonFinishTask
            // 
            buttonFinishTask.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonFinishTask.Location = new Point(12, 570);
            buttonFinishTask.Name = "buttonFinishTask";
            buttonFinishTask.Size = new Size(261, 61);
            buttonFinishTask.TabIndex = 10;
            buttonFinishTask.Text = "Finish task";
            buttonFinishTask.UseVisualStyleBackColor = true;
            // 
            // bottomLabel
            // 
            bottomLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bottomLabel.AutoSize = true;
            bottomLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bottomLabel.Location = new Point(1205, 807);
            bottomLabel.Name = "bottomLabel";
            bottomLabel.Size = new Size(122, 21);
            bottomLabel.TabIndex = 11;
            bottomLabel.Text = "TaskyApp ver0.1";
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
            welcomeLabel.TabIndex = 12;
            welcomeLabel.Text = "Welcome User";
            welcomeLabel.TextAlign = ContentAlignment.MiddleRight;
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
            signOutLabel.TabIndex = 13;
            signOutLabel.Text = "Sign out";
            // 
            // MainMgr
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 837);
            Controls.Add(signOutLabel);
            Controls.Add(welcomeLabel);
            Controls.Add(bottomLabel);
            Controls.Add(buttonFinishTask);
            Controls.Add(buttonEditTask);
            Controls.Add(buttonDeleteTask);
            Controls.Add(buttonAddTask);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(statisticsButton);
            Controls.Add(userTasksListView);
            MinimumSize = new Size(1361, 841);
            Name = "MainMgr";
            Text = "Tasky";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView userTasksListView;
        private ColumnHeader IdUser;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader TaskHeading;
        private ColumnHeader TaskPriority;
        private ColumnHeader StartDate;
        private ColumnHeader EndDate;
        private ColumnHeader Type;
        private Button statisticsButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonAddTask;
        private Button buttonDeleteTask;
        private Button buttonEditTask;
        private Button buttonFinishTask;
        private Label bottomLabel;
        private Label welcomeLabel;
        private Label signOutLabel;
    }
}