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
        MultiLevelParking parking;
        FormCarConfig form;
        private const int countLevel = 5;
        public FormParking()
        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width, pictureBoxParking.Height); Draw();
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }
           private void buttonSetBoat_Click(object sender, EventArgs e)      
           {
               form = new FormCarConfig();
            form.AddEvent(AddCar);
            form.Show();
           }
           
        private void buttonTakeBoat_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBoxMesto.Text != "")
                {
                    var boat = parking[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxMesto.Text);
                    if (boat != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxtakeboat.Width, pictureBoxtakeboat.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        boat.SetPosition(20, 5, pictureBoxtakeboat.Width, pictureBoxtakeboat.Height);
                        boat.DrawCar(gr);
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
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void AddCar(IConteynerovoz car)
        {
            if (car != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = parking[listBoxLevels.SelectedIndex] + car; if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }
    }
}
