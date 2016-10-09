namespace Management.Controls
{
    partial class StockOutControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStockOut = new System.Windows.Forms.Button();
            this.btnStockOutDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStockOut
            // 
            this.btnStockOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockOut.Location = new System.Drawing.Point(248, 215);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(156, 105);
            this.btnStockOut.TabIndex = 1;
            this.btnStockOut.Text = "产品出库";
            this.btnStockOut.UseVisualStyleBackColor = true;
            this.btnStockOut.Click += new System.EventHandler(this.btnStockOut_Click);
            // 
            // btnStockOutDetails
            // 
            this.btnStockOutDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockOutDetails.Location = new System.Drawing.Point(559, 215);
            this.btnStockOutDetails.Name = "btnStockOutDetails";
            this.btnStockOutDetails.Size = new System.Drawing.Size(156, 105);
            this.btnStockOutDetails.TabIndex = 2;
            this.btnStockOutDetails.Text = "出库记录";
            this.btnStockOutDetails.UseVisualStyleBackColor = true;
            this.btnStockOutDetails.Click += new System.EventHandler(this.btnStockOutDetails_Click);
            // 
            // StockOutControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStockOutDetails);
            this.Controls.Add(this.btnStockOut);
            this.Name = "StockOutControls";
            this.Size = new System.Drawing.Size(946, 587);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStockOut;
        private System.Windows.Forms.Button btnStockOutDetails;
    }
}
