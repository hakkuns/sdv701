namespace FoodWinForm
{
    partial class frmFruit
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
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.labelQuality = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQuality
            // 
            this.txtQuality.Location = new System.Drawing.Point(162, 210);
            this.txtQuality.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(157, 25);
            this.txtQuality.TabIndex = 4;
            // 
            // labelQuality
            // 
            this.labelQuality.Location = new System.Drawing.Point(15, 210);
            this.labelQuality.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelQuality.Name = "labelQuality";
            this.labelQuality.Size = new System.Drawing.Size(93, 32);
            this.labelQuality.TabIndex = 46;
            this.labelQuality.Text = "Quality";
            // 
            // frmFruit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(587, 361);
            this.Controls.Add(this.txtQuality);
            this.Controls.Add(this.labelQuality);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "frmFruit";
            this.Text = "Fruit";
            this.Controls.SetChildIndex(this.labelQuality, 0);
            this.Controls.SetChildIndex(this.txtQuality, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txtQuality;
        internal System.Windows.Forms.Label labelQuality;
    }
}
