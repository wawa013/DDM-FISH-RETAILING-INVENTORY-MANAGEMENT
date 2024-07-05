namespace Actual_Project_for_SAD
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            RegisterBTN = new Button();
            idTxt = new TextBox();
            userTxt = new TextBox();
            passTxt = new TextBox();
            PositionBox = new ComboBox();
            panel1 = new Panel();
            label5 = new Label();
            HidepassBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 98);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 140);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 217);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Position:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 176);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // RegisterBTN
            // 
            RegisterBTN.BackgroundImage = Properties.Resources.login_bg_bro;
            RegisterBTN.ForeColor = SystemColors.Control;
            RegisterBTN.Location = new Point(95, 309);
            RegisterBTN.Name = "RegisterBTN";
            RegisterBTN.Size = new Size(135, 35);
            RegisterBTN.TabIndex = 4;
            RegisterBTN.Text = "Register";
            RegisterBTN.UseVisualStyleBackColor = true;
            RegisterBTN.Click += RegisterBTN_Click;
            // 
            // idTxt
            // 
            idTxt.Location = new Point(118, 91);
            idTxt.Name = "idTxt";
            idTxt.ReadOnly = true;
            idTxt.Size = new Size(154, 27);
            idTxt.TabIndex = 5;
            // 
            // userTxt
            // 
            userTxt.Location = new Point(118, 140);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(154, 27);
            userTxt.TabIndex = 6;
            // 
            // passTxt
            // 
            passTxt.Location = new Point(118, 173);
            passTxt.Name = "passTxt";
            passTxt.PasswordChar = '*';
            passTxt.Size = new Size(154, 27);
            passTxt.TabIndex = 7;
            // 
            // PositionBox
            // 
            PositionBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PositionBox.FormattingEnabled = true;
            PositionBox.Location = new Point(118, 214);
            PositionBox.Name = "PositionBox";
            PositionBox.Size = new Size(118, 28);
            PositionBox.TabIndex = 8;
            PositionBox.SelectedIndexChanged += PositionBox_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.ddm_official_logo;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(-2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(67, 65);
            panel1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(62, 27);
            label5.Name = "label5";
            label5.Size = new Size(246, 31);
            label5.TabIndex = 10;
            label5.Text = "REGISTRATION FORM";
            // 
            // HidepassBtn
            // 
            HidepassBtn.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            HidepassBtn.Location = new Point(278, 170);
            HidepassBtn.Name = "HidepassBtn";
            HidepassBtn.Size = new Size(39, 30);
            HidepassBtn.TabIndex = 11;
            HidepassBtn.Text = "Hide";
            HidepassBtn.UseVisualStyleBackColor = true;
            HidepassBtn.Click += HidepassBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(329, 356);
            Controls.Add(HidepassBtn);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(PositionBox);
            Controls.Add(passTxt);
            Controls.Add(userTxt);
            Controls.Add(idTxt);
            Controls.Add(RegisterBTN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "DDM FISH RETAILING";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button RegisterBTN;
        private TextBox idTxt;
        private TextBox userTxt;
        private TextBox passTxt;
        private ComboBox PositionBox;
        private Panel panel1;
        private Label label5;
        private Button HidepassBtn;
    }
}