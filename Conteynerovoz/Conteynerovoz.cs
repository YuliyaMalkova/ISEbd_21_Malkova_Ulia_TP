using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormCars
{
    public class Conteynerovoz : Boat, IComparable<Conteynerovoz>, IEquatable<Conteynerovoz>
    {
        public Color DopColor { private set; get; }
        public bool Cran { private set; get; }
        public bool Anchor { private set; get; }
        public bool Flag { private set; get; }
        private int _countLines;
        public int CountLines { set { if (value > 0 && value < 4) _countLines = value; } get { return _countLines; }
        }
        public Conteynerovoz(int maxSpeed, float weight, Color mainColor, Color dopColor, bool cran, bool anchor, bool flag) :
            base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Cran = cran;
            Anchor = anchor;
            Flag = flag;
            Random rnd = new Random();
            CountLines = rnd.Next(1, 4);
        }
        public Conteynerovoz(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Cran = Convert.ToBoolean(strs[4]);
                Flag = Convert.ToBoolean(strs[5]);
                Anchor = Convert.ToBoolean(strs[6]);
            }
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
                Pen penWh = new Pen(DopColor);
                g.DrawLine(penWh, _startPosX, _startPosY + 80, _startPosX, _startPosY + 110);
                g.DrawLine(penWh, _startPosX - 5, _startPosY + 95, _startPosX + 5, _startPosY + 95);
                g.DrawArc(penWh, _startPosX - 10, _startPosY + 100, 20, 10, 0, 180);
            }
            if (Flag)
            {
                Pen penWh = new Pen(DopColor);
                g.DrawLine(penWh, _startPosX + 220, _startPosY + 20, _startPosX + 220, _startPosY + 50);
                for (float m = _startPosY + 20; m < _startPosY + 30; m++)
                {
                    g.DrawLine(penWh, _startPosX + 210, _startPosY + 25, _startPosX + 220, m);
                }
            }
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Flag + ";" + Anchor + ";" + Cran;
        }
        public int CompareTo(Conteynerovoz other)
        {
            var res = (this is Boat).CompareTo(other is Boat);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Anchor != other.Anchor)
            {
                return Anchor.CompareTo(other.Anchor);
            }
            if (Cran != other.Cran)
            {
                return Cran.CompareTo(other.Cran);
            }
            if (Flag != other.Flag)
            {
                return Flag.CompareTo(other.Flag);
            }
            return 0;
        }
        public bool Equals(Conteynerovoz other)
        {
            var res = (this as Boat).Equals(other as Boat);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Anchor != other.Anchor)
            {
                return false;
            }
            if (Cran != other.Cran)
            {
                return false;
            }
            if (Flag != other.Flag)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Conteynerovoz carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
