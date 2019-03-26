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
            this.lb2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.anhdauvao = new System.Windows.Forms.PictureBox();
            this.anhdaura = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhdauvao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anhdaura)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(329, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(47, 13);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Ảnh gốc";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(610, 9);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(120, 13);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Ảnh sau khi tăng cường";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tải ảnh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xử lý tăng cường ảnh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.anhdauvao, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.anhdaura, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(210, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 314);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // anhdauvao
            // 
            this.anhdauvao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anhdauvao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anhdauvao.Location = new System.Drawing.Point(3, 3);
            this.anhdauvao.Name = "anhdauvao";
            this.anhdauvao.Size = new System.Drawing.Size(297, 308);
            this.anhdauvao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.anhdauvao.TabIndex = 0;
            this.anhdauvao.TabStop = false;
            // 
            // anhdaura
            // 
            this.anhdaura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anhdaura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anhdaura.Location = new System.Drawing.Point(306, 3);
            this.anhdaura.Name = "anhdaura";
            this.anhdaura.Size = new System.Drawing.Size(298, 308);
            this.anhdaura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.anhdaura.TabIndex = 1;
            this.anhdaura.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anhdauvao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anhdaura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox anhdauvao;
        private System.Windows.Forms.PictureBox anhdaura;
    }
}

