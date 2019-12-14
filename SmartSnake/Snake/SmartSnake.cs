using AI_Snake.AI;
using System.Drawing;

namespace AI_Snake.Snake
{
    class SmartSnake : Snake
    {
        /// <summary>
        /// Đường dẫn đến thức ăn.
        /// Chỉ dành cho rắn của máy tính
        /// </summary>
        Point[] path;

        /// <summary>
        /// Đường dẫn đến thức ăn.
        /// Chỉ dành cho rắn của máy tính
        /// </summary>
        public Point[] Path
        {
            get { return path; }
            set { path = value; }
        }

        /// <summary>
        /// Chỉ số bước đi tiếp theo trong path
        /// Đồng thời là độ dài của đường đi luôn
        /// </summary>
        int stepIndex;

        /// <summary>
        /// Chỉ số bước đi tiếp theo trong path
        /// Đồng thời là độ dài của đường đi luôn
        /// </summary>
        public int StepIndex
        {
            get { return stepIndex; }
            set { stepIndex = value; }
        }

        /// <summary>
        /// Chỉ định thuật toán được sử dụng để tìm đường đi
        /// </summary>
        private Algorithms algorithm;

        /// <summary>
        /// Chỉ định thuật toán được sử dụng để tìm đường đi
        /// </summary>
        public Algorithms Algorithm
        {
            get { return algorithm; }
            set { algorithm = value; }
        }

        public SmartSnake(Brush headColor, Brush bodyColor, Point root)
        {
            length = 4;
            this.bodyColor = bodyColor;
            this.headColor = headColor;
            fringe = Pens.BlueViolet;

            for (int i = length - 1; i >= 0; i--)
                snakeBody[i] = new Point(root.X, root.Y - i);

            speed = 150;

            transfer = Transfer.DOWN;

            path = new Point[50 * 50];
            stepIndex = 0;
        }

        public bool FindPath(Point food, Screen screen)
        {
            try
            {
                State start = new State(this.Head);
                State goal = new State(food);
                State result;

                if (algorithm == Algorithms.BreadthFirstSearch)
                    result = BreadthFirstSearch.BFS(start, goal, screen);
                else
                    result = DepthFirstSearch.DFS(start, goal, screen);
                if (result != null)//tìm thấy đường đi
                {
                    this.stepIndex = 0;

                    while (result.Previous != null)
                    {
                        path[stepIndex] = result.Coordinates;
                        stepIndex++;

                        result = result.Previous;
                    }
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Cho rắn di chuyển theo đường đi đã tìm thấy.
        /// Rắn đi từ cuối path về đầu path
        /// </summary>
        public new void Move(Graphics g)
        {
            if (stepIndex > 0)
            {
                //xóa đuôi của con rắn trên graphic
                Render.Draw(g, new Point(snakeBody[length - 1].X * 10, snakeBody[length - 1].Y * 10),  Brushes.White);

                //cập nhật lại vị trí thân rắn
                //cập nhật từ đuôi trừ đầu chưa cập nhật
                for (int i = length - 1; i > 0; i--)
                {
                    snakeBody[i] = snakeBody[i - 1];
                    Render.Draw(g, new Point(snakeBody[i].X * 10, snakeBody[i].Y * 10), bodyColor);
                }

                //cập nhật đầu
                snakeBody[0] = path[stepIndex - 1];
                stepIndex--;

                //vẽ lại cái đầu ở vị trí mới cho con rắn.
                Render.Draw(g, new Point(snakeBody[0].X * 10, snakeBody[0].Y * 10),  headColor);
            }
        }

    }
}
