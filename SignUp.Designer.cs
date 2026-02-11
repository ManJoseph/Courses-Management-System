namespace ELearningSystem
{
    partial class SignUpForm
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
            SignupHeaderLabel = new Label();
            fullNameLbl = new Label();
            UsernameLbl = new Label();
            EmailLbl = new Label();
            password1Lbl = new Label();
            confirmPasswordLbl = new Label();
            SignUpBtn = new Button();
            fullNameBox = new TextBox();
            usernameBox = new TextBox();
            emailBox = new TextBox();
            passwordBox = new TextBox();
            confirmPasswordBox = new TextBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            SuspendLayout();
            // 
            // SignupHeaderLabel
            // 
            SignupHeaderLabel.AutoSize = true;
            SignupHeaderLabel.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignupHeaderLabel.ForeColor = Color.LightSeaGreen;
            SignupHeaderLabel.Location = new Point(248, 50);
            SignupHeaderLabel.Margin = new Padding(4, 0, 4, 0);
            SignupHeaderLabel.Name = "SignupHeaderLabel";
            SignupHeaderLabel.Size = new Size(447, 48);
            SignupHeaderLabel.TabIndex = 0;
            SignupHeaderLabel.Text = "Sign Up to our Platform";
            // 
            // fullNameLbl
            // 
            fullNameLbl.AutoSize = true;
            fullNameLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            fullNameLbl.Location = new Point(232, 161);
            fullNameLbl.Margin = new Padding(4, 0, 4, 0);
            fullNameLbl.Name = "fullNameLbl";
            fullNameLbl.Size = new Size(120, 32);
            fullNameLbl.TabIndex = 1;
            fullNameLbl.Text = "full Name";
            // 
            // UsernameLbl
            // 
            UsernameLbl.AutoSize = true;
            UsernameLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            UsernameLbl.Location = new Point(232, 228);
            UsernameLbl.Margin = new Padding(4, 0, 4, 0);
            UsernameLbl.Name = "UsernameLbl";
            UsernameLbl.Size = new Size(124, 32);
            UsernameLbl.TabIndex = 2;
            UsernameLbl.Text = "Username";
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            EmailLbl.Location = new Point(232, 289);
            EmailLbl.Margin = new Padding(4, 0, 4, 0);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(72, 32);
            EmailLbl.TabIndex = 3;
            EmailLbl.Text = "Email";
            // 
            // password1Lbl
            // 
            password1Lbl.AutoSize = true;
            password1Lbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            password1Lbl.Location = new Point(232, 353);
            password1Lbl.Margin = new Padding(4, 0, 4, 0);
            password1Lbl.Name = "password1Lbl";
            password1Lbl.Size = new Size(115, 32);
            password1Lbl.TabIndex = 4;
            password1Lbl.Text = "Password";
            // 
            // confirmPasswordLbl
            // 
            confirmPasswordLbl.AutoSize = true;
            confirmPasswordLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            confirmPasswordLbl.Location = new Point(232, 415);
            confirmPasswordLbl.Margin = new Padding(4, 0, 4, 0);
            confirmPasswordLbl.Name = "confirmPasswordLbl";
            confirmPasswordLbl.Size = new Size(209, 32);
            confirmPasswordLbl.TabIndex = 5;
            confirmPasswordLbl.Text = "Confirm Password";
            // 
            // SignUpBtn
            // 
            SignUpBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpBtn.Location = new Point(495, 476);
            SignUpBtn.Margin = new Padding(4);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(157, 59);
            SignUpBtn.TabIndex = 6;
            SignUpBtn.Text = "Sign Up";
            SignUpBtn.UseVisualStyleBackColor = true;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // fullNameBox
            // 
            fullNameBox.Location = new Point(448, 161);
            fullNameBox.Name = "fullNameBox";
            fullNameBox.Size = new Size(361, 39);
            fullNameBox.TabIndex = 7;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(448, 228);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(361, 39);
            usernameBox.TabIndex = 8;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(448, 282);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(361, 39);
            emailBox.TabIndex = 9;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(448, 346);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(361, 39);
            passwordBox.TabIndex = 10;
            // 
            // confirmPasswordBox
            // 
            confirmPasswordBox.Location = new Point(448, 408);
            confirmPasswordBox.Name = "confirmPasswordBox";
            confirmPasswordBox.PasswordChar = '*';
            confirmPasswordBox.Size = new Size(361, 39);
            confirmPasswordBox.TabIndex = 11;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Agency FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(616, 543);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(37, 24);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(495, 543);
            label1.Name = "label1";
            label1.Size = new Size(115, 24);
            label1.TabIndex = 13;
            label1.Text = "have an account ?";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 576);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(confirmPasswordBox);
            Controls.Add(passwordBox);
            Controls.Add(emailBox);
            Controls.Add(usernameBox);
            Controls.Add(fullNameBox);
            Controls.Add(SignUpBtn);
            Controls.Add(confirmPasswordLbl);
            Controls.Add(password1Lbl);
            Controls.Add(EmailLbl);
            Controls.Add(UsernameLbl);
            Controls.Add(fullNameLbl);
            Controls.Add(SignupHeaderLabel);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SignupHeaderLabel;
        private Label fullNameLbl;
        private Label UsernameLbl;
        private Label EmailLbl;
        private Label password1Lbl;
        private Label confirmPasswordLbl;
        private Button SignUpBtn;
        private TextBox fullNameBox;
        private TextBox usernameBox;
        private TextBox emailBox;
        private TextBox passwordBox;
        private TextBox confirmPasswordBox;
        private LinkLabel linkLabel1;
        private Label label1;
    }
}