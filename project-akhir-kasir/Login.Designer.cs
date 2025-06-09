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
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(382, 474);
            btnLogin.Margin = new Padding(4, 4, 4, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(545, 83);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // textboxPassword
            // 
            textboxPassword.Location = new Point(382, 358);
            textboxPassword.Margin = new Padding(4, 4, 4, 4);
            textboxPassword.Name = "textboxPassword";
            textboxPassword.Size = new Size(553, 85);
            textboxPassword.TabIndex = 3;
            textboxPassword.Text = "";
            // 
            // textboxUsername
            // 
            textboxUsername.Anchor = AnchorStyles.Left;
            textboxUsername.Location = new Point(382, 186);
            textboxUsername.Margin = new Padding(4, 4, 4, 4);
            textboxUsername.Name = "textboxUsername";
            textboxUsername.Size = new Size(553, 85);
            textboxUsername.TabIndex = 4;
            textboxUsername.Text = "";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(382, 127);
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
            labelPassword.Location = new Point(382, 294);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(167, 45);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Username";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1226, 669);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(textboxUsername);
            Controls.Add(textboxPassword);
            Controls.Add(btnLogin);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private RichTextBox textboxPassword;
        private RichTextBox textboxUsername;
        private Label labelUsername;
        private Label labelPassword;
    }
}
