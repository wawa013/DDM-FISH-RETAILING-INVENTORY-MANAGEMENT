namespace Actual_Project_for_SAD
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            panel1 = new Panel();
            transactionsBtn = new Button();
            panel2 = new Panel();
            LogoutBTN = new Button();
            dataGridView1 = new DataGridView();
            insertBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            idTxt = new TextBox();
            clearBtn = new Button();
            productBox = new ComboBox();
            label4 = new Label();
            quantityTxt = new TextBox();
            label5 = new Label();
            supplierBox = new ComboBox();
            managerBox = new ComboBox();
            userTxt = new Label();
            usernameTxt = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(transactionsBtn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(LogoutBTN);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 380);
            panel1.TabIndex = 2;
            // 
            // transactionsBtn
            // 
            transactionsBtn.BackgroundImage = Properties.Resources.transactions;
            transactionsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            transactionsBtn.Location = new Point(33, 150);
            transactionsBtn.Margin = new Padding(3, 2, 3, 2);
            transactionsBtn.Name = "transactionsBtn";
            transactionsBtn.Size = new Size(74, 57);
            transactionsBtn.TabIndex = 4;
            transactionsBtn.UseVisualStyleBackColor = true;
            transactionsBtn.Click += transactionsBtn_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.BackgroundImage = Properties.Resources.ddm_official_logo;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(17, 16);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(117, 100);
            panel2.TabIndex = 3;
            // 
            // LogoutBTN
            // 
            LogoutBTN.BackgroundImage = Properties.Resources.button1;
            LogoutBTN.BackgroundImageLayout = ImageLayout.Stretch;
            LogoutBTN.Location = new Point(33, 312);
            LogoutBTN.Margin = new Padding(3, 2, 3, 2);
            LogoutBTN.Name = "LogoutBTN";
            LogoutBTN.Size = new Size(74, 57);
            LogoutBTN.TabIndex = 2;
            LogoutBTN.UseVisualStyleBackColor = true;
            LogoutBTN.Click += LogoutBTN_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(453, 28);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(595, 289);
            dataGridView1.TabIndex = 3;
            // 
            // insertBtn
            // 
            insertBtn.Location = new Point(172, 328);
            insertBtn.Margin = new Padding(3, 2, 3, 2);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(106, 31);
            insertBtn.TabIndex = 4;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += insertBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(283, 328);
            updateBtn.Margin = new Padding(3, 2, 3, 2);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(106, 31);
            updateBtn.TabIndex = 5;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(394, 328);
            deleteBtn.Margin = new Padding(3, 2, 3, 2);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(106, 31);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(255, 91);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 7;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(199, 151);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 8;
            label2.Text = "PRODUCT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(196, 182);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 9;
            label3.Text = "QUANTITY:";
            // 
            // idTxt
            // 
            idTxt.Location = new Point(301, 91);
            idTxt.Margin = new Padding(3, 2, 3, 2);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(133, 23);
            idTxt.TabIndex = 10;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(505, 328);
            clearBtn.Margin = new Padding(3, 2, 3, 2);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(106, 31);
            clearBtn.TabIndex = 11;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // productBox
            // 
            productBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productBox.FormattingEnabled = true;
            productBox.Location = new Point(301, 154);
            productBox.Margin = new Padding(3, 2, 3, 2);
            productBox.Name = "productBox";
            productBox.Size = new Size(133, 23);
            productBox.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(172, 122);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 13;
            label4.Text = "SUPPLIER'S ID:";
            // 
            // quantityTxt
            // 
            quantityTxt.Location = new Point(301, 184);
            quantityTxt.Margin = new Padding(3, 2, 3, 2);
            quantityTxt.Name = "quantityTxt";
            quantityTxt.Size = new Size(133, 23);
            quantityTxt.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(165, 214);
            label5.Name = "label5";
            label5.Size = new Size(120, 21);
            label5.TabIndex = 16;
            label5.Text = "MANAGER'S ID:";
            // 
            // supplierBox
            // 
            supplierBox.DropDownStyle = ComboBoxStyle.DropDownList;
            supplierBox.FormattingEnabled = true;
            supplierBox.Location = new Point(301, 122);
            supplierBox.Margin = new Padding(3, 2, 3, 2);
            supplierBox.Name = "supplierBox";
            supplierBox.Size = new Size(133, 23);
            supplierBox.TabIndex = 18;
            // 
            // managerBox
            // 
            managerBox.DropDownStyle = ComboBoxStyle.DropDownList;
            managerBox.FormattingEnabled = true;
            managerBox.Location = new Point(301, 216);
            managerBox.Margin = new Padding(3, 2, 3, 2);
            managerBox.Name = "managerBox";
            managerBox.Size = new Size(133, 23);
            managerBox.TabIndex = 19;
            // 
            // userTxt
            // 
            userTxt.AutoSize = true;
            userTxt.Location = new Point(172, 41);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(44, 15);
            userTxt.TabIndex = 20;
            userTxt.Text = "UserID:";
            userTxt.Click += userTxt_Click;
            // 
            // usernameTxt
            // 
            usernameTxt.AutoSize = true;
            usernameTxt.Location = new Point(172, 17);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(64, 15);
            usernameTxt.TabIndex = 21;
            usernameTxt.Text = "Hello, User";
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 381);
            Controls.Add(usernameTxt);
            Controls.Add(userTxt);
            Controls.Add(managerBox);
            Controls.Add(supplierBox);
            Controls.Add(label5);
            Controls.Add(quantityTxt);
            Controls.Add(label4);
            Controls.Add(productBox);
            Controls.Add(clearBtn);
            Controls.Add(idTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(insertBtn);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inventory";
            Text = "DDM FISH RETAILING";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Button LogoutBTN;
        private DataGridView dataGridView1;
        private Button insertBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox idTxt;
        private Button clearBtn;
        private ComboBox productBox;
        private Label label4;
        private TextBox quantityTxt;
        private Label label5;
        private Button transactionsBtn;
        private ComboBox supplierBox;
        private ComboBox managerBox;
        private Label userTxt;
        private Label usernameTxt;
    }
}