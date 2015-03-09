using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Ball
    {
        Size size = new Size(15, 15);
        Point location = new Point(0,0);
        Panel context;
        const int velocity = 10;
        Point speed = new Point(velocity, velocity);
        public Ball(Panel context) 
        {
            this.context = context;
        }

        public void draw(Graphics g) 
        {
            move();
        g.FillEllipse(Brushes.Red, new Rectangle(location, size));

        }

        private void move()
        {
            if(location.X+speed.X>=context.Width - size.Width) speed.X=-velocity;
            if (location.Y + speed.Y >= context.Height - size.Height) speed.Y = -velocity;
            if (location.X + speed.X <= 0) speed.X = velocity;
            if (location.Y + speed.Y <= 0) speed.Y = velocity;
               
                location.Offset(speed);
        }
    }
}
