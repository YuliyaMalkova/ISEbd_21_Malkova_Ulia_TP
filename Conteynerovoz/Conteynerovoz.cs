using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormCars
{
    public class Conteynerovoz : Boat
    {
        public Color DopColor { private set; get; }
        public bool Cran { private set; get; }
        public bool Anchor { private set; get; }
        public bool Conteyner { private set; get; }
        public bool Flag { private set; get; }
        private int _countLines;

        public int CountLines { set { if (value > 0 && value < 4) _countLines = value; } get { return _countLines; } }


        public Conteynerovoz(int maxSpeed, float weight, Color mainColor, Color dopColor, bool cran, bool anchor, bool flag, bool conteyner) :
            base(maxSpeed, weight, mainColor)
        {

            DopColor = dopColor;
            Cran = cran;
            Anchor = anchor;
            Flag = flag;
            Conteyner = conteyner;
            Random rnd = new Random();
            CountLines = rnd.Next(1, 4);
        }
        public override void DrawCar(Graphics g)
        {
            Pen pen = new Pen(MainColor);
            Brush br = new SolidBrush(MainColor);
            base.DrawCar(g);
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
            if (Conteyner)
            {
                Brush brRed = new SolidBrush(Color.Red);
                g.FillRectangle(brRed, _startPosX + 130, _startPosY + 50, 20, 20);
                g.FillRectangle(brRed, _startPosX + 90, _startPosY + 50, 20, 20);
                g.FillRectangle(brRed, _startPosX + 110, _startPosY + 30, 20, 20);

                Brush brGr = new SolidBrush(Color.Green);
                g.FillRectangle(brGr, _startPosX + 90, _startPosY + 30, 20, 20);
                g.FillRectangle(brGr, _startPosX + 110, _startPosY + 50, 20, 20);

            }
        }
    }
}
