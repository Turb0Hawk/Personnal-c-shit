namespace LegendOfTheFiveRingsCounter
{
    partial class Counter
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
            this.lblStrife = new System.Windows.Forms.Label();
            this.txtStrife = new System.Windows.Forms.TextBox();
            this.lblTrongerd = new System.Windows.Forms.Label();
            this.btnPlusStrife = new System.Windows.Forms.Button();
            this.btnRemStrife = new System.Windows.Forms.Button();
            this.txtMaxStrife = new System.Windows.Forms.TextBox();
            this.lblMaxStrife = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStrife
            // 
            this.lblStrife.AutoSize = true;
            this.lblStrife.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrife.Location = new System.Drawing.Point(48, 68);
            this.lblStrife.Name = "lblStrife";
            this.lblStrife.Size = new System.Drawing.Size(55, 20);
            this.lblStrife.TabIndex = 0;
            this.lblStrife.Text = "Strife :";
            // 
            // txtStrife
            // 
            this.txtStrife.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStrife.Location = new System.Drawing.Point(110, 68);
            this.txtStrife.Name = "txtStrife";
            this.txtStrife.ReadOnly = true;
            this.txtStrife.Size = new System.Drawing.Size(51, 26);
            this.txtStrife.TabIndex = 1;
            // 
            // lblTrongerd
            // 
            this.lblTrongerd.AutoSize = true;
            this.lblTrongerd.Enabled = false;
            this.lblTrongerd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrongerd.ForeColor = System.Drawing.Color.Red;
            this.lblTrongerd.Location = new System.Drawing.Point(83, 118);
            this.lblTrongerd.Name = "lblTrongerd";
            this.lblTrongerd.Size = new System.Drawing.Size(127, 25);
            this.lblTrongerd.TabIndex = 2;
            this.lblTrongerd.Text = "Trongered!!!!";
            // 
            // btnPlusStrife
            // 
            this.btnPlusStrife.Location = new System.Drawing.Point(292, 68);
            this.btnPlusStrife.Name = "btnPlusStrife";
            this.btnPlusStrife.Size = new System.Drawing.Size(75, 23);
            this.btnPlusStrife.TabIndex = 3;
            this.btnPlusStrife.Text = "Add strife";
            this.btnPlusStrife.UseVisualStyleBackColor = true;
            this.btnPlusStrife.Click += new System.EventHandler(this.btnPlusStrife_Click);
            // 
            // btnRemStrife
            // 
            this.btnRemStrife.Location = new System.Drawing.Point(292, 118);
            this.btnRemStrife.Name = "btnRemStrife";
            this.btnRemStrife.Size = new System.Drawing.Size(75, 23);
            this.btnRemStrife.TabIndex = 4;
            this.btnRemStrife.Text = "Remove strife";
            this.btnRemStrife.UseVisualStyleBackColor = true;
            this.btnRemStrife.Click += new System.EventHandler(this.btnRemStrife_Click);
            // 
            // txtMaxStrife
            // 
            this.txtMaxStrife.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxStrife.Location = new System.Drawing.Point(139, 6);
            this.txtMaxStrife.Name = "txtMaxStrife";
            this.txtMaxStrife.Size = new System.Drawing.Size(48, 26);
            this.txtMaxStrife.TabIndex = 6;
            // 
            // lblMaxStrife
            // 
            this.lblMaxStrife.AutoSize = true;
            this.lblMaxStrife.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxStrife.Location = new System.Drawing.Point(48, 9);
            this.lblMaxStrife.Name = "lblMaxStrife";
            this.lblMaxStrife.Size = new System.Drawing.Size(85, 20);
            this.lblMaxStrife.TabIndex = 5;
            this.lblMaxStrife.Text = "Max strife :";
            // 
            // Counter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 205);
            this.Controls.Add(this.txtMaxStrife);
            this.Controls.Add(this.lblMaxStrife);
            this.Controls.Add(this.btnRemStrife);
            this.Controls.Add(this.btnPlusStrife);
            this.Controls.Add(this.lblTrongerd);
            this.Controls.Add(this.txtStrife);
            this.Controls.Add(this.lblStrife);
            this.Name = "Counter";
            this.Text = "Shit counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStrife;
        private System.Windows.Forms.TextBox txtStrife;
        private System.Windows.Forms.Label lblTrongerd;
        private System.Windows.Forms.Button btnPlusStrife;
        private System.Windows.Forms.Button btnRemStrife;
        private System.Windows.Forms.TextBox txtMaxStrife;
        private System.Windows.Forms.Label lblMaxStrife;
    }
}

