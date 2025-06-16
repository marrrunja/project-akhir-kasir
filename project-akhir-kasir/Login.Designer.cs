namespace project_akhir_kasir
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
            btnLogin = new Button();
            textboxPassword = new RichTextBox();
            textboxUsername = new RichTextBox();
            labelUsername = new Label();
            labelPassword = new Label();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(182, 568);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(270, 83);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // textboxPassword
            // 
            textboxPassword.BackColor = Color.LightBlue;
            textboxPassword.ForeColor = Color.White;
            textboxPassword.Location = new Point(45, 352);
            textboxPassword.Margin = new Padding(4);
            textboxPassword.Name = "textboxPassword";
            textboxPassword.Size = new Size(553, 85);
            textboxPassword.TabIndex = 3;
            textboxPassword.Text = "";
            // 
            // textboxUsername
            // 
            textboxUsername.Anchor = AnchorStyles.Left;
            textboxUsername.BackColor = Color.LightBlue;
            textboxUsername.ForeColor = Color.White;
            textboxUsername.Location = new Point(45, 181);
            textboxUsername.Margin = new Padding(4);
            textboxUsername.Name = "textboxUsername";
            textboxUsername.Size = new Size(553, 85);
            textboxUsername.TabIndex = 4;
            textboxUsername.Text = "";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(38, 121);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(167, 45);
            labelUsername.TabIndex = 5;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(37, 288);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(157, 45);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(textboxPassword);
            panel1.Controls.Add(labelUsername);
            panel1.Controls.Add(textboxUsername);
            panel1.ForeColor = Color.DodgerBlue;
            panel1.Location = new Point(492, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 752);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.DodgerBlue;
            linkLabel1.LinkColor = Color.DeepSkyBlue;
            linkLabel1.Location = new Point(418, 466);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(169, 32);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Lupa Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(170, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(314, 71);
            label1.TabIndex = 8;
            label1.Text = "Form Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._8270297;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1604, 958);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private RichTextBox textboxPassword;
        private RichTextBox textboxUsername;
        private Label labelUsername;
        private Label labelPassword;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private Label label1;
    }
}
