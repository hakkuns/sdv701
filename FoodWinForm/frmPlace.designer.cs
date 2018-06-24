namespace FoodWinForm
{
    partial class frmPlace
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
            this.optSort = new System.Windows.Forms.GroupBox();
            this.rbByDate = new System.Windows.Forms.RadioButton();
            this.rbByName = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelProducts = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.txtPlaceName = new System.Windows.Forms.TextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Button();
            this.optSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // optSort
            // 
            this.optSort.Controls.Add(this.rbByDate);
            this.optSort.Controls.Add(this.rbByName);
            this.optSort.Location = new System.Drawing.Point(340, 138);
            this.optSort.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.optSort.Name = "optSort";
            this.optSort.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.optSort.Size = new System.Drawing.Size(227, 66);
            this.optSort.TabIndex = 25;
            this.optSort.TabStop = false;
            this.optSort.Text = "Sort By";
            // 
            // rbByDate
            // 
            this.rbByDate.Location = new System.Drawing.Point(133, 22);
            this.rbByDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbByDate.Name = "rbByDate";
            this.rbByDate.Size = new System.Drawing.Size(80, 33);
            this.rbByDate.TabIndex = 1;
            this.rbByDate.Text = "Date";
            this.rbByDate.CheckedChanged += new System.EventHandler(this.rbByDate_CheckedChanged);
            // 
            // rbByName
            // 
            this.rbByName.Location = new System.Drawing.Point(10, 22);
            this.rbByName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbByName.Name = "rbByName";
            this.rbByName.Size = new System.Drawing.Size(93, 33);
            this.rbByName.TabIndex = 0;
            this.rbByName.Text = "Name";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(415, 409);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(152, 44);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_ClickAsync);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(218, 409);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 44);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_ClickAsync);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 409);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 44);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_ClickAsync);
            // 
            // labelProducts
            // 
            this.labelProducts.Location = new System.Drawing.Point(18, 185);
            this.labelProducts.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(133, 22);
            this.labelProducts.TabIndex = 21;
            this.labelProducts.Text = "Products";
            // 
            // lstProducts
            // 
            this.lstProducts.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lstProducts.ItemHeight = 24;
            this.lstProducts.Location = new System.Drawing.Point(21, 212);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(546, 148);
            this.lstProducts.TabIndex = 20;
            this.lstProducts.DoubleClick += new System.EventHandler(this.lstProducts_DoubleClick);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(167, 69);
            this.txtCode.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(400, 25);
            this.txtCode.TabIndex = 17;
            // 
            // labelCode
            // 
            this.labelCode.Location = new System.Drawing.Point(18, 69);
            this.labelCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(107, 22);
            this.labelCode.TabIndex = 16;
            this.labelCode.Text = "Post Code";
            // 
            // txtPlaceName
            // 
            this.txtPlaceName.Location = new System.Drawing.Point(167, 23);
            this.txtPlaceName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPlaceName.Name = "txtPlaceName";
            this.txtPlaceName.Size = new System.Drawing.Size(400, 25);
            this.txtPlaceName.TabIndex = 15;
            // 
            // labelPlace
            // 
            this.labelPlace.Location = new System.Drawing.Point(18, 23);
            this.labelPlace.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(107, 22);
            this.labelPlace.TabIndex = 14;
            this.labelPlace.Text = "Place Name";
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(439, 372);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(91, 25);
            this.order.TabIndex = 26;
            this.order.Text = "order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_ClickAsync);
            // 
            // frmPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(594, 477);
            this.ControlBox = false;
            this.Controls.Add(this.order);
            this.Controls.Add(this.optSort);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.txtPlaceName);
            this.Controls.Add(this.labelPlace);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmPlace";
            this.Text = "Place Details";
            this.optSort.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.GroupBox optSort;
        internal System.Windows.Forms.RadioButton rbByDate;
        internal System.Windows.Forms.RadioButton rbByName;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Label labelProducts;
        internal System.Windows.Forms.ListBox lstProducts;
        internal System.Windows.Forms.TextBox txtCode;
        internal System.Windows.Forms.Label labelCode;
        internal System.Windows.Forms.TextBox txtPlaceName;
        internal System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button order;
    }
}