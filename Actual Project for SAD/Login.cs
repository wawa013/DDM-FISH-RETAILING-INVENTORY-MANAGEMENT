using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Actual_Project_for_SAD
{
    public partial class Login : Form
    {
        private MySqlConnection connection;
        private const string connectionString = "server=localhost;port=3306;username=root;password=;database=db_ddmfishretail";

        public Login()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "" || passwordTxt.Text == "")
            {
                MessageBox.Show("Invalid or empty credentials! Please try again.");
                return;
            }

            string username = usernameTxt.Text;
            string password = passwordTxt.Text;

            try
            {
                connection.Open();

                string query = "SELECT id, username, roleid FROM users WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int userId = reader.GetInt32("id");
                    string user = reader.GetString("username");
                    int roleId = reader.GetInt32("roleid");

                    MessageBox.Show("Login successful!");

                    Inventory inventoryForm = new Inventory(userId, user, roleId);
                    inventoryForm.StartPosition = FormStartPosition.CenterScreen;
                    inventoryForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials! Please try again.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
            Register frm = new Register(this);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
    }
}
