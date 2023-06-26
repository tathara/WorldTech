namespace WorldTech
{
    partial class ShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Процессоры", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Материнские платы", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Видеокарты", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Оперативная память", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Корпуса", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Блоки питания", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Охлаждение компьютера", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Жесткие диски", System.Windows.Forms.HorizontalAlignment.Left);
            this.userButton = new System.Windows.Forms.Button();
            this.cartButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.listOfProducts = new System.Windows.Forms.ListView();
            this.Type = new System.Windows.Forms.ColumnHeader();
            this.Manufacturer = new System.Windows.Forms.ColumnHeader();
            this.Model = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.Rating = new System.Windows.Forms.ColumnHeader();
            this.userNameText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cpusLabel = new System.Windows.Forms.Label();
            this.motherboardsLabel = new System.Windows.Forms.Label();
            this.gpusLabel = new System.Windows.Forms.Label();
            this.ramLabel = new System.Windows.Forms.Label();
            this.casesLabel = new System.Windows.Forms.Label();
            this.powerSuppliesLabel = new System.Windows.Forms.Label();
            this.coolingSystemsLabel = new System.Windows.Forms.Label();
            this.hddsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.findButton = new System.Windows.Forms.Button();
            this.signOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.Color.Linen;
            this.userButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userButton.BackgroundImage")));
            this.userButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen;
            this.userButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.ForeColor = System.Drawing.Color.Transparent;
            this.userButton.Location = new System.Drawing.Point(151, 28);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(60, 60);
            this.userButton.TabIndex = 0;
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // cartButton
            // 
            this.cartButton.BackColor = System.Drawing.Color.Linen;
            this.cartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cartButton.BackgroundImage")));
            this.cartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartButton.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.cartButton.FlatAppearance.BorderSize = 0;
            this.cartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen;
            this.cartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.cartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartButton.ForeColor = System.Drawing.Color.Transparent;
            this.cartButton.Location = new System.Drawing.Point(233, 33);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(50, 50);
            this.cartButton.TabIndex = 1;
            this.cartButton.UseVisualStyleBackColor = false;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Linen;
            this.refreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshButton.BackgroundImage")));
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen;
            this.refreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(347, 25);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(30, 30);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addToCartButton
            // 
            this.addToCartButton.BackColor = System.Drawing.Color.White;
            this.addToCartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addToCartButton.BackgroundImage")));
            this.addToCartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addToCartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToCartButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addToCartButton.FlatAppearance.BorderSize = 0;
            this.addToCartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.addToCartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addToCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCartButton.ForeColor = System.Drawing.Color.White;
            this.addToCartButton.Location = new System.Drawing.Point(850, 436);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(140, 50);
            this.addToCartButton.TabIndex = 3;
            this.addToCartButton.UseVisualStyleBackColor = false;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // listOfProducts
            // 
            this.listOfProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.Manufacturer,
            this.Model,
            this.Price,
            this.Rating});
            this.listOfProducts.FullRowSelect = true;
            this.listOfProducts.GridLines = true;
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
            this.listOfProducts.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8});
            this.listOfProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listOfProducts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listOfProducts.Location = new System.Drawing.Point(313, 64);
            this.listOfProducts.MultiSelect = false;
            this.listOfProducts.Name = "listOfProducts";
            this.listOfProducts.Size = new System.Drawing.Size(676, 363);
            this.listOfProducts.TabIndex = 5;
            this.listOfProducts.UseCompatibleStateImageBehavior = false;
            this.listOfProducts.View = System.Windows.Forms.View.Details;
            // 
            // Type
            // 
            this.Type.Text = "Тип";
            this.Type.Width = 200;
            // 
            // Manufacturer
            // 
            this.Manufacturer.Text = "Производитель";
            this.Manufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Manufacturer.Width = 122;
            // 
            // Model
            // 
            this.Model.Text = "Модель";
            this.Model.Width = 200;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            // 
            // Rating
            // 
            this.Rating.Text = "Рейтинг";
            this.Rating.Width = 67;
            // 
            // userNameText
            // 
            this.userNameText.AutoSize = true;
            this.userNameText.Location = new System.Drawing.Point(154, 87);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(51, 20);
            this.userNameText.TabIndex = 6;
            this.userNameText.Text = "Войти";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Корзина";
            // 
            // cpusLabel
            // 
            this.cpusLabel.AutoSize = true;
            this.cpusLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpusLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpusLabel.Location = new System.Drawing.Point(60, 148);
            this.cpusLabel.Name = "cpusLabel";
            this.cpusLabel.Size = new System.Drawing.Size(114, 23);
            this.cpusLabel.TabIndex = 9;
            this.cpusLabel.Text = "Процессоры ";
            this.cpusLabel.Click += new System.EventHandler(this.cpusLabel_Click);
            this.cpusLabel.MouseEnter += new System.EventHandler(this.cpusLabel_MouseEnter);
            this.cpusLabel.MouseLeave += new System.EventHandler(this.cpusLabel_MouseLeave);
            // 
            // motherboardsLabel
            // 
            this.motherboardsLabel.AutoSize = true;
            this.motherboardsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.motherboardsLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motherboardsLabel.Location = new System.Drawing.Point(60, 181);
            this.motherboardsLabel.Name = "motherboardsLabel";
            this.motherboardsLabel.Size = new System.Drawing.Size(167, 23);
            this.motherboardsLabel.TabIndex = 10;
            this.motherboardsLabel.Text = "Материнские платы";
            this.motherboardsLabel.Click += new System.EventHandler(this.motherboardsLabel_Click);
            this.motherboardsLabel.MouseEnter += new System.EventHandler(this.motherboardsLabel_MouseEnter);
            this.motherboardsLabel.MouseLeave += new System.EventHandler(this.motherboardsLabel_MouseLeave);
            // 
            // gpusLabel
            // 
            this.gpusLabel.AutoSize = true;
            this.gpusLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpusLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpusLabel.Location = new System.Drawing.Point(60, 219);
            this.gpusLabel.Name = "gpusLabel";
            this.gpusLabel.Size = new System.Drawing.Size(104, 23);
            this.gpusLabel.TabIndex = 11;
            this.gpusLabel.Text = "Видеокарты";
            this.gpusLabel.Click += new System.EventHandler(this.gpusLabel_Click);
            this.gpusLabel.MouseEnter += new System.EventHandler(this.gpusLabel_MouseEnter);
            this.gpusLabel.MouseLeave += new System.EventHandler(this.gpusLabel_MouseLeave);
            // 
            // ramLabel
            // 
            this.ramLabel.AutoSize = true;
            this.ramLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ramLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramLabel.Location = new System.Drawing.Point(60, 294);
            this.ramLabel.Name = "ramLabel";
            this.ramLabel.Size = new System.Drawing.Size(176, 23);
            this.ramLabel.TabIndex = 12;
            this.ramLabel.Text = "Оперативная память";
            this.ramLabel.Click += new System.EventHandler(this.ramLabel_Click);
            this.ramLabel.MouseEnter += new System.EventHandler(this.ramLabel_MouseEnter);
            this.ramLabel.MouseLeave += new System.EventHandler(this.ramLabel_MouseLeave);
            // 
            // casesLabel
            // 
            this.casesLabel.AutoSize = true;
            this.casesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.casesLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.casesLabel.Location = new System.Drawing.Point(60, 256);
            this.casesLabel.Name = "casesLabel";
            this.casesLabel.Size = new System.Drawing.Size(75, 23);
            this.casesLabel.TabIndex = 13;
            this.casesLabel.Text = "Корпуса";
            this.casesLabel.Click += new System.EventHandler(this.casesLabel_Click);
            this.casesLabel.MouseEnter += new System.EventHandler(this.casesLabel_MouseEnter);
            this.casesLabel.MouseLeave += new System.EventHandler(this.casesLabel_MouseLeave);
            // 
            // powerSuppliesLabel
            // 
            this.powerSuppliesLabel.AutoSize = true;
            this.powerSuppliesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.powerSuppliesLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.powerSuppliesLabel.Location = new System.Drawing.Point(60, 331);
            this.powerSuppliesLabel.Name = "powerSuppliesLabel";
            this.powerSuppliesLabel.Size = new System.Drawing.Size(127, 23);
            this.powerSuppliesLabel.TabIndex = 14;
            this.powerSuppliesLabel.Text = "Блоки питания";
            this.powerSuppliesLabel.Click += new System.EventHandler(this.powerSuppliesLabel_Click);
            this.powerSuppliesLabel.MouseEnter += new System.EventHandler(this.powerSuppliesLabel_MouseEnter);
            this.powerSuppliesLabel.MouseLeave += new System.EventHandler(this.powerSuppliesLabel_MouseLeave);
            // 
            // coolingSystemsLabel
            // 
            this.coolingSystemsLabel.AutoSize = true;
            this.coolingSystemsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coolingSystemsLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coolingSystemsLabel.Location = new System.Drawing.Point(60, 368);
            this.coolingSystemsLabel.Name = "coolingSystemsLabel";
            this.coolingSystemsLabel.Size = new System.Drawing.Size(212, 23);
            this.coolingSystemsLabel.TabIndex = 15;
            this.coolingSystemsLabel.Text = "Охлаждение компьютера";
            this.coolingSystemsLabel.Click += new System.EventHandler(this.coolingSystemsLabel_Click);
            this.coolingSystemsLabel.MouseEnter += new System.EventHandler(this.coolingSystemsLabel_MouseEnter);
            this.coolingSystemsLabel.MouseLeave += new System.EventHandler(this.coolingSystemsLabel_MouseLeave);
            // 
            // hddsLabel
            // 
            this.hddsLabel.AutoSize = true;
            this.hddsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hddsLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hddsLabel.Location = new System.Drawing.Point(61, 405);
            this.hddsLabel.Name = "hddsLabel";
            this.hddsLabel.Size = new System.Drawing.Size(126, 23);
            this.hddsLabel.TabIndex = 16;
            this.hddsLabel.Text = "Жесткие диски";
            this.hddsLabel.Click += new System.EventHandler(this.hddsLabel_Click);
            this.hddsLabel.MouseEnter += new System.EventHandler(this.hddsLabel_MouseEnter);
            this.hddsLabel.MouseLeave += new System.EventHandler(this.hddsLabel_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(25, 365);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(25, 401);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(25, 329);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(24, 219);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(25, 256);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(24, 293);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 30);
            this.pictureBox8.TabIndex = 24;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(24, 181);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 30);
            this.pictureBox9.TabIndex = 25;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(10, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // inputText
            // 
            this.inputText.BackColor = System.Drawing.Color.Linen;
            this.inputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputText.Location = new System.Drawing.Point(388, 28);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(518, 20);
            this.inputText.TabIndex = 27;
            this.inputText.Text = "Поиск продукта";
            this.inputText.Enter += new System.EventHandler(this.inputText_Enter);
            this.inputText.Leave += new System.EventHandler(this.inputText_Leave);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(380, 20);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(562, 38);
            this.pictureBox10.TabIndex = 28;
            this.pictureBox10.TabStop = false;
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.SeaShell;
            this.findButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("findButton.BackgroundImage")));
            this.findButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.findButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findButton.FlatAppearance.BorderSize = 0;
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findButton.Location = new System.Drawing.Point(912, 25);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(25, 25);
            this.findButton.TabIndex = 29;
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // signOutButton
            // 
            this.signOutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signOutButton.BackgroundImage")));
            this.signOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signOutButton.Enabled = false;
            this.signOutButton.FlatAppearance.BorderSize = 0;
            this.signOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOutButton.Location = new System.Drawing.Point(155, 33);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(50, 50);
            this.signOutButton.TabIndex = 30;
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Visible = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1002, 496);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hddsLabel);
            this.Controls.Add(this.coolingSystemsLabel);
            this.Controls.Add(this.powerSuppliesLabel);
            this.Controls.Add(this.casesLabel);
            this.Controls.Add(this.ramLabel);
            this.Controls.Add(this.gpusLabel);
            this.Controls.Add(this.motherboardsLabel);
            this.Controls.Add(this.cpusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.listOfProducts);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.signOutButton);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShopForm";
            this.Text = "WorldTech";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button userButton;
        private Button cartButton;
        private Button refreshButton;
        private Button addToCartButton;
        private ListView listOfProducts;
        private Label label2;
        private Label cpusLabel;
        private Label motherboardsLabel;
        private Label gpusLabel;
        private Label ramLabel;
        private Label casesLabel;
        private Label powerSuppliesLabel;
        private Label coolingSystemsLabel;
        private Label hddsLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private ColumnHeader Type;
        private ColumnHeader Manufacturer;
        private ColumnHeader Model;
        private ColumnHeader Price;
        private ColumnHeader Rating;
        private PictureBox pictureBox2;
        private RichTextBox inputText;
        private PictureBox pictureBox10;
        private Button findButton;
        public Label userNameText;
        private Button signOutButton;
    }
}