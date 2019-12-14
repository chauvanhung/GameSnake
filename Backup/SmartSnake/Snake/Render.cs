using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace AI_Snake.Snake
{
    static class Render
    {
        /// <summary>
        /// độ rộng của mổi nút và góc làm tròn
        /// </summary>
        private const int WIDTH = 10;
        private const int RADIUS = 2;
        /// <summary>
        /// Vẽ các đường thân rắn dưới dạng hình  vuông làm tròn góc
        /// </summary>
        /// <param name="g">Nơi dùng để vẽ lên</param>
        /// <param name="p">Điểm vẽ hình </param>
        /// <param name="pen">Màu sắc khung</param>
        /// <param name="brush">Màu sắc tô bên trong</param>
        public static void Draw(Graphics g, Point p, Pen pen, Brush brush)
        {
            try
            {
                GraphicsPath gp = new GraphicsPath();

                gp.AddLine(p.X + RADIUS, p.Y, p.X + WIDTH - (RADIUS * 2), p.Y);
                gp.AddArc(p.X + WIDTH - (RADIUS * 2), p.Y, RADIUS * 2, RADIUS * 2, 270, 90);

                gp.AddLine(p.X + WIDTH, p.Y + RADIUS, p.X + WIDTH, p.Y + WIDTH - (RADIUS * 2));
                gp.AddArc(p.X + WIDTH - (RADIUS * 2), p.Y + WIDTH - (RADIUS * 2), RADIUS * 2, RADIUS * 2, 0, 90);

                gp.AddLine(p.X + WIDTH - (RADIUS * 2), p.Y + WIDTH, p.X + RADIUS, p.Y + WIDTH);
                gp.AddArc(p.X, p.Y + WIDTH - (RADIUS * 2), RADIUS * 2, RADIUS * 2, 90, 90);

                gp.AddLine(p.X, p.Y + WIDTH - (RADIUS * 2), p.X, p.Y + RADIUS);
                gp.AddArc(p.X, p.Y, RADIUS * 2, RADIUS * 2, 180, 90);

                gp.CloseFigure();

                g.FillPath(brush, gp);
                g.DrawPath(pen, gp);

                gp.Dispose();
            }
            catch
            {
            }
        }
    }
}
