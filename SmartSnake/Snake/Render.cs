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
        /// độ rộng của mổi nút 
        /// </summary>
        private const int WIDTH = 10;
      // private const int RADIUS = 0;
        /// <summary>
        /// Vẽ các đường thân rắn dưới dạng hình vuông
        /// </summary>
        /// <param name="g">Nơi dùng để vẽ lên</param>
        /// <param name="p">Điểm vẽ hình </param>
        /// <param name="pen">Màu sắc khung</param>
        /// <param name="brush">Màu sắc tô bên trong</param>
        public static void Draw(Graphics g, Point p,  Brush brush)
        {
            try
            {
                GraphicsPath gp = new GraphicsPath();

                gp.AddLine(p.X , p.Y, p.X + WIDTH, p.Y);
             
                gp.AddLine(p.X + WIDTH, p.Y , p.X + WIDTH, p.Y + WIDTH);
              
                gp.AddLine(p.X + WIDTH , p.Y + WIDTH, p.X , p.Y + WIDTH);
              
                gp.AddLine(p.X, p.Y + WIDTH , p.X, p.Y);
              
                gp.CloseFigure();

                g.FillPath(brush, gp);
                         
            }
            catch
            {
            }
        }
    }
}
