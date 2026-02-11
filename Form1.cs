using System.Configuration;
using System.Data.SqlClient;

namespace ELearningSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["ELearningDB"].ConnectionString;
        private void SignupLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(
                    "SELECT Email, Password FROM Users WHERE Email = @Email",
                    connection
                );

                command.Parameters.AddWithValue("@Email", emailBox.Text);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (reader["Password"].ToString() == passwordBox.Text)
                    {
                        MainForm main = new MainForm();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                    }
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
        }

    }
}
