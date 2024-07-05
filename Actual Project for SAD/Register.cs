using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Actual_Project_for_SAD
{
    public partial class Register : Form
    {
        private MySqlConnection connection;
        private const string connectionString = "server=localhost;port=3306;username=root;password=;database=db_ddmfishretail";
        private bool passwordHidden = true;

        public Register(Login form1)
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            LoadRoles();
            passTxt.PasswordChar = '*';
            SetNextAvailableId();
            idTxt.Enabled = false;
        }

        private void LoadRoles()
        {
            try
            {
                connection.Open();
                string query = "SELECT roleName FROM roles";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PositionBox.Items.Add(reader["roleName"].ToString());
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

        private void SetNextAvailableId()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                string getIdQuery = "SELECT COALESCE(MAX(id), 1000) + 1 FROM users";
                MySqlCommand getIdCmd = new MySqlCommand(getIdQuery, connection);
                int nextId = Convert.ToInt32(getIdCmd.ExecuteScalar());
                idTxt.Text = nextId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while setting the next ID: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            string username = userTxt.Text;
            string password = passTxt.Text;
            int id = int.Parse(idTxt.Text);

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and Password cannot be empty.");
                return;
            }

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                string selectedRole = PositionBox.SelectedItem.ToString();

                string getRoleIdQuery = "SELECT id FROM roles WHERE roleName = @roleName";
                MySqlCommand getRoleIdCmd = new MySqlCommand(getRoleIdQuery, connection);
                getRoleIdCmd.Parameters.AddWithValue("@roleName", selectedRole);
                int roleId = Convert.ToInt32(getRoleIdCmd.ExecuteScalar());

                string insertQuery = "INSERT INTO users (id, username, password, roleId) VALUES (@id, @username, @password, @roleId)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                insertCmd.Parameters.AddWithValue("@id", id);
                insertCmd.Parameters.AddWithValue("@username", username);
                insertCmd.Parameters.AddWithValue("@password", password);
                insertCmd.Parameters.AddWithValue("@roleId", roleId);

                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Registration successful!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void PositionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void HidepassBtn_Click(object sender, EventArgs e)
        {
            if (passwordHidden)
            {
                passTxt.PasswordChar = '\0';
                passwordHidden = false;
                HidepassBtn.Text = "Hide";
            }
            else
            {
                passTxt.PasswordChar = '*';
                passwordHidden = true;
                HidepassBtn.Text = "Show";
            }
        }
    }
}
