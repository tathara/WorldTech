namespace WorldTech
{
    partial class OrderRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderRegistrationForm));
            this.shopName = new System.Windows.Forms.Label();
            this.shopAddress = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.finalPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentMethodBox = new System.Windows.Forms.ComboBox();
            this.placeAnOrderButton = new System.Windows.Forms.Button();
            this.receiveMethodBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shopName
            // 
            this.shopName.AutoSize = true;
            this.shopName.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.shopName.Location = new System.Drawing.Point(215, 108);
            this.shopName.Name = "shopName";
            this.shopName.Size = new System.Drawing.Size(148, 37);
            this.shopName.TabIndex = 0;
            this.shopName.Text = "WorldTech";
            // 
            // shopAddress
            // 
            this.shopAddress.AutoSize = true;
            this.shopAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.shopAddress.Location = new System.Drawing.Point(2, 145);
            this.shopAddress.Name = "shopAddress";
            this.shopAddress.Size = new System.Drawing.Size(546, 25);
            this.shopAddress.TabIndex = 1;
            this.shopAddress.Text = "ул. Объектно-ориентированного программирования, д. 3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(228, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // finalPrice
            // 
            this.finalPrice.AutoSize = true;
            this.finalPrice.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finalPrice.ForeColor = System.Drawing.Color.Tomato;
            this.finalPrice.Location = new System.Drawing.Point(239, 214);
            this.finalPrice.Name = "finalPrice";
            this.finalPrice.Size = new System.Drawing.Size(0, 37);
            this.finalPrice.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(209, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Итоговая сумма:";
            // 
            // paymentMethodBox
            // 
            this.paymentMethodBox.BackColor = System.Drawing.Color.Linen;
            this.paymentMethodBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.paymentMethodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethodBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentMethodBox.Items.AddRange(new object[] {
            "Наличный расчет",
            "Банковская карта",
            "Электронный кошелек",
            "Баллы по ООП",
            "Трудоустройство разработчика"});
            this.paymentMethodBox.Location = new System.Drawing.Point(34, 296);
            this.paymentMethodBox.Name = "paymentMethodBox";
            this.paymentMethodBox.Size = new System.Drawing.Size(202, 28);
            this.paymentMethodBox.TabIndex = 14;
            this.paymentMethodBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.paymentMethodBox_DrawItem);
            // 
            // placeAnOrderButton
            // 
            this.placeAnOrderButton.BackColor = System.Drawing.Color.BurlyWood;
            this.placeAnOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.placeAnOrderButton.FlatAppearance.BorderSize = 0;
            this.placeAnOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeAnOrderButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.placeAnOrderButton.Location = new System.Drawing.Point(195, 370);
            this.placeAnOrderButton.Name = "placeAnOrderButton";
            this.placeAnOrderButton.Size = new System.Drawing.Size(180, 50);
            this.placeAnOrderButton.TabIndex = 15;
            this.placeAnOrderButton.Text = "Оформить заказ";
            this.placeAnOrderButton.UseVisualStyleBackColor = false;
            this.placeAnOrderButton.Click += new System.EventHandler(this.placeAnOrderButton_Click);
            // 
            // receiveMethodBox
            // 
            this.receiveMethodBox.BackColor = System.Drawing.Color.Linen;
            this.receiveMethodBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.receiveMethodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.receiveMethodBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiveMethodBox.FormattingEnabled = true;
            this.receiveMethodBox.Items.AddRange(new object[] {
            "Самовывоз",
            "Доставка курьером"});
            this.receiveMethodBox.Location = new System.Drawing.Point(328, 296);
            this.receiveMethodBox.Name = "receiveMethodBox";
            this.receiveMethodBox.Size = new System.Drawing.Size(202, 28);
            this.receiveMethodBox.TabIndex = 16;
            this.receiveMethodBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.receiveMethodBox_DrawItem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Способ получения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Способ оплаты";
            // 
            // OrderRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(548, 441);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receiveMethodBox);
            this.Controls.Add(this.placeAnOrderButton);
            this.Controls.Add(this.paymentMethodBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.finalPrice);
            this.Controls.Add(this.shopAddress);
            this.Controls.Add(this.shopName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderRegistrationForm";
            this.Text = "WorldTech";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label shopName;
        private Label shopAddress;
        private PictureBox pictureBox1;
        private Label finalPrice;
        private Label label2;
        private ComboBox paymentMethodBox;
        private Button placeAnOrderButton;
        private ComboBox receiveMethodBox;
        private Label label1;
        private Label label3;
    }
}