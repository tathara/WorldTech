namespace WorldTech
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.label1 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.RichTextBox();
            this.loginText = new System.Windows.Forms.RichTextBox();
            this.GoToLogInButton = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordCheckText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(149, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.Color.Cornsilk;
            this.nameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameText.Location = new System.Drawing.Point(26, 81);
            this.nameText.Margin = new System.Windows.Forms.Padding(4);
            this.nameText.Multiline = false;
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(206, 28);
            this.nameText.TabIndex = 1;
            this.nameText.Text = "Имя";
            this.nameText.Enter += new System.EventHandler(this.nameText_Enter);
            this.nameText.Leave += new System.EventHandler(this.nameText_Leave);
            // 
            // loginText
            // 
            this.loginText.BackColor = System.Drawing.Color.Cornsilk;
            this.loginText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginText.Location = new System.Drawing.Point(26, 135);
            this.loginText.Margin = new System.Windows.Forms.Padding(4);
            this.loginText.Multiline = false;
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(206, 28);
            this.loginText.TabIndex = 4;
            this.loginText.Text = "Логин";
            this.loginText.Enter += new System.EventHandler(this.loginText_Enter);
            this.loginText.Leave += new System.EventHandler(this.loginText_Leave);
            // 
            // GoToLogInButton
            // 
            this.GoToLogInButton.AutoSize = true;
            this.GoToLogInButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.GoToLogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToLogInButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GoToLogInButton.Location = new System.Drawing.Point(178, 244);
            this.GoToLogInButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GoToLogInButton.Name = "GoToLogInButton";
            this.GoToLogInButton.Size = new System.Drawing.Size(125, 21);
            this.GoToLogInButton.TabIndex = 5;
            this.GoToLogInButton.Text = "Войти в аккаунт";
            this.GoToLogInButton.Click += new System.EventHandler(this.GoToLogInButton_Click);
            this.GoToLogInButton.MouseEnter += new System.EventHandler(this.GoToLogInButton_MouseEnter);
            this.GoToLogInButton.MouseLeave += new System.EventHandler(this.GoToLogInButton_MouseLeave);
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.FlatAppearance.BorderSize = 0;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Location = new System.Drawing.Point(105, 184);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(4);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(255, 52);
            this.SignUpButton.TabIndex = 6;
            this.SignUpButton.Text = "Зерегистрироваться";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 480);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.Color.Cornsilk;
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Location = new System.Drawing.Point(240, 81);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(207, 28);
            this.passwordText.TabIndex = 10;
            this.passwordText.Text = "Пароль";
            this.passwordText.Enter += new System.EventHandler(this.passwordText_Enter);
            this.passwordText.Leave += new System.EventHandler(this.passwordText_Leave);
            // 
            // passwordCheckText
            // 
            this.passwordCheckText.BackColor = System.Drawing.Color.Cornsilk;
            this.passwordCheckText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordCheckText.Location = new System.Drawing.Point(240, 135);
            this.passwordCheckText.Name = "passwordCheckText";
            this.passwordCheckText.Size = new System.Drawing.Size(207, 28);
            this.passwordCheckText.TabIndex = 11;
            this.passwordCheckText.Text = "Повторите пароль";
            this.passwordCheckText.Enter += new System.EventHandler(this.passwordCheckText_Enter);
            this.passwordCheckText.Leave += new System.EventHandler(this.passwordCheckText_Leave);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(468, 399);
            this.Controls.Add(this.passwordCheckText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.GoToLogInButton);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "SignUpForm";
            this.Text = "WorldTech";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RichTextBox nameText;
        private RichTextBox loginText;
        private Label GoToLogInButton;
        private Button SignUpButton;
        private PictureBox pictureBox1;
        private TextBox passwordText;
        private TextBox passwordCheckText;
    }
}