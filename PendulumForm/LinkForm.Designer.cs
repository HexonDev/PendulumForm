namespace PendulumForm
{
    partial class LinkForm
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
            this.exitBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.urlTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okBTN
            // 
            this.okBTN.Location = new System.Drawing.Point(308, 68);
            this.okBTN.Name = "okBTN";
            this.okBTN.Size = new System.Drawing.Size(75, 23);
            this.okBTN.TabIndex = 0;
            this.okBTN.Text = "Ok";
            this.okBTN.UseVisualStyleBackColor = true;
            this.okBTN.Click += new System.EventHandler(this.okBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(12, 68);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 23);
            this.exitBTN.TabIndex = 1;
            this.exitBTN.Text = "Mégse";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add meg a Tiny URL-t:";
            // 
            // urlTB
            // 
            this.urlTB.Location = new System.Drawing.Point(12, 42);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(371, 20);
            this.urlTB.TabIndex = 3;
            // 
            // LinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 101);
            this.Controls.Add(this.urlTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.okBTN);
            this.Name = "LinkForm";
            this.Text = "Link hozzáadása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBTN;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox urlTB;
    }
}