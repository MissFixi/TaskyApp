namespace Tasky.Forms
{
    partial class DeleteTaskForm
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
            numericUpDown1 = new NumericUpDown();
            idTaskLabel = new Label();
            cancelAddButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.None;
            numericUpDown1.Font = new Font("Segoe UI", 12F);
            numericUpDown1.Location = new Point(659, 275);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 39);
            numericUpDown1.TabIndex = 15;
            // 
            // idTaskLabel
            // 
            idTaskLabel.Anchor = AnchorStyles.None;
            idTaskLabel.AutoSize = true;
            idTaskLabel.Font = new Font("Segoe UI", 14F);
            idTaskLabel.Location = new Point(561, 276);
            idTaskLabel.Name = "idTaskLabel";
            idTaskLabel.Size = new Size(92, 38);
            idTaskLabel.TabIndex = 14;
            idTaskLabel.Text = "IdTask";
            // 
            // cancelAddButton
            // 
            cancelAddButton.Anchor = AnchorStyles.None;
            cancelAddButton.Font = new Font("Segoe UI", 12F);
            cancelAddButton.Location = new Point(709, 341);
            cancelAddButton.Name = "cancelAddButton";
            cancelAddButton.Size = new Size(140, 49);
            cancelAddButton.TabIndex = 13;
            cancelAddButton.Text = "Cancel";
            cancelAddButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.Font = new Font("Segoe UI", 12F);
            deleteButton.Location = new Point(549, 341);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(140, 48);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // DeleteTaskForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 785);
            Controls.Add(numericUpDown1);
            Controls.Add(idTaskLabel);
            Controls.Add(cancelAddButton);
            Controls.Add(deleteButton);
            MinimumSize = new Size(1361, 841);
            Name = "DeleteTaskForm";
            Text = "DeleteTaskForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label idTaskLabel;
        private Button cancelAddButton;
        private Button deleteButton;
    }
}