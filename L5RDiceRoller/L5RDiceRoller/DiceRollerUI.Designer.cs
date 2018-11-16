namespace L5RDiceRoller
{
    partial class DiceRollerUI
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
            this.txtResultat = new System.Windows.Forms.RichTextBox();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.lblD6 = new System.Windows.Forms.Label();
            this.lblD12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.grpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(12, 43);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(345, 241);
            this.txtResultat.TabIndex = 0;
            this.txtResultat.Text = "";
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.btnRoll);
            this.grpControls.Controls.Add(this.textBox2);
            this.grpControls.Controls.Add(this.textBox1);
            this.grpControls.Controls.Add(this.lblD12);
            this.grpControls.Controls.Add(this.lblD6);
            this.grpControls.Location = new System.Drawing.Point(363, 43);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(174, 157);
            this.grpControls.TabIndex = 1;
            this.grpControls.TabStop = false;
            // 
            // lblD6
            // 
            this.lblD6.AutoSize = true;
            this.lblD6.Location = new System.Drawing.Point(6, 31);
            this.lblD6.Name = "lblD6";
            this.lblD6.Size = new System.Drawing.Size(115, 13);
            this.lblD6.TabIndex = 0;
            this.lblD6.Text = "Nombre de dé de ring :";
            // 
            // lblD12
            // 
            this.lblD12.AutoSize = true;
            this.lblD12.Location = new System.Drawing.Point(6, 68);
            this.lblD12.Name = "lblD12";
            this.lblD12.Size = new System.Drawing.Size(115, 13);
            this.lblD12.TabIndex = 1;
            this.lblD12.Text = "Nombre de dé de skill :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(39, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(9, 113);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(92, 35);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "Rouler";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // DiceRollerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 302);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.txtResultat);
            this.Name = "DiceRollerUI";
            this.Text = "Form1";
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtResultat;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblD12;
        private System.Windows.Forms.Label lblD6;
    }
}

