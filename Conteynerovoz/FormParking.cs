using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormCars
{
    public partial class FormParking : Form
    { 
        Parking<IConteynerovoz> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<IConteynerovoz>(20, pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new Boat(100, 1000, dialog.Color);
                int place = parking + car;
                Draw();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var car = new Conteynerovoz(100, 1000, dialog.Color, dialogDop.Color, true, true, true,true);
                    int place = parking + car;
                    Draw();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var car = parking - Convert.ToInt32(maskedTextBox1.Text);
                if (car != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxtakeboat.Width, pictureBoxtakeboat.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    car.SetPosition(25, 35, pictureBoxtakeboat.Width, pictureBoxtakeboat.Height);
                    car.DrawCar(gr);
                    pictureBoxtakeboat.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxtakeboat.Width, pictureBoxtakeboat.Height);
                    pictureBoxtakeboat.Image = bmp;
                }
                Draw();
            }
        }
    }
}
