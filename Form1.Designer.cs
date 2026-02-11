namespace ELearningSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginHeaderLabel = new Label();
            EmailLoginLabel = new Label();
            passwordLoginLabel = new Label();
            emailBox = new TextBox();
            passwordBox = new TextBox();
            LoginButton = new Button();
            SignupLinkLabel = new LinkLabel();
            SignupLabel = new Label();
            SuspendLayout();
            // 
            // LoginHeaderLabel
            // 
            LoginHeaderLabel.AutoSize = true;
            LoginHeaderLabel.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginHeaderLabel.ForeColor = Color.CadetBlue;
            LoginHeaderLabel.ImageAlign = ContentAlignment.BottomRight;
            LoginHeaderLabel.Location = new Point(203, 41);
            LoginHeaderLabel.Name = "LoginHeaderLabel";
            LoginHeaderLabel.Size = new Size(348, 48);
            LoginHeaderLabel.TabIndex = 0;
            LoginHeaderLabel.Text = "E-Learning System";
            LoginHeaderLabel.UseMnemonic = false;
            // 
            // EmailLoginLabel
            // 
            EmailLoginLabel.AutoSize = true;
            EmailLoginLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLoginLabel.Location = new Point(160, 141);
            EmailLoginLabel.Name = "EmailLoginLabel";
            EmailLoginLabel.Size = new Size(72, 32);
            EmailLoginLabel.TabIndex = 1;
            EmailLoginLabel.Text = "Email";
            // 
            // passwordLoginLabel
            // 
            passwordLoginLabel.AutoSize = true;
            passwordLoginLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLoginLabel.Location = new Point(160, 217);
            passwordLoginLabel.Name = "passwordLoginLabel";
            passwordLoginLabel.Size = new Size(115, 32);
            passwordLoginLabel.TabIndex = 2;
            passwordLoginLabel.Text = "Password";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(281, 141);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(305, 31);
            emailBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(281, 217);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(305, 31);
            passwordBox.TabIndex = 4;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.Location = new Point(331, 292);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(112, 46);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // SignupLinkLabel
            // 
            SignupLinkLabel.AutoSize = true;
            SignupLinkLabel.Location = new Point(436, 354);
            SignupLinkLabel.Name = "SignupLinkLabel";
            SignupLinkLabel.Size = new Size(73, 25);
            SignupLinkLabel.TabIndex = 6;
            SignupLinkLabel.TabStop = true;
            SignupLinkLabel.Text = "Sign up";
            SignupLinkLabel.LinkClicked += SignupLinkLabel_LinkClicked;
            // 
            // SignupLabel
            // 
            SignupLabel.AutoSize = true;
            SignupLabel.Location = new Point(233, 354);
            SignupLabel.Name = "SignupLabel";
            SignupLabel.Size = new Size(197, 25);
            SignupLabel.TabIndex = 7;
            SignupLabel.Text = "Don't have an account?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SignupLabel);
            Controls.Add(SignupLinkLabel);
            Controls.Add(LoginButton);
            Controls.Add(passwordBox);
            Controls.Add(emailBox);
            Controls.Add(passwordLoginLabel);
            Controls.Add(EmailLoginLabel);
            Controls.Add(LoginHeaderLabel);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginHeaderLabel;
        private Label EmailLoginLabel;
        private Label passwordLoginLabel;
        private TextBox emailBox;
        private TextBox passwordBox;
        private Button LoginButton;
        private LinkLabel SignupLinkLabel;
        private Label SignupLabel;
    }
}
