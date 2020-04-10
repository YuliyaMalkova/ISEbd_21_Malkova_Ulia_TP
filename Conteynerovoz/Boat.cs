using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormCars
{
    public class Boat : Vehicle
    {
        protected const int carWidth = 250;
        protected const int carHeight = 120;
        public Boat(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public Boat(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > 20)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 30)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)

                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawCar(Graphics g)
        {
            Pen pen = new Pen(MainColor);      
            Brush br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX, _startPosY + 70, 150, 30);
            g.FillRectangle(br, _startPosX + 150, _startPosY + 50, 70, 50);
            for (float m = _startPosX + 220; m < _startPosX + 240; m++)
            {
                g.DrawLine(pen, m, _startPosY + 50, _startPosX + 220, _startPosY + 100);
            }
            for (float m = _startPosX - 20; m <= _startPosX; m++)
            {
                g.DrawLine(pen, m, _startPosY + 70, _startPosX, _startPosY + 100);
            }
            Brush brRed = new SolidBrush(Color.Red);
            g.FillRectangle(brRed, _startPosX + 130, _startPosY + 50, 20, 20);
            g.FillRectangle(brRed, _startPosX + 90, _startPosY + 50, 20, 20);
            g.FillRectangle(brRed, _startPosX + 110, _startPosY + 30, 20, 20);
            Brush brGr = new SolidBrush(Color.Green);
            g.FillRectangle(brGr, _startPosX + 90, _startPosY + 30, 20, 20);
            g.FillRectangle(brGr, _startPosX + 110, _startPosY + 50, 20, 20);
            Brush brWh = new SolidBrush(Color.White);
            g.FillRectangle(brWh, _startPosX, _startPosY + 10, 50, 60);
            g.FillRectangle(br, _startPosX, _startPosY, 70, 10);
            g.DrawLine(pen, _startPosX, _startPosY + 10, _startPosX, _startPosY + 70);
            g.DrawLine(pen, _startPosX + 50, _startPosY + 10, _startPosX + 50, _startPosY + 70);
        }
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
    }
}
