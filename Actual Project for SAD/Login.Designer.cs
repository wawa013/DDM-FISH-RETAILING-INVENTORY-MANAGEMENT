namespace Actual_Project_for_SAD
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            usernameTxt = new TextBox();
            passwordTxt = new TextBox();
            loginBTN = new Button();
            registerBTN = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 133);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 178);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(165, 130);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(160, 27);
            usernameTxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(165, 175);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(160, 27);
            passwordTxt.TabIndex = 3;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // loginBTN
            // 
            loginBTN.BackgroundImage = Properties.Resources.login_bg_bro;
            loginBTN.ForeColor = SystemColors.Control;
            loginBTN.Location = new Point(78, 232);
            loginBTN.Name = "loginBTN";
            loginBTN.Size = new Size(136, 34);
            loginBTN.TabIndex = 4;
            loginBTN.Text = "Login";
            loginBTN.UseVisualStyleBackColor = true;
            loginBTN.Click += loginBTN_Click;
            // 
            // registerBTN
            // 
            registerBTN.BackgroundImage = Properties.Resources.login_bg_bro;
            registerBTN.ForeColor = SystemColors.Control;
            registerBTN.Location = new Point(235, 232);
            registerBTN.Name = "registerBTN";
            registerBTN.Size = new Size(136, 34);
            registerBTN.TabIndex = 5;
            registerBTN.Text = "Register";
            registerBTN.UseVisualStyleBackColor = true;
            registerBTN.Click += registerBTN_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.ddm_official_logo;
            panel1.Location = new Point(448, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 424);
            panel1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(916, 424);
            Controls.Add(panel1);
            Controls.Add(registerBTN);
            Controls.Add(loginBTN);
            Controls.Add(passwordTxt);
            Controls.Add(usernameTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DDM FISH RETAILING";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameTxt;
        private Button loginBTN;
        private Button registerBTN;
        private Panel panel1;
        private TextBox passwordTxt;
    }
}