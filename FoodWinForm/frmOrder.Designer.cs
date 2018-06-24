namespace FoodWinForm
{
    partial class frmOrder
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
            this.labelOrder = new System.Windows.Forms.Label();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOrder
            // 
            this.labelOrder.Location = new System.Drawing.Point(36, 44);
            this.labelOrder.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(133, 22);
            this.labelOrder.TabIndex = 23;
            this.labelOrder.Text = "Order";
            // 
            // lstOrder
            // 
            this.lstOrder.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lstOrder.ItemHeight = 24;
            this.lstOrder.Location = new System.Drawing.Point(39, 119);
            this.lstOrder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(1032, 196);
            this.lstOrder.TabIndex = 22;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(39, 347);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 64);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.delete_ClickAsync);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(198, 347);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(130, 64);
            this.btnQuit.TabIndex = 25;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.quit_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(574, 347);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(130, 64);
            this.btnTotal.TabIndex = 26;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.total_ClickAsync);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPrice.Location = new System.Drawing.Point(734, 372);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(184, 39);
            this.txtPrice.TabIndex = 27;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(36, 97);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(24, 18);
            this.labelID.TabIndex = 28;
            this.labelID.Text = "ID";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(159, 97);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(67, 18);
            this.labelProduct.TabIndex = 29;
            this.labelProduct.Text = "Product";
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(279, 97);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(50, 18);
            this.labelPlace.TabIndex = 30;
            this.labelPlace.Text = "Place";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(396, 97);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(47, 18);
            this.labelPrice.TabIndex = 31;
            this.labelPrice.Text = "Price";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(517, 97);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(73, 18);
            this.labelQuantity.TabIndex = 32;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(636, 97);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(101, 18);
            this.labelCustomerID.TabIndex = 33;
            this.labelCustomerID.Text = "Customer ID";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(758, 97);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(44, 18);
            this.labelDate.TabIndex = 34;
            this.labelDate.Text = "Date";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1099, 450);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelCustomerID);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.lstOrder);
            this.Name = "frmOrder";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label labelOrder;
        internal System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Label labelDate;
    }
}