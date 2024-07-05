namespace Actual_Project_for_SAD
{
    partial class InventoryTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryTransaction));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            idTxt = new TextBox();
            transactionId = new TextBox();
            datepurchase = new DateTimePicker();
            insertBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            clearBtn = new Button();
            invBox = new ComboBox();
            useridBox = new ComboBox();
            dataGridView2 = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            quantityTxt = new TextBox();
            priceTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(402, 214);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(646, 233);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(132, 56);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 85);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 2;
            label2.Text = "INVENTORY ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 113);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 3;
            label3.Text = "TRANSACTION TYPE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(108, 138);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 4;
            label4.Text = "DATE:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(74, 165);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 5;
            label5.Text = "QUANTITY:";
            // 
            // idTxt
            // 
            idTxt.Location = new Point(168, 59);
            idTxt.Margin = new Padding(3, 2, 3, 2);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(193, 23);
            idTxt.TabIndex = 6;
            // 
            // transactionId
            // 
            transactionId.Location = new Point(168, 113);
            transactionId.Margin = new Padding(3, 2, 3, 2);
            transactionId.Name = "transactionId";
            transactionId.Size = new Size(193, 23);
            transactionId.TabIndex = 8;
            // 
            // datepurchase
            // 
            datepurchase.Location = new Point(168, 138);
            datepurchase.Margin = new Padding(3, 2, 3, 2);
            datepurchase.Name = "datepurchase";
            datepurchase.Size = new Size(193, 23);
            datepurchase.TabIndex = 9;
            // 
            // insertBtn
            // 
            insertBtn.Location = new Point(12, 314);
            insertBtn.Margin = new Padding(3, 2, 3, 2);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(90, 28);
            insertBtn.TabIndex = 11;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += insertBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(106, 314);
            updateBtn.Margin = new Padding(3, 2, 3, 2);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(90, 28);
            updateBtn.TabIndex = 12;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(202, 314);
            deleteBtn.Margin = new Padding(3, 2, 3, 2);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(90, 28);
            deleteBtn.TabIndex = 13;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(298, 314);
            clearBtn.Margin = new Padding(3, 2, 3, 2);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(90, 28);
            clearBtn.TabIndex = 14;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // invBox
            // 
            invBox.DropDownStyle = ComboBoxStyle.DropDownList;
            invBox.FormattingEnabled = true;
            invBox.Location = new Point(168, 85);
            invBox.Margin = new Padding(3, 2, 3, 2);
            invBox.Name = "invBox";
            invBox.Size = new Size(193, 23);
            invBox.TabIndex = 15;
            // 
            // useridBox
            // 
            useridBox.DropDownStyle = ComboBoxStyle.DropDownList;
            useridBox.FormattingEnabled = true;
            useridBox.Location = new Point(168, 220);
            useridBox.Margin = new Padding(3, 2, 3, 2);
            useridBox.Name = "useridBox";
            useridBox.Size = new Size(193, 23);
            useridBox.TabIndex = 16;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(402, 22);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(646, 175);
            dataGridView2.TabIndex = 17;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(90, 223);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 18;
            label6.Text = "USER ID:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(106, 192);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 19;
            label7.Text = "PRICE:";
            // 
            // quantityTxt
            // 
            quantityTxt.Location = new Point(168, 166);
            quantityTxt.Margin = new Padding(3, 2, 3, 2);
            quantityTxt.Name = "quantityTxt";
            quantityTxt.Size = new Size(193, 23);
            quantityTxt.TabIndex = 20;
            // 
            // priceTxt
            // 
            priceTxt.Location = new Point(168, 193);
            priceTxt.Margin = new Padding(3, 2, 3, 2);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(193, 23);
            priceTxt.TabIndex = 21;
            // 
            // InventoryTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 458);
            Controls.Add(priceTxt);
            Controls.Add(quantityTxt);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dataGridView2);
            Controls.Add(useridBox);
            Controls.Add(invBox);
            Controls.Add(clearBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(insertBtn);
            Controls.Add(datepurchase);
            Controls.Add(transactionId);
            Controls.Add(idTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "InventoryTransaction";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "DDM FISH RETAILING";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox idTxt;
        private TextBox transactionId;
        private DateTimePicker datepurchase;
        private Button insertBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button clearBtn;
        private ComboBox invBox;
        private ComboBox useridBox;
        private DataGridView dataGridView2;
        private Label label6;
        private Label label7;
        private TextBox quantityTxt;
        private TextBox priceTxt;
    }
}