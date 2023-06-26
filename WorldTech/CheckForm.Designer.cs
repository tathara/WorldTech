namespace WorldTech
{
    partial class CheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckForm));
            this.shopAddress = new System.Windows.Forms.Label();
            this.shopName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productNames = new System.Windows.Forms.Label();
            this.productPrices = new System.Windows.Forms.Label();
            this.productAmounts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qrCode = new System.Windows.Forms.PictureBox();
            this.thanksText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // shopAddress
            // 
            this.shopAddress.AutoSize = true;
            this.shopAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.shopAddress.Location = new System.Drawing.Point(58, 183);
            this.shopAddress.Name = "shopAddress";
            this.shopAddress.Size = new System.Drawing.Size(546, 25);
            this.shopAddress.TabIndex = 12;
            this.shopAddress.Text = "ул. Объектно-ориентированного программирования, д. 3";
            // 
            // shopName
            // 
            this.shopName.AutoSize = true;
            this.shopName.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.shopName.Location = new System.Drawing.Point(264, 146);
            this.shopName.Name = "shopName";
            this.shopName.Size = new System.Drawing.Size(148, 37);
            this.shopName.TabIndex = 11;
            this.shopName.Text = "WorldTech";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(272, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 160);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // productNames
            // 
            this.productNames.AutoSize = true;
            this.productNames.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNames.Location = new System.Drawing.Point(23, 255);
            this.productNames.Name = "productNames";
            this.productNames.Size = new System.Drawing.Size(0, 21);
            this.productNames.TabIndex = 14;
            // 
            // productPrices
            // 
            this.productPrices.AutoSize = true;
            this.productPrices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productPrices.Location = new System.Drawing.Point(558, 255);
            this.productPrices.Name = "productPrices";
            this.productPrices.Size = new System.Drawing.Size(0, 21);
            this.productPrices.TabIndex = 15;
            // 
            // productAmounts
            // 
            this.productAmounts.AutoSize = true;
            this.productAmounts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productAmounts.Location = new System.Drawing.Point(485, 255);
            this.productAmounts.Name = "productAmounts";
            this.productAmounts.Size = new System.Drawing.Size(0, 21);
            this.productAmounts.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Цена";
            // 
            // qrCode
            // 
            this.qrCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("qrCode.BackgroundImage")));
            this.qrCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.qrCode.Location = new System.Drawing.Point(512, 461);
            this.qrCode.Name = "qrCode";
            this.qrCode.Size = new System.Drawing.Size(130, 130);
            this.qrCode.TabIndex = 20;
            this.qrCode.TabStop = false;
            // 
            // thanksText
            // 
            this.thanksText.AutoSize = true;
            this.thanksText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.thanksText.ForeColor = System.Drawing.Color.Tomato;
            this.thanksText.Location = new System.Drawing.Point(172, 513);
            this.thanksText.Name = "thanksText";
            this.thanksText.Size = new System.Drawing.Size(237, 32);
            this.thanksText.TabIndex = 21;
            this.thanksText.Text = "Спасибо за покупку!";
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(654, 603);
            this.Controls.Add(this.thanksText);
            this.Controls.Add(this.qrCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productAmounts);
            this.Controls.Add(this.productPrices);
            this.Controls.Add(this.productNames);
            this.Controls.Add(this.shopAddress);
            this.Controls.Add(this.shopName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CheckForm";
            this.Text = "CheckForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label shopAddress;
        private Label shopName;
        private PictureBox pictureBox1;
        private Label productNames;
        private Label productPrices;
        private Label productAmounts;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox qrCode;
        private Label thanksText;
    }
}