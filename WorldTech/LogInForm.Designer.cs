namespace WorldTech
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.label1 = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.RichTextBox();
            this.LogInButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.returnToRegistration = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(136, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вход в аккаунт";
            // 
            // loginText
            // 
            this.loginText.BackColor = System.Drawing.Color.Cornsilk;
            this.loginText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginText.Location = new System.Drawing.Point(136, 88);
            this.loginText.Margin = new System.Windows.Forms.Padding(4);
            this.loginText.Multiline = false;
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(206, 28);
            this.loginText.TabIndex = 6;
            this.loginText.Text = "Логин";
            this.loginText.Enter += new System.EventHandler(this.loginText_Enter);
            this.loginText.Leave += new System.EventHandler(this.loginText_Leave);
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.LogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInButton.FlatAppearance.BorderSize = 0;
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInButton.Location = new System.Drawing.Point(172, 184);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(135, 52);
            this.LogInButton.TabIndex = 7;
            this.LogInButton.Text = "Войти";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Linen;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 480);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // returnToRegistration
            // 
            this.returnToRegistration.AutoSize = true;
            this.returnToRegistration.BackColor = System.Drawing.Color.NavajoWhite;
            this.returnToRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnToRegistration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnToRegistration.Location = new System.Drawing.Point(145, 244);
            this.returnToRegistration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.returnToRegistration.Name = "returnToRegistration";
            this.returnToRegistration.Size = new System.Drawing.Size(190, 21);
            this.returnToRegistration.TabIndex = 9;
            this.returnToRegistration.Text = "Вернуться к регистрации";
            this.returnToRegistration.Click += new System.EventHandler(this.returnToRegistration_Click);
            this.returnToRegistration.MouseEnter += new System.EventHandler(this.returnToRegistration_MouseEnter);
            this.returnToRegistration.MouseLeave += new System.EventHandler(this.returnToRegistration_MouseLeave);
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.Color.Cornsilk;
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Location = new System.Drawing.Point(136, 133);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(206, 28);
            this.passwordText.TabIndex = 10;
            this.passwordText.Text = "Пароль";
            this.passwordText.Enter += new System.EventHandler(this.passwordText_Enter);
            this.passwordText.Leave += new System.EventHandler(this.passwordText_Leave);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 399);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.returnToRegistration);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "LogInForm";
            this.Text = "WorldTech";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RichTextBox loginText;
        private Button LogInButton;
        private PictureBox pictureBox1;
        private Label returnToRegistration;
        private TextBox passwordText;
    }
}