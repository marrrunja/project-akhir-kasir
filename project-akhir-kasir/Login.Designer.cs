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
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(98, 266);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(145, 39);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // textboxPassword
            // 
            textboxPassword.Anchor = AnchorStyles.None;
            textboxPassword.BackColor = Color.LightBlue;
            textboxPassword.ForeColor = Color.White;
            textboxPassword.Location = new Point(24, 165);
            textboxPassword.Margin = new Padding(2);
            textboxPassword.Name = "textboxPassword";
            textboxPassword.Size = new Size(300, 42);
            textboxPassword.TabIndex = 3;
            textboxPassword.Text = "";
            // 
            // textboxUsername
            // 
            textboxUsername.Anchor = AnchorStyles.None;
            textboxUsername.BackColor = Color.LightBlue;
            textboxUsername.ForeColor = Color.White;
            textboxUsername.Location = new Point(24, 95);
            textboxUsername.Margin = new Padding(2);
            textboxUsername.Name = "textboxUsername";
            textboxUsername.Size = new Size(300, 42);
            textboxUsername.TabIndex = 4;
            textboxUsername.Text = "";
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.None;
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(20, 57);
            labelUsername.Margin = new Padding(2, 0, 2, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(83, 21);
            labelUsername.TabIndex = 5;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.None;
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(20, 135);
            labelPassword.Margin = new Padding(2, 0, 2, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(79, 21);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Password";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
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
            panel1.Location = new Point(223, 76);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 334);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 37);
            label1.TabIndex = 8;
            label1.Text = "Form Login";
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.DodgerBlue;
            linkLabel1.LinkColor = Color.DeepSkyBlue;
            linkLabel1.Location = new Point(225, 218);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(86, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Lupa Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._8270297;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(856, 531);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Login";
            Load += Login_Load;
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
