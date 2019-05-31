namespace DoAnTotNghiep
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
            this.lb1 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.anhgoc = new System.Windows.Forms.PictureBox();
            this.anhxam = new System.Windows.Forms.PictureBox();
            this.MausangXam = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.anhamban = new System.Windows.Forms.PictureBox();
            this.anhxuly = new System.Windows.Forms.PictureBox();
            this.XamsangAmBan = new System.Windows.Forms.Button();
            this.lb3 = new System.Windows.Forms.Label();
            this.zGHistogram = new ZedGraph.ZedGraphControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhgoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anhxam)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhamban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anhxuly)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(303, 12);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(47, 13);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Ảnh gốc";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(577, 569);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(131, 13);
            this.lb4.TabIndex = 2;
            this.lb4.Text = "Ảnh sau khi gian mức xám";
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(28, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tải ảnh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "Xử lý tăng cường ảnh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.8195F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.1805F));
            this.tableLayoutPanel1.Controls.Add(this.anhgoc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.anhxam, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(152, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 270);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // anhgoc
            // 
            this.anhgoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anhgoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anhgoc.Location = new System.Drawing.Point(3, 3);
            this.anhgoc.Name = "anhgoc";
            this.anhgoc.Size = new System.Drawing.Size(317, 264);
            this.anhgoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anhgoc.TabIndex = 0;
            this.anhgoc.TabStop = false;
            // 
            // anhxam
            // 
            this.anhxam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anhxam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anhxam.Location = new System.Drawing.Point(326, 3);
            this.anhxam.Name = "anhxam";
            this.anhxam.Size = new System.Drawing.Size(321, 264);
            this.anhxam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anhxam.TabIndex = 1;
            this.anhxam.TabStop = false;
            // 
            // MausangXam
            // 
            this.MausangXam.Location = new System.Drawing.Point(28, 94);
            this.MausangXam.Name = "MausangXam";
            this.MausangXam.Size = new System.Drawing.Size(75, 40);
            this.MausangXam.TabIndex = 7;
            this.MausangXam.Text = "Màu sang xám";
            this.MausangXam.UseVisualStyleBackColor = true;
            this.MausangXam.Click += new System.EventHandler(this.MausangXam_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(622, 12);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(48, 13);
            this.lb2.TabIndex = 8;
            this.lb2.Text = "Ảnh xám";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.8195F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.1805F));
            this.tableLayoutPanel2.Controls.Add(this.anhamban, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.anhxuly, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(152, 298);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(650, 264);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // anhamban
            // 
            this.anhamban.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anhamban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anhamban.Location = new System.Drawing.Point(3, 3);
            this.anhamban.Name = "anhamban";
            this.anhamban.Size = new System.Drawing.Size(317, 258);
            this.anhamban.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anhamban.TabIndex = 0;
            this.anhamban.TabStop = false;
            // 
            // anhxuly
            // 
            this.anhxuly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anhxuly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anhxuly.Location = new System.Drawing.Point(326, 3);
            this.anhxuly.Name = "anhxuly";
            this.anhxuly.Size = new System.Drawing.Size(321, 258);
            this.anhxuly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anhxuly.TabIndex = 1;
            this.anhxuly.TabStop = false;
            // 
            // XamsangAmBan
            // 
            this.XamsangAmBan.Location = new System.Drawing.Point(28, 152);
            this.XamsangAmBan.Name = "XamsangAmBan";
            this.XamsangAmBan.Size = new System.Drawing.Size(75, 48);
            this.XamsangAmBan.TabIndex = 10;
            this.XamsangAmBan.Text = "Xám sang âm bản";
            this.XamsangAmBan.UseVisualStyleBackColor = true;
            this.XamsangAmBan.Click += new System.EventHandler(this.Gray_Click);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(303, 569);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(64, 13);
            this.lb3.TabIndex = 11;
            this.lb3.Text = "Ảnh âm bản";
            // 
            // zGHistogram
            // 
            this.zGHistogram.Location = new System.Drawing.Point(805, 28);
            this.zGHistogram.Name = "zGHistogram";
            this.zGHistogram.ScrollGrace = 0D;
            this.zGHistogram.ScrollMaxX = 0D;
            this.zGHistogram.ScrollMaxY = 0D;
            this.zGHistogram.ScrollMaxY2 = 0D;
            this.zGHistogram.ScrollMinX = 0D;
            this.zGHistogram.ScrollMinY = 0D;
            this.zGHistogram.ScrollMinY2 = 0D;
            this.zGHistogram.Size = new System.Drawing.Size(510, 531);
            this.zGHistogram.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 591);
            this.Controls.Add(this.zGHistogram);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.XamsangAmBan);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.MausangXam);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anhgoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anhxam)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anhamban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anhxuly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox anhgoc;
        private System.Windows.Forms.Button MausangXam;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.PictureBox anhxam;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox anhamban;
        private System.Windows.Forms.PictureBox anhxuly;
        private System.Windows.Forms.Button XamsangAmBan;
        private System.Windows.Forms.Label lb3;
        private ZedGraph.ZedGraphControl zGHistogram;
    }
}

