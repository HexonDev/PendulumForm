namespace PendulumForm
{
    partial class DiscographyForm
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
            this.artistCB = new System.Windows.Forms.ComboBox();
            this.albumCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tracksDGV = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coverPB = new System.Windows.Forms.PictureBox();
            this.detailsRTB = new System.Windows.Forms.RichTextBox();
            this.addBTN = new System.Windows.Forms.Button();
            this.addUrlBTN = new System.Windows.Forms.Button();
            this.editBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLBL = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tracksDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPB)).BeginInit();
            this.SuspendLayout();
            // 
            // artistCB
            // 
            this.artistCB.FormattingEnabled = true;
            this.artistCB.Location = new System.Drawing.Point(12, 50);
            this.artistCB.Name = "artistCB";
            this.artistCB.Size = new System.Drawing.Size(121, 21);
            this.artistCB.TabIndex = 0;
            this.artistCB.SelectedIndexChanged += new System.EventHandler(this.artistCB_SelectedIndexChanged);
            // 
            // albumCB
            // 
            this.albumCB.FormattingEnabled = true;
            this.albumCB.Location = new System.Drawing.Point(192, 50);
            this.albumCB.Name = "albumCB";
            this.albumCB.Size = new System.Drawing.Size(121, 21);
            this.albumCB.TabIndex = 1;
            this.albumCB.SelectedIndexChanged += new System.EventHandler(this.albumCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Artist:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Album:";
            // 
            // searchTB
            // 
            this.searchTB.Enabled = false;
            this.searchTB.Location = new System.Drawing.Point(12, 97);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(301, 20);
            this.searchTB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search in  track\'s title";
            // 
            // tracksDGV
            // 
            this.tracksDGV.AllowUserToAddRows = false;
            this.tracksDGV.AllowUserToDeleteRows = false;
            this.tracksDGV.AllowUserToOrderColumns = true;
            this.tracksDGV.AllowUserToResizeColumns = false;
            this.tracksDGV.AllowUserToResizeRows = false;
            this.tracksDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Length});
            this.tracksDGV.Location = new System.Drawing.Point(12, 123);
            this.tracksDGV.Name = "tracksDGV";
            this.tracksDGV.RowHeadersVisible = false;
            this.tracksDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tracksDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tracksDGV.Size = new System.Drawing.Size(301, 298);
            this.tracksDGV.TabIndex = 6;
            this.tracksDGV.SelectionChanged += new System.EventHandler(this.tracksDGV_SelectionChanged);
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Length
            // 
            this.Length.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            // 
            // coverPB
            // 
            this.coverPB.Location = new System.Drawing.Point(338, 123);
            this.coverPB.Name = "coverPB";
            this.coverPB.Size = new System.Drawing.Size(150, 150);
            this.coverPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPB.TabIndex = 7;
            this.coverPB.TabStop = false;
            // 
            // detailsRTB
            // 
            this.detailsRTB.Location = new System.Drawing.Point(494, 123);
            this.detailsRTB.Name = "detailsRTB";
            this.detailsRTB.Size = new System.Drawing.Size(268, 150);
            this.detailsRTB.TabIndex = 8;
            this.detailsRTB.Text = "";
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(397, 381);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(118, 40);
            this.addBTN.TabIndex = 10;
            this.addBTN.Text = "Add discography";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // addUrlBTN
            // 
            this.addUrlBTN.Enabled = false;
            this.addUrlBTN.Location = new System.Drawing.Point(521, 381);
            this.addUrlBTN.Name = "addUrlBTN";
            this.addUrlBTN.Size = new System.Drawing.Size(118, 40);
            this.addUrlBTN.TabIndex = 11;
            this.addUrlBTN.Text = "Add URL";
            this.addUrlBTN.UseVisualStyleBackColor = true;
            this.addUrlBTN.Click += new System.EventHandler(this.addUrlBTN_Click);
            // 
            // editBTN
            // 
            this.editBTN.Enabled = false;
            this.editBTN.Location = new System.Drawing.Point(645, 381);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(118, 40);
            this.editBTN.TabIndex = 12;
            this.editBTN.Text = "Edit Selected";
            this.editBTN.UseVisualStyleBackColor = true;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "URL (if any):";
            // 
            // linkLBL
            // 
            this.linkLBL.AutoSize = true;
            this.linkLBL.Location = new System.Drawing.Point(460, 329);
            this.linkLBL.Name = "linkLBL";
            this.linkLBL.Size = new System.Drawing.Size(0, 13);
            this.linkLBL.TabIndex = 14;
            // 
            // DiscographyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 433);
            this.Controls.Add(this.linkLBL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.editBTN);
            this.Controls.Add(this.addUrlBTN);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.detailsRTB);
            this.Controls.Add(this.coverPB);
            this.Controls.Add(this.tracksDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albumCB);
            this.Controls.Add(this.artistCB);
            this.Name = "DiscographyForm";
            this.Text = "Discography Tracker";
            this.Load += new System.EventHandler(this.DiscographyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tracksDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox artistCB;
        private System.Windows.Forms.ComboBox albumCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tracksDGV;
        private System.Windows.Forms.PictureBox coverPB;
        private System.Windows.Forms.RichTextBox detailsRTB;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button addUrlBTN;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.LinkLabel linkLBL;
    }
}

