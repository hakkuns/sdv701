namespace FoodWinForm
{
    partial class frmVegetable
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
            this.txtFreshness = new System.Windows.Forms.TextBox();
            this.labelFreshness = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFreshness
            // 
            this.txtFreshness.Location = new System.Drawing.Point(162, 204);
            this.txtFreshness.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFreshness.Name = "txtFreshness";
            this.txtFreshness.Size = new System.Drawing.Size(157, 25);
            this.txtFreshness.TabIndex = 4;
            // 
            // labelFreshness
            // 
            this.labelFreshness.Location = new System.Drawing.Point(15, 208);
            this.labelFreshness.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFreshness.Name = "labelFreshness";
            this.labelFreshness.Size = new System.Drawing.Size(93, 32);
            this.labelFreshness.TabIndex = 52;
            this.labelFreshness.Text = "Freshness";
            // 
            // frmVegetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(605, 372);
            this.Controls.Add(this.txtFreshness);
            this.Controls.Add(this.labelFreshness);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "frmVegetable";
            this.Text = "Vegetable";
            this.Controls.SetChildIndex(this.labelFreshness, 0);
            this.Controls.SetChildIndex(this.txtFreshness, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txtFreshness;
        internal System.Windows.Forms.Label labelFreshness;
    }
}
