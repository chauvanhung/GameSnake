using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AI_Snake.Snake;
using System.Media;
using AI_Snake.AI;

namespace AI_Snake.GUI
{
    public partial class Form1 : Form
    {
        AI_Snake.Snake.Screen manHinh;
        Wall vatCan;
        AI_Snake.Snake.Snake conRan;
        SmartSnake ranThongMinh;
        Graphics g;
        Food thucAn;
        Transfer camDi;

        public Form1()
        {
            InitializeComponent();
            this.Reset();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            vatCan.Draw(g);
            thucAn.Draw(g);
            conRan.Draw(g);
            ranThongMinh.Draw(g);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //đánh dấu đuôi là trống và cho rắn di chuyển
            manHinh.ChangeTypeAt(conRan.Tail, ScreenType.BLANK);
            conRan.Move(g);

            manHinh.ChangeTypeAt(ranThongMinh.Tail, ScreenType.BLANK);
            ranThongMinh.Move(g);
            manHinh.ChangeTypeAt(ranThongMinh.Head, ScreenType.SNAKE);
            this.XuLy();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left && camDi != Transfer.LEFT)
            {
                conRan.Transfer = Transfer.LEFT;
                camDi = Transfer.RIGHT;
            }
            else if (keyData == Keys.Right && camDi != Transfer.RIGHT)
            {
                conRan.Transfer = Transfer.RIGHT;
                camDi = Transfer.LEFT;
            }
            else if (keyData == Keys.Up && camDi != Transfer.UP)
            {
                conRan.Transfer = Transfer.UP;
                camDi = Transfer.DOWN;
            }
            else if (keyData == Keys.Down && camDi != Transfer.DOWN)
            {
                conRan.Transfer = Transfer.DOWN;
                camDi = Transfer.UP;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            if (timer_tocDo.Enabled)
            {
                timer_tocDo.Enabled = false;
                play_button.Text = "Chơi";
               // pauseToolStripMenuItem.Enabled = false;
               // nhacnen.Stop();
                //playToolStripMenuItem.Enabled = true;
            }
            else
            {
                timer_tocDo.Enabled = true;
                play_button.Text = "Dừng";
               // playToolStripMenuItem.Enabled = false;
               // nhacnen.PlayLooping();
              //  pauseToolStripMenuItem.Enabled = true;
            }
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                DialogResult traLoi = MessageBox.Show("Bạn có chắc muốn chơi lại?", "My Snake!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (traLoi == DialogResult.Yes)
                    this.Reset();
            }
            else
                this.Reset();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                DialogResult traLoi = MessageBox.Show("Bạn có chắc muốn thoát?", "My Snake!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (traLoi == DialogResult.Yes)
                    Application.Exit();
            }
            else
                Application.Exit();
        }

        private void XuLy()
        {
            ScreenType temp;

            #region Xử lý cho rắn của người chơi

            temp = manHinh.GetScreenTypeAt(conRan.Head);

            if (temp != ScreenType.WALL
                && !conRan.Head.Equals(thucAn.Coordinates))
                manHinh.ChangeTypeAt(conRan.Head, ScreenType.SNAKE);
            //gặp thức ăn
            else if (conRan.Head.Equals(thucAn.Coordinates))
            {
                //nhacRanNguoiChoi.Play();
                //nhacnen.PlayLooping();
                manHinh.ChangeTypeAt(conRan.Head, ScreenType.SNAKE);
                this.GapThucAn();
                this.TangTocDo();

                return;
            }
            // đụng vật cản
            else
                this.GameOver();

            #endregion

            #region Xử lý cho rắn của máy

            temp = manHinh.GetScreenTypeAt(ranThongMinh.Head);

            if (ranThongMinh.Head.Equals(thucAn.Coordinates))
            {
                //nhacRanMay.Play();
                //nhacnen.PlayLooping();
                ranThongMinh.GrowUp();
                computer_lbl.Text = (computer += 10).ToString();
                this.TangTocDo();

                //tạo thức ăn
                do
                {
                    thucAn.CreateFood();
                } while (!manHinh.IsBlank(thucAn.Coordinates));
                manHinh.ChangeTypeAt(thucAn.Coordinates, ScreenType.FOOD);

                ranThongMinh.FindPath(thucAn.Coordinates, manHinh);
                show_button.Text = "Show";

                thucAn.Draw(g);
            }

            #endregion

            if (computer == MAX_SCORE)
                this.GameOver();
        }

        private void TangTocDo()
        {
            if (player != 0 && computer != 0)
                if (player % 50 == 0 || computer % 50 == 0)
                {
                    conRan.IncreaseSpeed();
                    ranThongMinh.IncreaseSpeed();
                    timer_tocDo.Interval = conRan.Speed;

                    //xử lý phần hiện tốc độ của rắn ở dưới thanh status
                    tocDo_lbl.Text = (int.Parse(tocDo_lbl.Text) + 50).ToString();
                }
        }

        private void GameOver()
        {
            gameOver = true;
            timer_tocDo.Enabled = false;
            play_button.Enabled = false;
           // nhacnen.Stop();
            MessageBox.Show("Game Over", "My Snake",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void GapThucAn()
        {
            //con rắn lớn lên
            conRan.GrowUp();

            player_lbl.Text = (player += 10).ToString();

            //tạo thức ăn
            do
            {
                thucAn.CreateFood();
            } while (!manHinh.IsBlank(thucAn.Coordinates));
            manHinh.ChangeTypeAt(thucAn.Coordinates, ScreenType.FOOD);

            ranThongMinh.FindPath(thucAn.Coordinates, manHinh);
            show_button.Text = "Show";

            thucAn.Draw(g);
        }

        private void Reset()
        {
            g = panel1.CreateGraphics();

            manHinh = new AI_Snake.Snake.Screen();

            //khởi tạo vật cản
            vatCan = new Wall();
            vatCan.ReadFromFile("level1.lev");
            manHinh.ChangeTypeAll(vatCan.Walls, ScreenType.WALL);

            //khởi tạo con rắn
            conRan = new AI_Snake.Snake.Snake();
            manHinh.ChangeTypeAll(conRan.SnakeBody, ScreenType.SNAKE);
            timer_tocDo.Interval = conRan.Speed;
            timer_tocDo.Enabled = false;
            camDi = Transfer.UP;

            //khởi tạo rắn thông minh
            ranThongMinh = new SmartSnake(Brushes.Blue, Brushes.LightSalmon, new Point(44, 5));
            manHinh.ChangeTypeAll(ranThongMinh.SnakeBody, ScreenType.SNAKE);
            ranThongMinh.Speed = conRan.Speed;

            //tạo thức ăn
            thucAn = new Food();
            do
            {
                thucAn.CreateFood();
            } while (!manHinh.IsBlank(thucAn.Coordinates));
            manHinh.ChangeTypeAt(thucAn.Coordinates, ScreenType.FOOD);

            //rắn thông minh tìm đường đi
            ranThongMinh.FindPath(thucAn.Coordinates, manHinh);
            show_button.Text = "Hiển thị đường đi";

            //trang trí
            player_lbl.Text = "0";
            computer_lbl.Text = "1";

            play_button.Text = "Chơi";
            play_button.Enabled = true;

            g.Clear(Color.White);
            vatCan.Draw(g);
            thucAn.Draw(g);
            conRan.Draw(g);
            ranThongMinh.Draw(g);

            gameOver = false;
            player = 0;
            computer = 0;
            player_lbl.Text = "0";
            computer_lbl.Text = "0";
            tocDo_lbl.Text = "100";

            ////âm thanh
            //nhacnen = new SoundPlayer(@"nhac nen.wav");
            ////nhacRanMay = new SoundPlayer(@"Sound\ran may.wav");
            ////nhacRanNguoiChoi = new SoundPlayer(@"Sound\ran nguoi choi.wav");
            //nhacnen.Stop();
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            Point p;
            Button temp = (Button)sender;
            if (temp.Text == "Hiển thị đường đi")
            {
                temp.Text = "Dọn sạch";
                for (int i = ranThongMinh.StepIndex - 1; i > 0; i--)
                {
                    p = new Point(ranThongMinh.Path[i].X * 10, ranThongMinh.Path[i].Y * 10);
                    Render.Draw(g, p,  Brushes.DarkGray);
                }
            }
            else
            {
                temp.Text = "Hiển thị đường đi";
                g.Clear(Color.White);
                vatCan.Draw(g);
                conRan.Draw(g);
                ranThongMinh.Draw(g);
            }
            thucAn.Draw(g);
        }

        private void mazesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chọn mê cung khác sẽ chơi lại từ đầu. Bạn chắc chắn chọn?"
                , "My Snake", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Level file (*.lev)|*.lev|All file (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    this.Reset();
                    vatCan.Clear(g);
                    vatCan = new Wall();
                    vatCan.ReadFromFile(open.FileName);
                    manHinh = new AI_Snake.Snake.Screen();
                    manHinh.ChangeTypeAll(vatCan.Walls, ScreenType.WALL);
                    manHinh.ChangeTypeAll(conRan.SnakeBody, ScreenType.SNAKE);
                    manHinh.ChangeTypeAll(ranThongMinh.SnakeBody, ScreenType.SNAKE);

                    thucAn.Clear(g);
                    thucAn = new Food();
                    do
                    {
                        thucAn.CreateFood();
                    } while (!manHinh.IsBlank(thucAn.Coordinates));
                    manHinh.ChangeTypeAt(thucAn.Coordinates, ScreenType.FOOD);

                    ranThongMinh.FindPath(thucAn.Coordinates, manHinh);
                    show_button.Text = "Show";

                    vatCan.Draw(g);
                    thucAn.Draw(g);
                }
            }
        }

        private void algorithmtoolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (algorithmtoolStripComboBox.SelectedIndex > -1)
                if (algorithmtoolStripComboBox.SelectedIndex == 0)
                    ranThongMinh.Algorithm = Algorithms.BreadthFirstSearch;
                else
                    ranThongMinh.Algorithm = Algorithms.DepthFirstSearch;
        }

        #region Phần các biến tạm để trang trí chương trình

        bool gameOver;
        int player = 0;
        int computer = 0;
        int MAX_SCORE = 150;
     
        #endregion

        private void tocDo_lable_Click(object sender, EventArgs e)
        {

        }

        private void tocDo_lbl_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
