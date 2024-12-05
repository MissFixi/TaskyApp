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
            ListViewItem listViewItem2 = new ListViewItem("");
            userTasksListView = new ListView();
            IdTask = new ColumnHeader();
            Heading = new ColumnHeader();
            Priority = new ColumnHeader();
            Description = new ColumnHeader();
            StartDate = new ColumnHeader();
            EndDate = new ColumnHeader();
            IsPublic = new ColumnHeader();
            SuspendLayout();
            // 
            // userTasksListView
            // 
            userTasksListView.Anchor = AnchorStyles.None;
            userTasksListView.Columns.AddRange(new ColumnHeader[] { IdTask, Heading, Priority, Description, StartDate, EndDate, IsPublic });
            userTasksListView.Items.AddRange(new ListViewItem[] { listViewItem2 });
            userTasksListView.Location = new Point(733, 222);
            userTasksListView.Name = "userTasksListView";
            userTasksListView.Size = new Size(1163, 648);
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
            // MainEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2696, 1186);
            Controls.Add(userTasksListView);
            MinimumSize = new Size(822, 506);
            Name = "MainEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainEmployee";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
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
    }
}