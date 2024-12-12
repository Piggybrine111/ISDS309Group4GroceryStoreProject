namespace ISDS309Group4GroceryStoreProject
{
    partial class Tab_Home
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
            tabMeat = new Button();
            shopingCart = new Button();
            tabProduce = new Button();
            tabDairy = new Button();
            tabDrinks = new Button();
            tabSnacks = new Button();
            tabBakery = new Button();
            SuspendLayout();
            // 
            // tabMeat
            // 
            tabMeat.AutoSize = true;
            tabMeat.Location = new Point(60, 119);
            tabMeat.Name = "tabMeat";
            tabMeat.Size = new Size(125, 25);
            tabMeat.TabIndex = 0;
            tabMeat.Text = "Meat";
            tabMeat.UseVisualStyleBackColor = true;
            tabMeat.Click += tabMeat_Click;
            // 
            // shopingCart
            // 
            shopingCart.Location = new Point(999, 12);
            shopingCart.Name = "shopingCart";
            shopingCart.Size = new Size(107, 69);
            shopingCart.TabIndex = 1;
            shopingCart.Text = "Shoping Cart";
            shopingCart.UseVisualStyleBackColor = true;
            // 
            // tabProduce
            // 
            tabProduce.AutoSize = true;
            tabProduce.Location = new Point(251, 119);
            tabProduce.Name = "tabProduce";
            tabProduce.Size = new Size(125, 25);
            tabProduce.TabIndex = 2;
            tabProduce.Text = "Produce";
            tabProduce.UseVisualStyleBackColor = true;
            tabProduce.Click += tabProduce_Click;
            // 
            // tabDairy
            // 
            tabDairy.AutoSize = true;
            tabDairy.Location = new Point(442, 119);
            tabDairy.Name = "tabDairy";
            tabDairy.Size = new Size(125, 25);
            tabDairy.TabIndex = 3;
            tabDairy.Text = "Dairy";
            tabDairy.UseVisualStyleBackColor = true;
            tabDairy.Click += tabDairy_Click;
            // 
            // tabDrinks
            // 
            tabDrinks.AutoSize = true;
            tabDrinks.Location = new Point(1015, 119);
            tabDrinks.Name = "tabDrinks";
            tabDrinks.Size = new Size(125, 25);
            tabDrinks.TabIndex = 6;
            tabDrinks.Text = "Drinks";
            tabDrinks.UseVisualStyleBackColor = true;
            tabDrinks.Click += tabDrinks_Click;
            // 
            // tabSnacks
            // 
            tabSnacks.AutoSize = true;
            tabSnacks.Location = new Point(824, 119);
            tabSnacks.Name = "tabSnacks";
            tabSnacks.Size = new Size(125, 25);
            tabSnacks.TabIndex = 5;
            tabSnacks.Text = "Snaks and Candy";
            tabSnacks.UseVisualStyleBackColor = true;
            tabSnacks.Click += tabSnacks_Click;
            // 
            // tabBakery
            // 
            tabBakery.AutoSize = true;
            tabBakery.Location = new Point(633, 119);
            tabBakery.Name = "tabBakery";
            tabBakery.Size = new Size(125, 25);
            tabBakery.TabIndex = 4;
            tabBakery.Text = "Bakery";
            tabBakery.UseVisualStyleBackColor = true;
            tabBakery.Click += tabBakery_Click;
            // 
            // Tab_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.homepage;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1210, 676);
            Controls.Add(tabDrinks);
            Controls.Add(tabSnacks);
            Controls.Add(tabBakery);
            Controls.Add(tabDairy);
            Controls.Add(tabProduce);
            Controls.Add(shopingCart);
            Controls.Add(tabMeat);
            DoubleBuffered = true;
            Name = "Tab_Home";
            Text = "Tab_Home";
            FormClosed += Tab_Home_FormClosed;
            Load += Tab_Home_Load;
            Resize += Tab_Home_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tabMeat;
        private Button shopingCart;
        private Button tabProduce;
        private Button tabDairy;
        private Button tabDrinks;
        private Button tabSnacks;
        private Button tabBakery;
    }
}