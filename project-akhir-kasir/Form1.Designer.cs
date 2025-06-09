namespace project_akhir_kasir
{
    partial class Form1
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
            button1 = new Button();
            textboxPassword = new RichTextBox();
            textboxUsername = new RichTextBox();
            labelUsername = new Label();
            labelPassword = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(294, 370);
            button1.Name = "button1";
            button1.Size = new Size(419, 65);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textboxPassword
            // 
            textboxPassword.Location = new Point(294, 280);
            textboxPassword.Name = "textboxPassword";
            textboxPassword.Size = new Size(426, 67);
            textboxPassword.TabIndex = 3;
            textboxPassword.Text = "";
            // 
            // textboxUsername
            // 
            textboxUsername.Location = new Point(294, 145);
            textboxUsername.Name = "textboxUsername";
            textboxUsername.Size = new Size(426, 67);
            textboxUsername.TabIndex = 4;
            textboxUsername.Text = "";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(294, 99);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(124, 32);
            labelUsername.TabIndex = 5;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(294, 230);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(124, 32);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Username";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(943, 523);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(textboxUsername);
            Controls.Add(textboxPassword);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox textboxPassword;
        private RichTextBox textboxUsername;
        private Label labelUsername;
        private Label labelPassword;
    }
}
