using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ELearningSystem
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["ELearningDB"].ConnectionString;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(usernameBox.Text) ||
                string.IsNullOrWhiteSpace(emailBox.Text) ||
                string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!passwordBox.Text.Equals(confirmPasswordBox.Text))
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Here you would save the new user to a database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Users (Fullname, Username, Email, Password) VALUES (@Fullname, @Username, @Email, @Password)", connection))
                {
                    command.Parameters.AddWithValue("@Fullname", fullNameBox.Text);
                    command.Parameters.AddWithValue("@Username", usernameBox.Text);
                    command.Parameters.AddWithValue("@Email", emailBox.Text);
                    command.Parameters.AddWithValue("@Password", passwordBox.Text);
                    if(command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                connection.Close();
            }
        }
    }
}
