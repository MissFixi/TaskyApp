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
            IsPublic = new ColumnHeader();
            statisticsButton = new Button();
            SuspendLayout();
            // 
            // userTasksListView
            // 
            userTasksListView.Anchor = AnchorStyles.None;
            userTasksListView.Columns.AddRange(new ColumnHeader[] { IdUser, FirstName, LastName, TaskHeading, TaskPriority, StartDate, EndDate, IsPublic });
            userTasksListView.Location = new Point(641, 249);
            userTasksListView.Name = "userTasksListView";
            userTasksListView.Size = new Size(1402, 864);
            userTasksListView.TabIndex = 0;
            userTasksListView.UseCompatibleStateImageBehavior = false;
            userTasksListView.View = View.Details;
            // 
            // IdUser
            // 
            IdUser.Tag = "IdUser";
            IdUser.Text = "IdUser";
            IdUser.Width = 50;
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
            TaskPriority.Width = 70;
            // 
            // StartDate
            // 
            StartDate.Tag = "StartDate";
            StartDate.Text = "StartDate";
            StartDate.Width = 120;
            // 
            // EndDate
            // 
            EndDate.Tag = "EndDate";
            EndDate.Text = "EndDate";
            EndDate.Width = 160;
            // 
            // IsPublic
            // 
            IsPublic.Tag = "IsPublic";
            IsPublic.Text = "IsPublic";
            IsPublic.Width = 120;
            // 
            // statisticsButton
            // 
            statisticsButton.Location = new Point(224, 249);
            statisticsButton.Name = "statisticsButton";
            statisticsButton.Size = new Size(241, 67);
            statisticsButton.TabIndex = 1;
            statisticsButton.Text = "Show statistics";
            statisticsButton.UseVisualStyleBackColor = true;
            statisticsButton.Click += button1_Click;
            // 
            // MainMgr
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2787, 1343);
            Controls.Add(statisticsButton);
            Controls.Add(userTasksListView);
            Name = "MainMgr";
            Text = "MainMgr";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
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
        private ColumnHeader IsPublic;
        private Button statisticsButton;
    }
}