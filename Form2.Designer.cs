namespace Project_Pizza
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Order_Now = new System.Windows.Forms.Label();
            this.label2_UboutUs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 55);
            this.label1.TabIndex = 0;
            // 
            // Order_Now
            // 
            this.Order_Now.AutoSize = true;
            this.Order_Now.BackColor = System.Drawing.Color.Transparent;
            this.Order_Now.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_Now.Location = new System.Drawing.Point(105, 567);
            this.Order_Now.Name = "Order_Now";
            this.Order_Now.Size = new System.Drawing.Size(167, 25);
            this.Order_Now.TabIndex = 1;
            this.Order_Now.Text = "ORDER NOW !";
            this.Order_Now.Click += new System.EventHandler(this.Order_Now_Click);
            // 
            // label2_UboutUs
            // 
            this.label2_UboutUs.AutoSize = true;
            this.label2_UboutUs.BackColor = System.Drawing.Color.Transparent;
            this.label2_UboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_UboutUs.ForeColor = System.Drawing.Color.Black;
            this.label2_UboutUs.Location = new System.Drawing.Point(905, 567);
            this.label2_UboutUs.Name = "label2_UboutUs";
            this.label2_UboutUs.Size = new System.Drawing.Size(127, 25);
            this.label2_UboutUs.TabIndex = 2;
            this.label2_UboutUs.Text = "ABOUT US";
            this.label2_UboutUs.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Pizza.Properties.Resources.photo_2026_06_26_11_48_38;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 646);
            this.Controls.Add(this.label2_UboutUs);
            this.Controls.Add(this.Order_Now);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Order_Now;
        private System.Windows.Forms.Label label2_UboutUs;
    }
}