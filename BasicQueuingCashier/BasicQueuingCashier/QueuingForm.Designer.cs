
namespace BasicQueuingCashier
{
    partial class QueuingForm
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
            this.btnCahier = new System.Windows.Forms.Button();
            this.lblQueue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCTGnum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCahier
            // 
            this.btnCahier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCahier.Location = new System.Drawing.Point(37, 61);
            this.btnCahier.Name = "btnCahier";
            this.btnCahier.Size = new System.Drawing.Size(144, 107);
            this.btnCahier.TabIndex = 0;
            this.btnCahier.Text = "Cashier";
            this.btnCahier.UseVisualStyleBackColor = true;
            this.btnCahier.Click += new System.EventHandler(this.btnCahier_Click);
            // 
            // lblQueue
            // 
            this.lblQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueue.Location = new System.Drawing.Point(243, 74);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(295, 107);
            this.lblQueue.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Position in Queue";
            // 
            // lblCTGnum
            // 
            this.lblCTGnum.AutoSize = true;
            this.lblCTGnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTGnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCTGnum.Location = new System.Drawing.Point(50, 187);
            this.lblCTGnum.Name = "lblCTGnum";
            this.lblCTGnum.Size = new System.Drawing.Size(119, 15);
            this.lblCTGnum.TabIndex = 4;
            this.lblCTGnum.Text = "*Click to get Number";
            this.lblCTGnum.Click += new System.EventHandler(this.lblCTGnum_Click);
            // 
            // QueuingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 268);
            this.Controls.Add(this.lblCTGnum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.btnCahier);
            this.Name = "QueuingForm";
            this.Text = "QueuingForm";
            this.Load += new System.EventHandler(this.QueuingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCahier;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCTGnum;
    }
}