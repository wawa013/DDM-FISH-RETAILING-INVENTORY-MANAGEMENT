using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
//theres a problem on this code i will fix this tmmrw
namespace Actual_Project_for_SAD
{
    public partial class InventoryTransaction : Form
    {
        private MySqlConnection connection;
        private const string connectionString = "server=localhost;port=3306;username=root;password=;database=db_ddmfishretail";
        private int currentUserId;
        private string currentUsername;
        private int currentRoleId;

        public InventoryTransaction(int userId, string username, int roleId)
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            currentUserId = userId;
            currentUsername = username;
            currentRoleId = roleId;
            dataGridView1.CellClick += DataGridView1_CellClick;

            LoadInventoryData();
            idTxt.Enabled = false;
            useridBox.Enabled = false;

            LoadProductNames();
            LoadInventoryNames();
            AvailableId();
            LoadUserID();
            DisplayUserId();
            DisableDate();
            DisableButtonforemployee();

            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            LoadDataIntoDataGridView2();
        }


        private void DisplayUserId()
        {
            //userTxt.Text = $"User ID: {currentUserId}";
            //usernameTxt.Text = $"Hello, {currentUsername}";
        }

        private void AvailableId()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string getIdQuery = "SELECT COALESCE(MAX(id), 1000) + 1 FROM inventory_transaction";
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

        private void DisableDate()
        {
            if (currentRoleId == 1)
            {
                datepurchase.Enabled = false;
                return;
            }
        }

        private void DisableButtonforemployee()
        {
            if (currentRoleId == 1)
            {
                updateBtn.Enabled = false;
                deleteBtn.Enabled = false;
            }
        }

        private void LoadProductNames()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT itemName FROM inventory";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    invBox.Items.Add(reader["itemName"].ToString());
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

        private void LoadInventoryNames()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT id, itemName FROM inventory";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable invTable = new DataTable();
                adapter.Fill(invTable);

                invBox.DisplayMember = "itemName";
                invBox.ValueMember = "id";
                invBox.DataSource = invTable;
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

        private void LoadUserID()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT id, username FROM users";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable invTable = new DataTable();
                adapter.Fill(invTable);

                useridBox.DisplayMember = "username";
                useridBox.ValueMember = "id";
                useridBox.DataSource = invTable;

                useridBox.SelectedValue = currentUserId;
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

                string query = "SELECT id, inventoryId, transactionType, quantity, price, userId, Date FROM inventory_transaction";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                if (dataGridView1.Columns["Date"] != null)
                {
                    dataGridView1.Columns["Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
                }
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

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                idTxt.Text = row.Cells["id"].Value != DBNull.Value ? row.Cells["id"].Value.ToString() : string.Empty;
                invBox.SelectedValue = row.Cells["inventoryId"].Value != DBNull.Value ? row.Cells["inventoryId"].Value : -1;
                transactionId.Text = row.Cells["transactionType"].Value != DBNull.Value ? row.Cells["transactionType"].Value.ToString() : string.Empty;
                quantityTxt.Text = row.Cells["quantity"].Value != DBNull.Value ? row.Cells["quantity"].Value.ToString() : string.Empty;
                priceTxt.Text = row.Cells["price"].Value != DBNull.Value ? row.Cells["price"].Value.ToString() : string.Empty;
                useridBox.SelectedValue = row.Cells["userId"].Value != DBNull.Value ? row.Cells["userId"].Value : -1;

                if (row.Cells["Date"].Value != DBNull.Value)
                {
                    datepurchase.Value = Convert.ToDateTime(row.Cells["Date"].Value);
                }
                else
                {
                    datepurchase.Value = DateTime.Now;
                }
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            string id = idTxt.Text;
            string invId = invBox.SelectedValue?.ToString();
            string transaction = transactionId.Text;
            string date = datepurchase.Value.ToString("yyyy-MM-dd");
            string quantities = quantityTxt.Text;
            string prices = priceTxt.Text;
            string usersId = useridBox.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(invId) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(transaction) || string.IsNullOrEmpty(quantities) || string.IsNullOrEmpty(prices) || string.IsNullOrEmpty(usersId))
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

                string insertQuery = "INSERT INTO inventory_transaction (id, inventoryId, transactionType, quantity, price, userId, Date) VALUES (@id, @inventoryId, @transactionType, @quantity, @price, @userId, @Date)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                insertCmd.Parameters.AddWithValue("@id", id);
                insertCmd.Parameters.AddWithValue("@inventoryId", invId);
                insertCmd.Parameters.AddWithValue("@transactionType", transaction);
                insertCmd.Parameters.AddWithValue("@quantity", quantities);
                insertCmd.Parameters.AddWithValue("@price", prices);
                insertCmd.Parameters.AddWithValue("@userId", usersId);
                insertCmd.Parameters.AddWithValue("@Date", date);

                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Item inserted successfully!");

                LoadUserID();
                LoadInventoryData();
                AvailableId();
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
            string invId = invBox.SelectedValue?.ToString();
            string transaction = transactionId.Text;
            string date = datepurchase.Value.ToString("yyyy-MM-dd");
            string quantities = quantityTxt.Text;
            string prices = priceTxt.Text;
            string usersId = useridBox.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(invId) || string.IsNullOrEmpty(transaction) || string.IsNullOrEmpty(quantities) || string.IsNullOrEmpty(prices) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(usersId))
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

                string updateQuery = "UPDATE inventory_transaction SET inventoryId = @inventoryId, transactionType = @transactionType, quantity = @quantity, price = @price, userId = @userId, Date = @Date WHERE id = @id";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                updateCmd.Parameters.AddWithValue("@id", id);
                updateCmd.Parameters.AddWithValue("@inventoryId", invId);
                updateCmd.Parameters.AddWithValue("@transactionType", transaction);
                updateCmd.Parameters.AddWithValue("@quantity", quantities);
                updateCmd.Parameters.AddWithValue("@price", prices);
                updateCmd.Parameters.AddWithValue("@userId", usersId);
                updateCmd.Parameters.AddWithValue("@Date", date);

                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Item updated successfully!");

                LoadInventoryData();
                AvailableId();
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

                string deleteQuery = "DELETE FROM inventory_transaction WHERE id = @id";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection);
                deleteCmd.Parameters.AddWithValue("@id", id);

                deleteCmd.ExecuteNonQuery();

                MessageBox.Show("Item deleted successfully!");

                LoadUserID();
                LoadInventoryData();
                AvailableId();
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
            invBox.SelectedIndex = -1;
            transactionId.Clear();
            useridBox.SelectedIndex = -1;
            priceTxt.Clear();
            quantityTxt.Clear();
            AvailableId();
            LoadUserID();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                dataGridView2.DataSource = dataTable;
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

        private void LoadDataIntoDataGridView2()
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
                dataGridView2.DataSource = dataTable;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
