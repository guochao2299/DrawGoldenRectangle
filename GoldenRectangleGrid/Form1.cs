using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenRectangleGrid
{
    public partial class Form1 : Form
    {
        private Color m_goldenColor = Color.FromArgb(255, 255, 242, 51);
        private int m_startX = 90;
        private int m_startY = 0;
        private bool m_drawable = false;

        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
        }

        private void PGoldenRect_Paint(object sender, PaintEventArgs e)
        {
            if (!m_drawable)
            {
                return;
            }

            int baseUnit = Convert.ToInt32(nudBasicUnit.Value);
            int drawLoop = Convert.ToInt32(numericGoldenRectLoops.Value);
            DrawSingleGlodenRect(e.Graphics, baseUnit, drawLoop);
        }

        private void DrawSingleGlodenRect(Graphics g,int baseUnit,int drawLoop)
        {
            //保留整个图形的左上角坐标及高宽
            int originX = 0;
            int originY = 0;
            int totalHeight = 0;
            int totalWidth = 0;

            //计算斐波那契数列
            int n1 = 1;
            int n2 = 1;
            int n3 = 0;

            //记录上上轮、上轮和本轮的
            int n1Length = baseUnit;
            int n2Length = baseUnit;
            int n3Length = baseUnit;

            GraphicsPath gp = new GraphicsPath();
            
            gp.AddRectangle(new Rectangle(m_startX, m_startY, n1Length, n1Length));
            originX = m_startX;
            originY = m_startY;
            totalHeight = n1Length;
            totalWidth = n1Length;

            m_startX = m_startX + n1Length;
            gp.AddRectangle(new Rectangle(m_startX, m_startY, n2Length, n2Length));
            totalWidth = n1Length + n2Length;

            for (int i = 2; i < drawLoop; i++)
            {
                n3 = n1 + n2;

                switch (i%4)
                {
                    case 1:
                        m_startX = m_startX + n2Length;
                        n3Length = n3 * baseUnit;

                        totalWidth += n3Length;
                        break;

                    case 2:
                        m_startX = m_startX - n1Length;                        
                        m_startY += n2Length;
                        n3Length = n3 * baseUnit;


                        totalWidth = n3Length;
                        totalHeight += n3Length;
                        break;

                    case 3:                       
                        m_startY -= n1Length;
                        n3Length = n3 * baseUnit;
                        m_startX = m_startX - n3Length;

                        originX = m_startX;
                        originY = m_startY;
                        totalWidth = n3Length + n2Length;
                        totalHeight = n3Length;
                        break;

                    case 0:
                        n3Length = n3 * baseUnit;
                        m_startY -= n3Length;

                        originY = m_startY;
                        totalHeight += n3Length;
                        
                        break;
                }
                
                gp.AddRectangle(new Rectangle(m_startX, m_startY, n3Length, n3Length));

                n1 = n2;
                n2 = n3;
                n1Length = n2Length;
                n2Length = n3Length;
            }

            g.DrawPath(new Pen(m_goldenColor, 1), gp);
            g.DrawRectangle(Pens.Black, originX-1,originY-1,totalWidth+2,totalHeight+2);

            Bitmap b = new Bitmap(totalWidth+1, totalHeight+1);
            Graphics gBitmap = Graphics.FromImage(b);
            gBitmap.TranslateTransform(-originX, -originY);
            gBitmap.DrawPath(new Pen(m_goldenColor, 1), gp);
            gBitmap.Dispose();
            pictureBox1.Image = b;
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            m_startX = pGoldenRect.Width / 2;
            m_startY = pGoldenRect.Height / 2;
            m_drawable = true;
            pGoldenRect.Refresh();
        }
    }
}
