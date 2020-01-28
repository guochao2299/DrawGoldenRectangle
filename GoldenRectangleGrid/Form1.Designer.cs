namespace GoldenRectangleGrid
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDraw = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericGoldenRectLoops = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBasicUnit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpGoldenRect = new System.Windows.Forms.TabPage();
            this.pGoldenRect = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGoldenRectLoops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBasicUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpGoldenRect.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.btnDraw);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.numericGoldenRectLoops);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.nudBasicUnit);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 569;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(22, 93);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(184, 34);
            this.btnDraw.TabIndex = 11;
            this.btnDraw.Text = "绘制黄金矩形网格";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "重 ";
            // 
            // numericGoldenRectLoops
            // 
            this.numericGoldenRectLoops.Location = new System.Drawing.Point(95, 55);
            this.numericGoldenRectLoops.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericGoldenRectLoops.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericGoldenRectLoops.Name = "numericGoldenRectLoops";
            this.numericGoldenRectLoops.Size = new System.Drawing.Size(64, 25);
            this.numericGoldenRectLoops.TabIndex = 5;
            this.numericGoldenRectLoops.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "黄金矩形：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "像素";
            // 
            // nudBasicUnit
            // 
            this.nudBasicUnit.Location = new System.Drawing.Point(95, 20);
            this.nudBasicUnit.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudBasicUnit.Name = "nudBasicUnit";
            this.nudBasicUnit.Size = new System.Drawing.Size(64, 25);
            this.nudBasicUnit.TabIndex = 1;
            this.nudBasicUnit.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "基本单位：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 293);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tpGoldenRect
            // 
            this.tpGoldenRect.Controls.Add(this.pGoldenRect);
            this.tpGoldenRect.Location = new System.Drawing.Point(4, 25);
            this.tpGoldenRect.Name = "tpGoldenRect";
            this.tpGoldenRect.Padding = new System.Windows.Forms.Padding(3);
            this.tpGoldenRect.Size = new System.Drawing.Size(561, 421);
            this.tpGoldenRect.TabIndex = 0;
            this.tpGoldenRect.Text = "黄金矩形";
            this.tpGoldenRect.UseVisualStyleBackColor = true;
            // 
            // pGoldenRect
            // 
            this.pGoldenRect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pGoldenRect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGoldenRect.Location = new System.Drawing.Point(3, 3);
            this.pGoldenRect.Name = "pGoldenRect";
            this.pGoldenRect.Size = new System.Drawing.Size(555, 415);
            this.pGoldenRect.TabIndex = 0;
            this.pGoldenRect.Paint += new System.Windows.Forms.PaintEventHandler(this.PGoldenRect_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpGoldenRect);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(569, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "绘制黄金矩形";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericGoldenRectLoops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBasicUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpGoldenRect.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudBasicUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericGoldenRectLoops;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpGoldenRect;
        private System.Windows.Forms.Panel pGoldenRect;
    }
}

