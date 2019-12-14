using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace AI_Snake.Snake
{
    /// <summary>
    /// Class dùng để biểu diễn các chướng ngại vật trên màn hình chơi
    /// </summary>
    class Wall
    {
        /// <summary>
        /// Mảng các điểm là vật cản
        /// </summary>
        private Point[] walls;

        /// <summary>
        /// Thuộc tính để lấy mảng các điểm là vật cản
        /// </summary>
        public Point[] Walls
        {
            get { return walls; }
        }
        
        /// <summary>
        /// Số lượng vật cản thật sự
        /// </summary>
        private int count;

        public Wall()
        {
            walls = new Point[50 * 50];
            count = 0;
        }

        /// <summary>
        /// Đọc file biểu diễn các chướng ngại vật.
        /// File có nội dung gồm các ký tự 0, 1
        /// 1 biểu diễn cho chướng ngại vật
        /// </summary>
        /// <param name="filePath">đường dẫn đến file</param>
        public void ReadFromFile(string filePath)
        {
            StreamReader read;
            try
            {
                read = new StreamReader(filePath);
                count = 0;
                //i là chỉ số dòng trong file
                for (int i = 0; i < 50; i++)
                {
                    //j là chỉ số cột trong file
                    for (int j = 0; j < 50; j++)
                        //nếu tại dòng i cột j là 1 (49 là mã ascii của 1) thì
                        if (read.Read() == 49)
                        {
                            //tạo 1 điểm là chướng ngại vật
                            walls[count] = new Point(j, i);

                            count++;
                        }
                    //bỏ qua 2 ký tự điều khiển
                    //ký tự có mã ASCII: char: CR, Dec: 13
                    read.Read();
                    //ký tự xuống dòng (mã ASCII: char: LF, Dec: 10)
                    read.Read();
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi đọc file để tạo chướng ngại vật",
                    "Error: ReadObstructionsFromFile()",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Vẽ các chướng ngại vật.
        /// </summary>
        /// <param name="g">đối tượng sẽ được vẽ lên</param>
        /// <param name="p">viền</param>
        /// <param name="br">màu</param>
        public void Draw(Graphics g)
        {
            for (int i = 0; i < count; i++)
                Render.Draw(g, new Point(walls[i].X * 10, walls[i].Y * 10), Pens.Blue, Brushes.Peru);
        }

        /// <summary>
        /// Xóa các chướng ngại vật
        /// </summary>
        /// <param name="g">đối tượng mà các chướng ngại vật được vẽ trên đó</param>
        public void Clear(Graphics g)
        {
            for (int i = 0; i < count; i++)
            {
                Render.Draw(g, new Point(walls[i].X * 10, walls[i].Y * 10), Pens.White, Brushes.White);
            }
        }

    }
}
