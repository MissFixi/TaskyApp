namespace Tasky.Forms
{
    partial class AddTaskForm
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
            headingBox = new TextBox();
            descriptionBox = new TextBox();
            addButton = new Button();
            cancelAddButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            priorityNumeric = new NumericUpDown();
            startDate = new DateTimePicker();
            privateRadioButton = new RadioButton();
            publicRadioButton = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)priorityNumeric).BeginInit();
            SuspendLayout();
            // 
            // headingBox
            // 
            headingBox.Anchor = AnchorStyles.None;
            headingBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            headingBox.Location = new Point(611, 198);
            headingBox.Name = "headingBox";
            headingBox.Size = new Size(300, 39);
            headingBox.TabIndex = 0;
            // 
            // descriptionBox
            // 
            descriptionBox.Anchor = AnchorStyles.None;
            descriptionBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            descriptionBox.Location = new Point(611, 296);
            descriptionBox.MinimumSize = new Size(300, 39);
            descriptionBox.Name = "descriptionBox";
            descriptionBox.Size = new Size(300, 39);
            descriptionBox.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.Font = new Font("Segoe UI", 12F);
            addButton.Location = new Point(611, 462);
            addButton.Name = "addButton";
            addButton.Size = new Size(140, 48);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addTask;
            // 
            // cancelAddButton
            // 
            cancelAddButton.Anchor = AnchorStyles.None;
            cancelAddButton.Font = new Font("Segoe UI", 12F);
            cancelAddButton.Location = new Point(771, 462);
            cancelAddButton.Name = "cancelAddButton";
            cancelAddButton.Size = new Size(140, 49);
            cancelAddButton.TabIndex = 6;
            cancelAddButton.Text = "Cancel";
            cancelAddButton.UseVisualStyleBackColor = true;
            cancelAddButton.Click += cancelAdding;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(489, 198);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 7;
            label1.Text = "Heading";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(504, 251);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 8;
            label2.Text = "Priority";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(458, 299);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 9;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(481, 351);
            label4.Name = "label4";
            label4.Size = new Size(112, 32);
            label4.TabIndex = 10;
            label4.Text = "StartDate";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(528, 398);
            label5.Name = "label5";
            label5.Size = new Size(65, 32);
            label5.TabIndex = 11;
            label5.Text = "Type";
            // 
            // priorityNumeric
            // 
            priorityNumeric.Anchor = AnchorStyles.None;
            priorityNumeric.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            priorityNumeric.Location = new Point(611, 249);
            priorityNumeric.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            priorityNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            priorityNumeric.Name = "priorityNumeric";
            priorityNumeric.Size = new Size(56, 39);
            priorityNumeric.TabIndex = 14;
            priorityNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // startDate
            // 
            startDate.Anchor = AnchorStyles.None;
            startDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            startDate.Location = new Point(611, 346);
            startDate.Name = "startDate";
            startDate.Size = new Size(300, 39);
            startDate.TabIndex = 15;
            // 
            // privateRadioButton
            // 
            privateRadioButton.Anchor = AnchorStyles.None;
            privateRadioButton.AutoSize = true;
            privateRadioButton.Font = new Font("Segoe UI", 12F);
            privateRadioButton.Location = new Point(611, 398);
            privateRadioButton.Name = "privateRadioButton";
            privateRadioButton.Size = new Size(111, 36);
            privateRadioButton.TabIndex = 16;
            privateRadioButton.TabStop = true;
            privateRadioButton.Text = "Private";
            privateRadioButton.UseVisualStyleBackColor = true;
            // 
            // publicRadioButton
            // 
            publicRadioButton.Anchor = AnchorStyles.None;
            publicRadioButton.AutoSize = true;
            publicRadioButton.Font = new Font("Segoe UI", 12F);
            publicRadioButton.Location = new Point(739, 398);
            publicRadioButton.Name = "publicRadioButton";
            publicRadioButton.Size = new Size(103, 36);
            publicRadioButton.TabIndex = 17;
            publicRadioButton.TabStop = true;
            publicRadioButton.Text = "Public";
            publicRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 785);
            Controls.Add(publicRadioButton);
            Controls.Add(privateRadioButton);
            Controls.Add(startDate);
            Controls.Add(priorityNumeric);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancelAddButton);
            Controls.Add(addButton);
            Controls.Add(descriptionBox);
            Controls.Add(headingBox);
            MinimumSize = new Size(1361, 841);
            Name = "AddTaskForm";
            Text = "Tasky";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)priorityNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox headingBox;
        private TextBox textBox2;
        private TextBox descriptionBox;
        private TextBox textBox4;
        private Button addButton;
        private Button cancelAddButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox isPublicNoCheckbox;
        private CheckBox isPublicYesCheckbox;
        private NumericUpDown priorityNumeric;
        private DateTimePicker startDate;
        private RadioButton privateRadioButton;
        private RadioButton publicRadioButton;
    }
}