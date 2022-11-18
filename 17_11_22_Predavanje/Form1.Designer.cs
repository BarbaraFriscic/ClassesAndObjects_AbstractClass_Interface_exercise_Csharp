namespace _17_11_22_Predavanje
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
            this.btnShow = new System.Windows.Forms.Button();
            this.lblShowReturn = new System.Windows.Forms.Label();
            this.lblShowReturn2 = new System.Windows.Forms.Label();
            this.btnShow2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(163, 71);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Prikaži";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblShowReturn
            // 
            this.lblShowReturn.AutoSize = true;
            this.lblShowReturn.Location = new System.Drawing.Point(80, 129);
            this.lblShowReturn.Name = "lblShowReturn";
            this.lblShowReturn.Size = new System.Drawing.Size(0, 13);
            this.lblShowReturn.TabIndex = 1;
            // 
            // lblShowReturn2
            // 
            this.lblShowReturn2.AutoSize = true;
            this.lblShowReturn2.Location = new System.Drawing.Point(369, 129);
            this.lblShowReturn2.Name = "lblShowReturn2";
            this.lblShowReturn2.Size = new System.Drawing.Size(0, 13);
            this.lblShowReturn2.TabIndex = 3;
            // 
            // btnShow2
            // 
            this.btnShow2.Location = new System.Drawing.Point(452, 71);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(75, 23);
            this.btnShow2.TabIndex = 2;
            this.btnShow2.Text = "Prikaži";
            this.btnShow2.UseVisualStyleBackColor = true;
            this.btnShow2.Click += new System.EventHandler(this.btnShow2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblShowReturn2);
            this.Controls.Add(this.btnShow2);
            this.Controls.Add(this.lblShowReturn);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblShowReturn;
        private System.Windows.Forms.Label lblShowReturn2;
        private System.Windows.Forms.Button btnShow2;
    }
}

