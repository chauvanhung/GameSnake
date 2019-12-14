using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AI_Snake.Snake
{
    /// <summary>
    /// Class dùng để biểu diễn màn hình chơi
    /// </summary>
    class Screen
    {
        /// <summary>
        /// Mảng 2 chiều để đánh dấu màn hình
        /// </summary>
        ScreenType[,] point = new ScreenType[50, 50];

        /// <summary>
        /// Khởi tạo màn hình rỗng
        /// </summary>
        public Screen()
        {
            for (int i = 0; i < 50; i++)
                for (int j = 0; j < 50; j++)
                    point[i, j] = ScreenType.BLANK;
        }

        /// <summary>
        /// Thay đổi loại của 1 điểm trên màn hình
        /// </summary>
        /// <param name="p">điểm cần thay đổi</param>
        /// <param name="type">loại của điểm p</param>
        public void ChangeTypeAt(Point p, ScreenType type)
        {
            point[p.X, p.Y] = type;
        }

        /// <summary>
        /// Thay đổi loại của tất cả các điểm trên màn hình chơi
        /// </summary>
        /// <param name="p">mảng các điểm</param>
        public void ChangeTypeAll(Point[] p, ScreenType type)
        {
            foreach (Point x in p)
            {
                point[x.X, x.Y] = type;
            }
        }

        /// <summary>
        /// Kiểm tra xem điểm truyền vào có phải là điểm trống không?
        /// </summary>
        /// <param name="p">Điểm cần kiểm tra</param>
        /// <returns></returns>
        public bool IsBlank(Point p)
        {
            try
            {
                return point[p.X, p.Y] == ScreenType.BLANK;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Lấy loại tại 1 điểm
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public ScreenType GetScreenTypeAt(Point p)
        {
            try
            {
                return point[p.X, p.Y];
            }
            catch
            {
                return ScreenType.WALL;
            }
        }

        public void ClearVisited()
        {
            for (int i = 0; i < 50; i++)
                for (int j = 0; j < 50; j++)
                    if(point[i, j] == ScreenType.VISITED)
                        point[i, j] = ScreenType.BLANK;
        }
    }
}
