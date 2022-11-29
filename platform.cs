using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
    internal class platform
    {
        Image sprite;
        public transform transform;
        public int sizex;
        public int sizey;
        public bool istouchedplayer;
        public platform(PointF pos) 
        {
            sprite = Properties.Resources.ButtonExtraWide_Green;
            sizex = 125;
            sizey = 15;
            transform = new transform(pos,new Size(sizex,sizey));
            istouchedplayer = false;
        }
        public void DrawSprite(Graphics g)
        {
            g.DrawImage(sprite,transform.pos.X,transform.pos.Y,transform.size.Width,transform.size.Height);
        }
    }
}
