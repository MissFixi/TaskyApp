using System.ComponentModel;

namespace Tasky;

partial class Start
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        idTextBox = new TextBox();
        label1 = new Label();
        signInButton = new Button();
        errorLabel = new Label();
        SuspendLayout();
        // 
        // idTextBox
        // 
        idTextBox.Anchor = AnchorStyles.None;
        idTextBox.Location = new Point(343, 179);
        idTextBox.Name = "idTextBox";
        idTextBox.Size = new Size(150, 31);
        idTextBox.TabIndex = 0;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.None;
        label1.AutoSize = true;
        label1.Location = new Point(312, 182);
        label1.Name = "label1";
        label1.Size = new Size(34, 25);
        label1.TabIndex = 1;
        label1.Text = "ID:";
        // 
        // signInButton
        // 
        signInButton.Anchor = AnchorStyles.None;
        signInButton.Location = new Point(362, 216);
        signInButton.Name = "signInButton";
        signInButton.Size = new Size(112, 34);
        signInButton.TabIndex = 2;
        signInButton.Text = "Sign in";
        signInButton.UseVisualStyleBackColor = true;
        signInButton.Click += signInButton_Click;
        // 
        // errorLabel
        // 
        errorLabel.Anchor = AnchorStyles.None;
        errorLabel.AutoSize = true;
        errorLabel.ForeColor = Color.Red;
        errorLabel.Location = new Point(218, 151);
        errorLabel.MinimumSize = new Size(400, 10);
        errorLabel.Name = "errorLabel";
        errorLabel.Size = new Size(400, 25);
        errorLabel.TabIndex = 3;
        errorLabel.Text = "ErrorLabel";
        errorLabel.TextAlign = ContentAlignment.MiddleCenter;
        errorLabel.Visible = false;
        // 
        // Start
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(800, 450);
        Controls.Add(errorLabel);
        Controls.Add(signInButton);
        Controls.Add(label1);
        Controls.Add(idTextBox);
        MinimumSize = new Size(822, 506);
        Name = "Start";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Tasky";
        WindowState = FormWindowState.Maximized;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox idTextBox;
    private Label label1;
    private Button signInButton;
    private Label errorLabel;
}