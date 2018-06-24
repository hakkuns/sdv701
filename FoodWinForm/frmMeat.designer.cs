namespace FoodWinForm
{
    partial class frmMeat
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(162, 211);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(157, 25);
            this.txtAmount.TabIndex = 4;
            // 
            // labelAmount
            // 
            this.labelAmount.Location = new System.Drawing.Point(15, 215);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(93, 22);
            this.labelAmount.TabIndex = 54;
            this.labelAmount.Text = "Amount";
            // 
            // frmMeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(587, 325);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.labelAmount);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "frmMeat";
            this.Text = "Meat";
            this.Controls.SetChildIndex(this.labelAmount, 0);
            this.Controls.SetChildIndex(this.txtAmount, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txtAmount;
        internal System.Windows.Forms.Label labelAmount;
    }
}
