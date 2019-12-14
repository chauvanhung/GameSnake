using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace AI_Snake.Snake
{
    /// <summary>
    /// Class dùng để biểu diễn thức ăn trên màn hình chơi.
    /// </summary>
    class Food
    {
        /// <summary>
        /// Dùng để lưu tọa độ của thức ăn trên màn hình chơi
        /// </summary>
        private Point coordinates;

        /// <summary>
        /// Dùng để sinh tọa độ ngẫu nhiên cho thức ăn
        /// </summary>
        private Random random;

        /// <summary>
        /// Thuộc tính dùng để lấy tọa độ của thức ăn.
        /// </summary>
        public Point Coordinates
        {
            get { return coordinates; }
        }

        /// <summary>
        /// Sinh tọa độ ngẫu nhiên cho thức ăn
        /// </summary>
        public void CreateFood()
        {
            random=new Random();
            coordinates.X = random.Next(50);
            coordinates.Y = random.Next(50);
        }

        /// <summary>
        /// Vẽ thức ăn
        /// </summary>
        public void Draw(Graphics g)
        {
            Render.Draw(g, new Point(coordinates.X * 10, coordinates.Y * 10), Pens.Red, Brushes.MediumSeaGreen);
        }

        /// <summary>
        /// Xóa thức ăn
        /// </summary>
        public void Clear(Graphics g)
        {
            Render.Draw(g, new Point(coordinates.X * 10, coordinates.Y * 10), Pens.White, Brushes.White);
        }

    }
}
