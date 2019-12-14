using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace AI_Snake.AI
{
    /// <summary>
    /// Biểu diễn 1 trạng thái trong bài toán tìm kiếm đường đi.
    /// </summary>
    class State
    {
        /// <summary>
        /// Tọa độ của trạng thái này.
        /// </summary>
        private Point coordinates;

        /// <summary>
        /// Tọa độ của trạng thái này.
        /// </summary>
        public Point Coordinates
        {
            get { return coordinates; }
            set { coordinates = value; }
        }

        /// <summary>
        /// Tọa độ X của trạng thái.
        /// X = Coordinates.X
        /// </summary>
        public int X
        {
            get { return coordinates.X; }
        }

        /// <summary>
        /// Tọa độ Y của trạng thái.
        /// Y = Coordinates.Y
        /// </summary>
        public int Y
        {
            get { return coordinates.Y; }
        }

        /// <summary>
        /// Trạng thái trước trạng thái này
        /// </summary>
        private State previous;

        /// <summary>
        /// Trạng thái trước trạng thái này
        /// </summary>
        internal State Previous
        {
            get { return previous; }
            set { previous = value; }
        }

        /// <summary>
        /// Coordinates = Point(0, 0)
        /// Previous = Null;
        /// </summary>
        public State()
        {
            coordinates = new Point(0, 0);
            previous = null;
        }

        /// <param name="coordinates">Tọa độ của trạng thái</param>
        /// <param name="previous">Trạng thái trước trạng thái này</param>
        public State(Point coordinates, State previous)
        {
            this.coordinates = coordinates;
            this.previous = previous;
        }

        /// <param name="x">Tọa độ X của trạng thái.</param>
        /// <param name="y">Tọa độ Y của trạng thái.</param>
        /// <param name="previous">Trạng thái trước trạng thái này</param>
        public State(int x, int y, State previous)
        {
            coordinates = new Point(x, y);
            this.previous = previous;
        }


        /// <param name="x">Tọa độ X của trạng thái.</param>
        /// <param name="y">Tọa độ Y của trạng thái.</param>
        public State(int x, int y)
        {
            this.coordinates.X = x;
            this.coordinates.Y = y;
            this.previous = null;
        }

        public State(Point p)
        {
            coordinates = new Point(p.X, p.Y);
            this.previous = null;
        }

        /// <summary>
        /// Sinh ra các trạng thái tiếp theo của trạng thái này
        /// </summary>
        /// <param name="result">mảng các trạng thái tiếp theo</param>
        /// <returns>số lượng các trạng thái tiếp theo có thể
        /// Bằng 0 nếu không có trạng thái tiếp theo nào
        /// </returns>
        public int Succs(ref State[] result)
        {

            if (this.X < 0 || this.Y < 0 || this.X > 50 || this.Y > 50)
                return 0;
            else
            {
                int count = 0;
                result = new State[4];

                #region Thêm trạng thái bên trái trạng thái state_N
                if (this.X - 1 >= 0)
                {
                    result[count] = new State(this.X - 1, this.Y, this);
                    count++;
                }
                #endregion

                #region Thêm trạng thái phía trên trạng thái state_N
                if (this.Y - 1 >= 0)
                {
                    result[count] = new State(this.X, this.Y - 1, this);
                    count++;
                }
                #endregion

                #region Thêm trạng thái bên phải trạng thái state_N
                if (this.X + 1 <= 50)
                {
                    result[count] = new State(this.X + 1, this.Y, this);
                    count++;
                }
                 #endregion

                #region Thêm trạng thái phía dưới trạng thái state_N
                if (this.Y + 1 <= 50)
                {
                    result[count] = new State(this.X, this.Y + 1, this);
                    count++;
                }
                 #endregion

                return count;
            }
        }

        /// <summary>
        /// So sánh 2 trạng thái có trùng nhau không
        /// </summary>
        /// <param name="state"></param>
        /// <returns>true: nếu trùng
        /// false: ngược lại</returns>
        public bool Equal(State state)
        {
            return (this.coordinates.X == state.coordinates.X
                && this.coordinates.Y == state.coordinates.Y);
        }
    }
}
