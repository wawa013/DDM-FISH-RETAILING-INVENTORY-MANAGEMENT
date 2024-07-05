using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Actual_Project_for_SAD
{
    public partial class Inventory : Form
    {
        private MySqlConnection connection;
        private const string connectionString = "server=localhost;port=3306;username=root;password=;database=db_ddmfishretail";
        private int currentUserId;
        private string currentUsername;
        private int currentRoleId;

        public Inventory(int userId, string username, int roleId)
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            currentUserId = userId;
            currentUsername = username;
            currentRoleId = roleId;
            LoadProductNames();
            LoadInventoryData();
            dataGridView1.CellClick += DataGridView1_CellClick;
            SetNextAvailableId();
            idTxt.Enabled = false;
            managerBox.Enabled = false;
            LoadSupplierNames();
            LoadManagerNames();
            DisplayUserId();
        }

        private void DisplayUserId()
        {
            userTxt.Text = $"User ID: {currentUserId}";
            usernameTxt.Text = $"Hello, {currentUsername}";
        }

        private void LoadProductNames()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT productName FROM product";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    productBox.Items.Add(reader["productName"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void LoadSupplierNames()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT id, Name FROM suppliers";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable suppliersTable = new DataTable();
                adapter.Fill(suppliersTable);

                supplierBox.DisplayMember = "Name";
                supplierBox.ValueMember = "Name";
                supplierBox.DataSource = suppliersTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void LoadManagerNames()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT id, username FROM users WHERE roleid = 2";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable managertable = new DataTable();
                adapter.Fill(managertable);

                managerBox.DisplayMember = "username";
                managerBox.ValueMember = "id";
                managerBox.DataSource = managertable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void LoadInventoryData()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT * FROM inventory";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                CheckInventoryLevels(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void SetNextAvailableId()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string getIdQuery = "SELECT COALESCE(MAX(id), 1000) + 1 FROM inventory";
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
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            string id = idTxt.Text;
            string supplierId = supplierBox.SelectedValue?.ToString();
            string itemName = productBox.SelectedItem?.ToString();
            string quantity = quantityTxt.Text;
            string managerId = managerBox.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(supplierId) || string.IsNullOrEmpty(itemName) || string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(managerId))
            {
                MessageBox.Show("All fields must be filled out.");
                return;
            }

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string insertQuery = "INSERT INTO inventory (id, supplier, itemName, quantity, managerId) VALUES (@id, @supplier, @itemName, @quantity, @managerId)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                insertCmd.Parameters.AddWithValue("@id", id);
                insertCmd.Parameters.AddWithValue("@supplier", supplierId);
                insertCmd.Parameters.AddWithValue("@itemName", itemName);
                insertCmd.Parameters.AddWithValue("@quantity", quantity);
                insertCmd.Parameters.AddWithValue("@managerId", managerId);

                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Item inserted successfully!");

                LoadInventoryData();
                SetNextAvailableId();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string id = idTxt.Text;
            string supplierId = supplierBox.SelectedValue?.ToString();
            string itemName = productBox.SelectedItem?.ToString();
            string quantity = quantityTxt.Text;
            string managerId = managerBox.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(supplierId) || string.IsNullOrEmpty(itemName) || string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(managerId))
            {
                MessageBox.Show("All fields must be filled out.");
                return;
            }

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string updateQuery = "UPDATE inventory SET supplier = @supplier, itemName = @itemName, quantity = @quantity, managerId = @managerId WHERE id = @id";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                updateCmd.Parameters.AddWithValue("@id", id);
                updateCmd.Parameters.AddWithValue("@supplier", supplierId);
                updateCmd.Parameters.AddWithValue("@itemName", itemName);
                updateCmd.Parameters.AddWithValue("@quantity", quantity);
                updateCmd.Parameters.AddWithValue("@managerId", managerId);

                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Item updated successfully!");

                LoadInventoryData();
                SetNextAvailableId();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = idTxt.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID field must be filled out.");
                return;
            }

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string deleteQuery = "DELETE FROM inventory WHERE id = @id";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection);
                deleteCmd.Parameters.AddWithValue("@id", id);

                deleteCmd.ExecuteNonQuery();

                MessageBox.Show("Item deleted successfully!");

                LoadInventoryData();
                SetNextAvailableId();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            supplierBox.SelectedIndex = -1;
            productBox.SelectedIndex = -1;
            quantityTxt.Clear();
            managerBox.SelectedIndex = -1;
            SetNextAvailableId();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                idTxt.Text = row.Cells["id"].Value.ToString();
                supplierBox.SelectedValue = row.Cells["supplier"].Value;
                productBox.SelectedItem = row.Cells["itemName"].Value.ToString();
                quantityTxt.Text = row.Cells["quantity"].Value.ToString();
                managerBox.SelectedValue = row.Cells["managerId"].Value;
            }
        }

        private void supplierTxt_TextChanged(object sender, EventArgs e)
        {

        }

        //private void transactionsBtn_Click(object sender, EventArgs e)
        //{
        //    InventoryTransaction frm = new InventoryTransaction(currentUserId, currentUsername, currentRoleId);
        //    frm.StartPosition = FormStartPosition.CenterScreen;
        //    frm.Show();
        //}

        private void LogoutBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckInventoryLevels(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                int quantity = Convert.ToInt32(row["quantity"]);
                if (quantity <= 5)
                {
                    MessageBox.Show("Almost out of stock!");
                    break;
                }
            }
        }

        private void currentId_Click(object sender, EventArgs e)
        {

        }

        private void userTxt_Click(object sender, EventArgs e)
        {

        }

        private void transactionsBtn_Click_1(object sender, EventArgs e)
        {
            InventoryTransaction frm = new InventoryTransaction(currentUserId, currentUsername, currentRoleId);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
