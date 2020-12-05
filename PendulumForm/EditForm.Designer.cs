namespace PendulumForm
{
    partial class EditForm
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
            this.okBTN = new System.Windows.Forms.Button();
            this.lengthTB = new System.Windows.Forms.TextBox();
            this.albumTB = new System.Windows.Forms.TextBox();
            this.urlTB = new System.Windows.Forms.TextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okBTN
            // 
            this.okBTN.Location = new System.Drawing.Point(15, 146);
            this.okBTN.Name = "okBTN";
            this.okBTN.Size = new System.Drawing.Size(237, 23);
            this.okBTN.TabIndex = 0;
            this.okBTN.Text = "S Z E R K E S Z T";
            this.okBTN.UseVisualStyleBackColor = true;
            this.okBTN.Click += new System.EventHandler(this.okBTN_Click);
            // 
            // lengthTB
            // 
            this.lengthTB.Location = new System.Drawing.Point(94, 43);
            this.lengthTB.Name = "lengthTB";
            this.lengthTB.Size = new System.Drawing.Size(158, 20);
            this.lengthTB.TabIndex = 2;
            // 
            // albumTB
            // 
            this.albumTB.Location = new System.Drawing.Point(94, 69);
            this.albumTB.Name = "albumTB";
            this.albumTB.Size = new System.Drawing.Size(158, 20);
            this.albumTB.TabIndex = 3;
            // 
            // urlTB
            // 
            this.urlTB.Location = new System.Drawing.Point(94, 95);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(158, 20);
            this.urlTB.TabIndex = 4;
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(94, 16);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(158, 20);
            this.titleTB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Album ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "URL";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 184);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.urlTB);
            this.Controls.Add(this.albumTB);
            this.Controls.Add(this.lengthTB);
            this.Controls.Add(this.okBTN);
            this.Name = "EditForm";
            this.Text = "Szerkesztés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox lengthTB;
        public System.Windows.Forms.TextBox albumTB;
        public System.Windows.Forms.TextBox urlTB;
        public System.Windows.Forms.TextBox titleTB;
    }
}