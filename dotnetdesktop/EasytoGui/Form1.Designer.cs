
namespace EasytoGui
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
            this.btn_clickme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_clickme
            // 
            this.btn_clickme.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_clickme.FlatAppearance.BorderSize = 0;
            this.btn_clickme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clickme.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clickme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clickme.Location = new System.Drawing.Point(12, 93);
            this.btn_clickme.Name = "btn_clickme";
            this.btn_clickme.Size = new System.Drawing.Size(286, 56);
            this.btn_clickme.TabIndex = 0;
            this.btn_clickme.Text = "Click Me";
            this.btn_clickme.UseVisualStyleBackColor = false;
            this.btn_clickme.Click += new System.EventHandler(this.btn_clickme_Click);
            this.btn_clickme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_clickme_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(310, 256);
            this.Controls.Add(this.btn_clickme);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello guys";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clickme;
    }
}

