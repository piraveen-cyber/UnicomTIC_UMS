using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTIC_UMS.Database;

namespace UnicomTIC_UMS.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE username = @username AND password = @password AND role = @role";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@role", role);

                        SQLiteDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // TODO: Open the Dashboard form based on role
                            this.Hide();
                            //DashboardForm dashboard = new DashboardForm(role, username);
                            //dashboard.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid login credentials!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Login Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
