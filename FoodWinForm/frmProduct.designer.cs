namespace FoodWinForm
{
    partial class frmProduct
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
            this.txtValue = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.txtCreation = new System.Windows.Forms.TextBox();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.labelInstock = new System.Windows.Forms.Label();
            this.txtInstock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(162, 112);
            this.txtValue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(157, 25);
            this.txtValue.TabIndex = 3;
            // 
            // labelPrice
            // 
            this.labelPrice.Location = new System.Drawing.Point(15, 116);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(133, 22);
            this.labelPrice.TabIndex = 46;
            this.labelPrice.Text = "Price  $";
            // 
            // txtCreation
            // 
            this.txtCreation.Location = new System.Drawing.Point(162, 68);
            this.txtCreation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCreation.Name = "txtCreation";
            this.txtCreation.Size = new System.Drawing.Size(157, 25);
            this.txtCreation.TabIndex = 2;
            // 
            // labelUpdate
            // 
            this.labelUpdate.Location = new System.Drawing.Point(15, 72);
            this.labelUpdate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(133, 22);
            this.labelUpdate.TabIndex = 44;
            this.labelUpdate.Text = "Update Date";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(162, 24);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 25);
            this.txtName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(15, 28);
            this.labelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(133, 22);
            this.labelName.TabIndex = 40;
            this.labelName.Text = "Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(375, 61);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(173, 32);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(375, 17);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(173, 32);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_ClickAsync);
            // 
            // labelInstock
            // 
            this.labelInstock.Location = new System.Drawing.Point(15, 158);
            this.labelInstock.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelInstock.Name = "labelInstock";
            this.labelInstock.Size = new System.Drawing.Size(133, 22);
            this.labelInstock.TabIndex = 47;
            this.labelInstock.Text = "Instock";
            // 
            // txtInstock
            // 
            this.txtInstock.Location = new System.Drawing.Point(162, 158);
            this.txtInstock.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtInstock.Name = "txtInstock";
            this.txtInstock.Size = new System.Drawing.Size(157, 25);
            this.txtInstock.TabIndex = 48;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(587, 339);
            this.Controls.Add(this.txtInstock);
            this.Controls.Add(this.labelInstock);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.txtCreation);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmProduct";
            this.Text = "Product Form";
            this.ResumeLayout(false);
            this.PerformLayout();
    }

        #endregion

        internal System.Windows.Forms.TextBox txtValue;
        internal System.Windows.Forms.Label labelPrice;
        internal System.Windows.Forms.TextBox txtCreation;
        internal System.Windows.Forms.Label labelUpdate;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label labelName;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Label labelInstock;
        internal System.Windows.Forms.TextBox txtInstock;
    }
}