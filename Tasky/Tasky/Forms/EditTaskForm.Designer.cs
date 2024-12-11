namespace Tasky.Forms
{
    partial class EditTaskForm
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
            publicRadioButton = new RadioButton();
            privateRadioButton = new RadioButton();
            priorityNumeric = new NumericUpDown();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cancelAddButton = new Button();
            editButton = new Button();
            descriptionBox = new TextBox();
            headingBox = new TextBox();
            numericUpDown1 = new NumericUpDown();
            idTaskLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)priorityNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // publicRadioButton
            // 
            publicRadioButton.Anchor = AnchorStyles.None;
            publicRadioButton.AutoSize = true;
            publicRadioButton.Font = new Font("Segoe UI", 12F);
            publicRadioButton.Location = new Point(692, 382);
            publicRadioButton.Name = "publicRadioButton";
            publicRadioButton.Size = new Size(103, 36);
            publicRadioButton.TabIndex = 28;
            publicRadioButton.TabStop = true;
            publicRadioButton.Text = "Public";
            publicRadioButton.UseVisualStyleBackColor = true;
            // 
            // privateRadioButton
            // 
            privateRadioButton.Anchor = AnchorStyles.None;
            privateRadioButton.AutoSize = true;
            privateRadioButton.Font = new Font("Segoe UI", 12F);
            privateRadioButton.Location = new Point(564, 382);
            privateRadioButton.Name = "privateRadioButton";
            privateRadioButton.Size = new Size(111, 36);
            privateRadioButton.TabIndex = 27;
            privateRadioButton.TabStop = true;
            privateRadioButton.Text = "Private";
            privateRadioButton.UseVisualStyleBackColor = true;
            // 
            // priorityNumeric
            // 
            priorityNumeric.Anchor = AnchorStyles.None;
            priorityNumeric.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            priorityNumeric.Location = new Point(564, 283);
            priorityNumeric.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            priorityNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            priorityNumeric.Name = "priorityNumeric";
            priorityNumeric.Size = new Size(56, 39);
            priorityNumeric.TabIndex = 26;
            priorityNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(481, 382);
            label5.Name = "label5";
            label5.Size = new Size(65, 32);
            label5.TabIndex = 25;
            label5.Text = "Type";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(411, 333);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 24;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(457, 285);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 23;
            label2.Text = "Priority";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(442, 232);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 22;
            label1.Text = "Heading";
            // 
            // cancelAddButton
            // 
            cancelAddButton.Anchor = AnchorStyles.None;
            cancelAddButton.Font = new Font("Segoe UI", 12F);
            cancelAddButton.Location = new Point(724, 446);
            cancelAddButton.Name = "cancelAddButton";
            cancelAddButton.Size = new Size(140, 49);
            cancelAddButton.TabIndex = 21;
            cancelAddButton.Text = "Cancel";
            cancelAddButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.None;
            editButton.Font = new Font("Segoe UI", 12F);
            editButton.Location = new Point(564, 446);
            editButton.Name = "editButton";
            editButton.Size = new Size(140, 48);
            editButton.TabIndex = 20;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // descriptionBox
            // 
            descriptionBox.Anchor = AnchorStyles.None;
            descriptionBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            descriptionBox.Location = new Point(564, 330);
            descriptionBox.MinimumSize = new Size(300, 39);
            descriptionBox.Name = "descriptionBox";
            descriptionBox.Size = new Size(300, 39);
            descriptionBox.TabIndex = 19;
            // 
            // headingBox
            // 
            headingBox.Anchor = AnchorStyles.None;
            headingBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            headingBox.Location = new Point(564, 232);
            headingBox.Name = "headingBox";
            headingBox.Size = new Size(300, 39);
            headingBox.TabIndex = 18;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.None;
            numericUpDown1.Font = new Font("Segoe UI", 12F);
            numericUpDown1.Location = new Point(564, 182);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 39);
            numericUpDown1.TabIndex = 30;
            // 
            // idTaskLabel
            // 
            idTaskLabel.Anchor = AnchorStyles.None;
            idTaskLabel.AutoSize = true;
            idTaskLabel.Font = new Font("Segoe UI", 12F);
            idTaskLabel.Location = new Point(468, 182);
            idTaskLabel.Name = "idTaskLabel";
            idTaskLabel.Size = new Size(78, 32);
            idTaskLabel.TabIndex = 29;
            idTaskLabel.Text = "IdTask";
            // 
            // EditTaskForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 785);
            Controls.Add(numericUpDown1);
            Controls.Add(idTaskLabel);
            Controls.Add(publicRadioButton);
            Controls.Add(privateRadioButton);
            Controls.Add(priorityNumeric);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancelAddButton);
            Controls.Add(editButton);
            Controls.Add(descriptionBox);
            Controls.Add(headingBox);
            MinimumSize = new Size(1361, 841);
            Name = "EditTaskForm";
            Text = "EditTaskForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)priorityNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton publicRadioButton;
        private RadioButton privateRadioButton;
        private NumericUpDown priorityNumeric;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button cancelAddButton;
        private Button editButton;
        private TextBox descriptionBox;
        private TextBox headingBox;
        private NumericUpDown numericUpDown1;
        private Label idTaskLabel;
    }
}