namespace FoodWinForm
{
    partial class frmMain
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstPlaces = new System.Windows.Forms.ListBox();
            this.btnShoworder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(376, 363);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(133, 44);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(198, 363);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 44);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_ClickAsync);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 363);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 44);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstPlaces
            // 
            this.lstPlaces.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lstPlaces.ItemHeight = 33;
            this.lstPlaces.Location = new System.Drawing.Point(28, 40);
            this.lstPlaces.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstPlaces.Name = "lstPlaces";
            this.lstPlaces.Size = new System.Drawing.Size(481, 268);
            this.lstPlaces.TabIndex = 7;
            this.lstPlaces.DoubleClick += new System.EventHandler(this.lstPlaces_DoubleClick);
            // 
            // btnShoworder
            // 
            this.btnShoworder.Location = new System.Drawing.Point(132, 433);
            this.btnShoworder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnShoworder.Name = "btnShoworder";
            this.btnShoworder.Size = new System.Drawing.Size(261, 44);
            this.btnShoworder.TabIndex = 12;
            this.btnShoworder.Text = "Show Order";
            this.btnShoworder.Click += new System.EventHandler(this.btnShowOrder_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(540, 500);
            this.Controls.Add(this.btnShoworder);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstPlaces);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button btnQuit;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.ListBox lstPlaces;
        internal System.Windows.Forms.Button btnShoworder;
    }
}

