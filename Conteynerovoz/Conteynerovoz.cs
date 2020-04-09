using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormCars
{

    class Conteynerovoz
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private const int carWidth = 250;
        private const int carHeight = 120;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public bool Cran { private set; get; }
        public bool Anchor { private set; get; }
        public bool Flag { private set; get; }
        public Conteynerovoz(int maxSpeed, float weight, Color mainColor, Color dopColor, bool cran, bool anchor, bool flag)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Cran = cran;
            Anchor = anchor;
            Flag = flag;
        }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x + 20;
            _startPosY = y + 20;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public void MoveTransport(Direction direction)
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
        public void DrawCar(Graphics g)
        {
            Pen pen = new Pen(MainColor);
            Brush br = new SolidBrush(MainColor); g.FillRectangle(br, _startPosX, _startPosY + 70, 150, 30);
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
            if (Cran)
            {
                Brush spoiler = new SolidBrush(DopColor);
                g.FillRectangle(spoiler, _startPosX + 50, _startPosY - 20, 10, 20);
                g.FillRectangle(spoiler, _startPosX + 50, _startPosY - 30, 35, 10);
                g.DrawRectangle(pen, _startPosX + 50, _startPosY - 20, 10, 20);
                g.DrawRectangle(pen, _startPosX + 50, _startPosY - 30, 35, 10);
                g.DrawLine(pen, _startPosX + 80, _startPosY - 20, _startPosX + 80, _startPosY + 30);
                g.DrawArc(pen, _startPosX + 70, _startPosY + 25, 10, 10, 0, 140);
            }
            if (Anchor)
            {

                Pen penWh = new Pen(Color.Red);
                g.DrawLine(penWh, _startPosX, _startPosY + 80, _startPosX, _startPosY + 110);
                g.DrawLine(penWh, _startPosX - 5, _startPosY + 95, _startPosX + 5, _startPosY + 95);
                g.DrawArc(penWh, _startPosX - 10, _startPosY + 100, 20, 10, 0, 180);
            }
            if (Flag)
            {
                Pen penWh = new Pen(Color.Red);
                g.DrawLine(penWh, _startPosX + 220, _startPosY + 20, _startPosX + 220, _startPosY + 50);
                for (float m = _startPosY + 20; m < _startPosY + 30; m++)
                {
                    g.DrawLine(pen, _startPosX + 210, _startPosY + 25, _startPosX + 220, m);
                }
            }
        }
    }
}
