using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace AI_Snake.Snake
{
    /// <summary>
    /// Class biểu diễn con rắn
    /// </summary>
    class Snake
    {
        /// <summary>
        /// Mảng các điểm là thân rắn.
        /// snakeBody[0] là đầu rắn
        /// </summary>
        protected Point[] snakeBody = new Point[50 * 50];

        /// <summary>
        /// Thuộc tính để lấy mảng các điểm là thân rắn.
        /// </summary>
        public Point[] SnakeBody
        {
            get { return snakeBody; }
        }

        /// <summary>
        /// Đầu của con rắn
        /// </summary>
        public Point Head
        {
            get { return snakeBody[0]; }
        }

        /// <summary>
        /// Đuôi con rắn
        /// </summary>
        public Point Tail
        {
            get { return snakeBody[Length - 1]; }
        }

        /// <summary>
        /// độ dài của rắn
        /// khởi tạo là 4
        /// </summary>
        protected int length;

        /// <summary>
        /// Thuộc tính để lấy độ dài của con rắn
        /// </summary>
        public int Length
        {
            get { return length; }
        }

        /// <summary>
        /// Màu đầu rắn
        /// </summary>
        protected Brush headColor;

        /// <summary>
        /// Màu thân rắn
        /// </summary>
        protected Brush bodyColor;

        /// <summary>
        /// Màu viền của thân rắn
        /// </summary>
        protected Pen fringe;

        /// <summary>
        /// Tốc độ di chuyển.
        /// Giá trị càng cao thì rắn càng chậm
        /// </summary>
        protected int speed;

        /// <summary>
        /// Thuộc tính để lấy tốc độ của di chuyển của rắn
        /// </summary>
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        /// <summary>
        /// Hướng di chuyển của con rắn
        /// </summary>
        protected Transfer transfer;

        /// <summary>
        /// Thuộc tính hướng di chuyển của rắn
        /// </summary>
        public Transfer Transfer
        {
            get { return transfer; }
            set { transfer = value; }
        }

        /// <summary>
        /// Gán các giá trị mặc định cho các thuộc tính
        /// </summary>
        public Snake()
        {
            length = 4;
            bodyColor = Brushes.LightBlue;
            headColor = Brushes.Red;
            fringe = Pens.BlueViolet;

            Point root = new Point(5, 5);
            for (int i = length - 1; i >= 0; i--)
                snakeBody[i] = new Point(root.X, root.Y - i);

            speed = 150;

            transfer = Transfer.DOWN;
        }

        /// <summary>
        /// Vẽ con rắn
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            //vẽ đầu rắn
            Render.Draw(g, new Point(snakeBody[0].X * 10, snakeBody[0].Y * 10), headColor);
            //vẽ thân rắn
            for (int i = 1; i < length; i++)
                //g.FillRectangle(bodyColor, snakeBody[i].X * 10, snakeBody[i].Y * 10, 10, 10);
                Render.Draw(g, new Point(snakeBody[i].X * 10, snakeBody[i].Y * 10), bodyColor);
        }

        /// <summary>
        /// Cập nhật lại mảng vị trí của con rắn và vẽ lại rắn.
        /// </summary>
        public void Move(Graphics g)
        {
            //xóa đuôi của rắn trên graphic
            Render.Draw(g, new Point(snakeBody[length - 1].X * 10, snakeBody[length - 1].Y * 10), Brushes.White);

            //cập nhật lại vị trí thân rắn
            //cập nhật từ đuôi trừ đầu chưa cập nhật
            for (int i = length - 1; i > 0; i--)
            {
                snakeBody[i] = snakeBody[i - 1];
                Render.Draw(g, new Point(snakeBody[i].X * 10, snakeBody[i].Y * 10), bodyColor);
            }

            //cập nhật đầu
            if (transfer == Transfer.LEFT)
            {
                snakeBody[0].X -= 1;
                if (snakeBody[0].X < 0)
                    snakeBody[0].X = 49;
            }
            else if (transfer == Transfer.RIGHT)
            {
                snakeBody[0].X += 1;
                if (snakeBody[0].X > 49)
                    snakeBody[0].X = 0;
            }
            else if (transfer == Transfer.UP)
            {
                snakeBody[0].Y -= 1;
                if (snakeBody[0].Y < 0)
                    snakeBody[0].Y = 49;
            }
            else
            {
                snakeBody[0].Y += 1;
                if (snakeBody[0].Y > 49)
                    snakeBody[0].Y = 0;
            }

            //vẽ lại cái đầu ở vị trí mới cho con rắn.
            Render.Draw(g, new Point(snakeBody[0].X * 10, snakeBody[0].Y * 10),  headColor);
        }

        /// <summary>
        /// Xóa con rắn
        /// <param name="g">Đối tượng graphic mà con rắn được vẽ trên đó</param>
        /// </summary>
        public void Clear(Graphics g)
        {
            for (int i = 0; i < length; i++)
                Render.Draw(g, new Point(snakeBody[i].X * 10, snakeBody[i].Y * 10), Brushes.White);
        }

        /// <summary>
        /// Tăng tốc độ di chuyển
        /// </summary>
        public void IncreaseSpeed()
        {
            if (speed > 50)
                speed = speed - 50;
        }

        /// <summary>
        /// Làm rắn lớn lên khi ăn thức ăn
        /// </summary>
        public void GrowUp()
        {
            snakeBody[length] = new Point(snakeBody[length - 1].X, snakeBody[length - 1].Y);
            length = length + 1;
        }
    }
}
