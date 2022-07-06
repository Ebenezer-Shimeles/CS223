namespace LE
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
            this.ammountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ammountText = new System.Windows.Forms.TextBox();
            this.vatText = new System.Windows.Forms.MaskedTextBox();
            this.totalText = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // ammountLabel
            // 
            this.ammountLabel.AutoSize = true;
            this.ammountLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ammountLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ammountLabel.Location = new System.Drawing.Point(91, 94);
            this.ammountLabel.Name = "ammountLabel";
            this.ammountLabel.Size = new System.Drawing.Size(63, 16);
            this.ammountLabel.TabIndex = 0;
            this.ammountLabel.Text = "Ammount";
            this.ammountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total";
            // 
            // ammountText
            // 
            this.ammountText.Location = new System.Drawing.Point(243, 87);
            this.ammountText.Name = "ammountText";
            this.ammountText.Size = new System.Drawing.Size(361, 22);
            this.ammountText.TabIndex = 3;
            this.ammountText.TextChanged += new System.EventHandler(this.ammountText_TextChanged);
            this.ammountText.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // vatText
            // 
            this.vatText.Location = new System.Drawing.Point(243, 161);
            this.vatText.Name = "vatText";
            this.vatText.Size = new System.Drawing.Size(361, 22);
            this.vatText.TabIndex = 4;
            // 
            // totalText
            // 
            this.totalText.Location = new System.Drawing.Point(243, 230);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(361, 22);
            this.totalText.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.vatText);
            this.Controls.Add(this.ammountText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ammountLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ammountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ammountText;
        private System.Windows.Forms.MaskedTextBox vatText;
        private System.Windows.Forms.MaskedTextBox totalText;
    }
}

