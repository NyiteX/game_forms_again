using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        Point p;
        Thread thread;
        Graphics g,g2;
        Image player;
        List<platform>platforms = new List<platform>();
        int startpos = 400;      
        int speed_jump = 0;
        bool onGround = false;
        bool f = true;
        int x = 175;
        int y = 220;
        int lives = 3;
        public Form1()
        {
            InitializeComponent();
            Init();
            Paint += new PaintEventHandler(Painta);

            player = Image.FromFile("fruit2.png");           
            Image part = new Bitmap(x, y);
            g = Graphics.FromImage(part);
            g.DrawImage(player, 0, 0, new Rectangle(new Point(70, 50), new Size(x, y)), GraphicsUnit.Pixel);

            PB_Player.Image = part;
            PB_Player.SizeMode = PictureBoxSizeMode.StretchImage;           
            
        }
        //platforms
        //
        private void AddPlatform(PointF position)
        {
            platform platform = new platform(position);
            platforms.Add(platform);
        }
        private void GenStartPlatforms()
        {
            Random r = new Random();
            for (int i = 0; i < 15; i++)
            {
                int x = r.Next(0, 670);
                int y = r.Next(30,60);
                startpos -= y;
                PointF position = new PointF(x, startpos);
                AddPlatform(position);
            }
        }
        private void GenRandomplatforms()
        {
            Random r = new Random();
            int x = r.Next(0,570);
            startpos = 0;
            PointF position = new PointF(x, startpos);

            AddPlatform(position);
        }
        private void ClearPlatforms()
        {
            for (int i = 0; i < platforms.Count; i++)
            {
                if (platforms[i].transform.pos.Y > 700)
                    platforms.RemoveAt(i);
            }
        }
        //
        //Map
        private void Init()
        {
            AddPlatform(new PointF(100, 400));
            startpos = 400;
            GenStartPlatforms();           
        }
        private void umap()
        {
            //thread = new Thread(() =>
            //{
            //    while (true)
            //    {
            //        for (int i = 0; i < map.GetLength(0); i++)
            //        {
            //            for (int j = 0; j < map.GetLength(1); j++)
            //            {
            //                //if (map[i, j] == 0)
            //                //{
            //                //    g2.DrawImage(sky, j * x1, i * y1, new Rectangle(new Point(0, 0), new Size(x1, y1)), GraphicsUnit.Pixel);
            //                //}
            //                if (map[i, j] == 1)
            //                {
            //                    g2.DrawImage(grass, j * x1, i * y1, new Rectangle(new Point(0, 0), new Size(x1, y1)), GraphicsUnit.Pixel);
            //                }
            //                else if (map[i, j] == 2)
            //                {
            //                    g2.DrawImage(line, j * x1, i * y1, new Rectangle(new Point(0, 0), new Size(x1, y1)), GraphicsUnit.Pixel);
            //                }
                            
            //            }
            //        }
            //    }
            //});
            //thread.SetApartmentState(ApartmentState.STA);
            //thread.Start();
        }
        private void update_map()
        {
            thread = new Thread(() =>
            {
                while(true)
                {
                    ClearPlatforms();
                    if (platforms.Count < 15)
                        GenRandomplatforms();

                }               
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void Painta(object sender, PaintEventArgs e)
        {
            g2 = e.Graphics;
            if (platforms.Count > 0)
            {
                for (int i = 0; i < platforms.Count; i++)
                {
                    platforms[i].DrawSprite(g2);
                }
            }
        }
        //
        //Basic_Buttons
        private void X_Button_Click(object sender, EventArgs e)
        {
            try
            {
                thread.Abort();
            }
            catch (Exception)  { }
            Close();
        }
        private void minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Minimized;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //umap();
            update_map();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            p = new Point(e.X, e.Y);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - p.X;
                Top += e.Y - p.Y;
            }
        }
        //
        //Timers
        private void timer_up_Tick(object sender, EventArgs e)
        {
            PB_Player.Top -= 15;
            onGround = false;
            f = true;
            Collide();
            if (PB_Player.Bounds.IntersectsWith(PB_Ground.Bounds) || onGround)
            {               
                timer_up.Stop();
            }
        }
        private void timer_left_Tick(object sender, EventArgs e)
        {
            PB_Player.Left += 10;
        }
        private void timer_right_Tick(object sender, EventArgs e)
        {
            PB_Player.Left -= 10;
        }
        private void timer_Gravy_Tick(object sender, EventArgs e)
        {
            onGround = false;
            Collide();
            if (!PB_Player.Bounds.IntersectsWith(PB_Ground.Bounds)&&!onGround)
            {
                PB_Player.Top += speed_jump;
                if (speed_jump < 40)
                    speed_jump += 1;
                //onGround = true;               
            }
            else
            {
                //onGround = false;
                speed_jump = 0;
            }
            if(PB_Player.Bounds.IntersectsWith(PB_Ground.Bounds))
            {
                if (f)
                {
                    lives--;
                    f = false;
                }
            }
        }
        //
        //Movement
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { timer_up.Start(); }
            else if (e.KeyCode == Keys.A) { timer_right.Start(); }
            else if (e.KeyCode == Keys.D) { timer_left.Start(); }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) { timer_right.Stop(); }
            else if (e.KeyCode == Keys.D) { timer_left.Stop(); }
            //else if (e.KeyCode == Keys.Space) { timer_up.Stop(); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lives > 0)
            {
                Graphics g3 = this.CreateGraphics();
                g3.Clear(this.BackColor);
                for (int i = 0; i < platforms.Count; i++)
                {
                    platforms[i].transform.pos.Y += 1;
                    platforms[i].DrawSprite(g3);
                }
                label1.Text = "Lives = " + lives;
            }                
            else
                label1.Text = "YOU LOSE";
        }
        public void Collide()
        {
            for (int i = 0; i < platforms.Count; i++)
            {
                var platform = platforms[i];
                
                if (platform.transform.pos.X + platform.transform.size.Width >= PB_Player.Bounds.X && platform.transform.pos.X + platform.transform.size.Width / 4 <= PB_Player.Bounds.X + PB_Player.Bounds.Width)
                {
                    if (platform.transform.pos.Y + platform.transform.size.Height / 2 >= PB_Player.Bounds.Y + PB_Player.Bounds.Height && platform.transform.pos.Y - platform.transform.size.Height / 2 <= PB_Player.Bounds.Y + PB_Player.Bounds.Height)
                    {
                        onGround = true;
                        break;
                    }
                }
            }
        }
    }
}
