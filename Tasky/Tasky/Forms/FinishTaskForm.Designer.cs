namespace Tasky.Forms
{
    partial class FinishTaskForm
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
            cancelAddButton = new Button();
            finishButton = new Button();
            idTaskLabel = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // cancelAddButton
            // 
            cancelAddButton.Anchor = AnchorStyles.None;
            cancelAddButton.Font = new Font("Segoe UI", 12F);
            cancelAddButton.Location = new Point(692, 328);
            cancelAddButton.Name = "cancelAddButton";
            cancelAddButton.Size = new Size(140, 49);
            cancelAddButton.TabIndex = 8;
            cancelAddButton.Text = "Cancel";
            cancelAddButton.UseVisualStyleBackColor = true;
            // 
            // finishButton
            // 
            finishButton.Anchor = AnchorStyles.None;
            finishButton.Font = new Font("Segoe UI", 12F);
            finishButton.Location = new Point(532, 328);
            finishButton.Name = "finishButton";
            finishButton.Size = new Size(140, 48);
            finishButton.TabIndex = 7;
            finishButton.Text = "Finish";
            finishButton.UseVisualStyleBackColor = true;
            // 
            // idTaskLabel
            // 
            idTaskLabel.Anchor = AnchorStyles.None;
            idTaskLabel.AutoSize = true;
            idTaskLabel.Font = new Font("Segoe UI", 14F);
            idTaskLabel.Location = new Point(544, 263);
            idTaskLabel.Name = "idTaskLabel";
            idTaskLabel.Size = new Size(92, 38);
            idTaskLabel.TabIndex = 10;
            idTaskLabel.Text = "IdTask";
            idTaskLabel.Click += label1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.None;
            numericUpDown1.Font = new Font("Segoe UI", 12F);
            numericUpDown1.Location = new Point(642, 262);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 39);
            numericUpDown1.TabIndex = 11;
            // 
            // FinishTaskForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 785);
            Controls.Add(numericUpDown1);
            Controls.Add(idTaskLabel);
            Controls.Add(cancelAddButton);
            Controls.Add(finishButton);
            MinimumSize = new Size(1361, 841);
            Name = "FinishTaskForm";
            Text = "FinishTaskForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelAddButton;
        private Button finishButton;
        private Label idTaskLabel;
        private NumericUpDown numericUpDown1;
    }
}