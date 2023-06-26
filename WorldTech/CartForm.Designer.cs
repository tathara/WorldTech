namespace WorldTech
{
    partial class CartForm
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Процессоры", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Материнские платы", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Видеокарты", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Оперативная память", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Корпуса", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Блоки питания", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Охлаждение компьютера", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Жесткие диски", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            this.placeAnOrderButton = new System.Windows.Forms.Button();
            this.deleteFromCartButton = new System.Windows.Forms.Button();
            this.listOfProductsInCart = new System.Windows.Forms.ListView();
            this.ProductName = new System.Windows.Forms.ColumnHeader();
            this.Amount = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.clearTheCart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // placeAnOrderButton
            // 
            this.placeAnOrderButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.placeAnOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.placeAnOrderButton.FlatAppearance.BorderSize = 0;
            this.placeAnOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeAnOrderButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.placeAnOrderButton.Location = new System.Drawing.Point(585, 312);
            this.placeAnOrderButton.Name = "placeAnOrderButton";
            this.placeAnOrderButton.Size = new System.Drawing.Size(135, 63);
            this.placeAnOrderButton.TabIndex = 1;
            this.placeAnOrderButton.Text = "Перейти к оформлению";
            this.placeAnOrderButton.UseVisualStyleBackColor = false;
            this.placeAnOrderButton.Click += new System.EventHandler(this.placeAnOrderButton_Click);
            // 
            // deleteFromCartButton
            // 
            this.deleteFromCartButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.deleteFromCartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteFromCartButton.FlatAppearance.BorderSize = 0;
            this.deleteFromCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFromCartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteFromCartButton.Location = new System.Drawing.Point(600, 230);
            this.deleteFromCartButton.Name = "deleteFromCartButton";
            this.deleteFromCartButton.Size = new System.Drawing.Size(107, 35);
            this.deleteFromCartButton.TabIndex = 2;
            this.deleteFromCartButton.Text = "Удалить";
            this.deleteFromCartButton.UseVisualStyleBackColor = false;
            this.deleteFromCartButton.Click += new System.EventHandler(this.deleteFromCartButton_Click);
            // 
            // listOfProductsInCart
            // 
            this.listOfProductsInCart.BackColor = System.Drawing.Color.White;
            this.listOfProductsInCart.BackgroundImageTiled = true;
            this.listOfProductsInCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOfProductsInCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductName,
            this.Amount,
            this.Price});
            this.listOfProductsInCart.FullRowSelect = true;
            this.listOfProductsInCart.GridLines = true;
            listViewGroup1.Header = "Процессоры";
            listViewGroup1.Name = "Cpus";
            listViewGroup2.Header = "Материнские платы";
            listViewGroup2.Name = "Motherboards";
            listViewGroup3.Header = "Видеокарты";
            listViewGroup3.Name = "Gpus";
            listViewGroup4.Header = "Оперативная память";
            listViewGroup4.Name = "Ram";
            listViewGroup5.Header = "Корпуса";
            listViewGroup5.Name = "Cases";
            listViewGroup6.Header = "Блоки питания";
            listViewGroup6.Name = "PowerSupplies";
            listViewGroup7.Header = "Охлаждение компьютера";
            listViewGroup7.Name = "CoolingSystems";
            listViewGroup8.Header = "Жесткие диски";
            listViewGroup8.Name = "Hdds";
            this.listOfProductsInCart.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8});
            this.listOfProductsInCart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listOfProductsInCart.Location = new System.Drawing.Point(12, 12);
            this.listOfProductsInCart.MultiSelect = false;
            this.listOfProductsInCart.Name = "listOfProductsInCart";
            this.listOfProductsInCart.Size = new System.Drawing.Size(548, 363);
            this.listOfProductsInCart.TabIndex = 6;
            this.listOfProductsInCart.UseCompatibleStateImageBehavior = false;
            this.listOfProductsInCart.View = System.Windows.Forms.View.Details;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Название продукта";
            this.ProductName.Width = 388;
            // 
            // Amount
            // 
            this.Amount.Text = "Количество";
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Amount.Width = 95;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clearTheCart
            // 
            this.clearTheCart.BackColor = System.Drawing.Color.NavajoWhite;
            this.clearTheCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearTheCart.FlatAppearance.BorderSize = 0;
            this.clearTheCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearTheCart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearTheCart.Location = new System.Drawing.Point(575, 271);
            this.clearTheCart.Name = "clearTheCart";
            this.clearTheCart.Size = new System.Drawing.Size(155, 35);
            this.clearTheCart.TabIndex = 7;
            this.clearTheCart.Text = "Очистить корзину";
            this.clearTheCart.UseVisualStyleBackColor = false;
            this.clearTheCart.Click += new System.EventHandler(this.clearTheCart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Linen;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(575, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(742, 389);
            this.Controls.Add(this.clearTheCart);
            this.Controls.Add(this.listOfProductsInCart);
            this.Controls.Add(this.deleteFromCartButton);
            this.Controls.Add(this.placeAnOrderButton);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CartForm";
            this.Text = "WorldTech";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button placeAnOrderButton;
        private Button deleteFromCartButton;
        private ListView listOfProductsInCart;
        private ColumnHeader ProductName;
        private Button clearTheCart;
        private ColumnHeader Amount;
        private ColumnHeader Price;
        private ListView listOfProducts;
        private ColumnHeader Type;
        private ColumnHeader Manufacturer;
        private ColumnHeader Model;
        private ColumnHeader columnHeader1;
        private ColumnHeader Rating;
        private PictureBox pictureBox1;
    }
}