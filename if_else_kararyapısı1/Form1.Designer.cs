namespace if_else_kararyapısı1
{
    partial class Form1
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
            this.cbMavi = new System.Windows.Forms.CheckBox();
            this.lblYaz = new System.Windows.Forms.Label();
            this.btnRenk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbMavi
            // 
            this.cbMavi.AutoSize = true;
            this.cbMavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMavi.ForeColor = System.Drawing.Color.Gray;
            this.cbMavi.Location = new System.Drawing.Point(24, 124);
            this.cbMavi.Name = "cbMavi";
            this.cbMavi.Size = new System.Drawing.Size(145, 35);
            this.cbMavi.TabIndex = 1;
            this.cbMavi.Text = "Mavi Yap";
            this.cbMavi.UseVisualStyleBackColor = true;
            // 
            // lblYaz
            // 
            this.lblYaz.AutoSize = true;
            this.lblYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYaz.ForeColor = System.Drawing.Color.Gray;
            this.lblYaz.Location = new System.Drawing.Point(21, 179);
            this.lblYaz.Name = "lblYaz";
            this.lblYaz.Size = new System.Drawing.Size(34, 24);
            this.lblYaz.TabIndex = 2;
            this.lblYaz.Text = "***";
            // 
            // btnRenk
            // 
            this.btnRenk.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRenk.Location = new System.Drawing.Point(24, 64);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(162, 36);
            this.btnRenk.TabIndex = 3;
            this.btnRenk.Text = "Renk";
            this.btnRenk.UseVisualStyleBackColor = false;
            this.btnRenk.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 282);
            this.Controls.Add(this.btnRenk);
            this.Controls.Add(this.lblYaz);
            this.Controls.Add(this.cbMavi);
            this.Name = "Form1";
            this.Text = "Form Back Color";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbMavi;
        private System.Windows.Forms.Label lblYaz;
        private System.Windows.Forms.Button btnRenk;
    }
}

