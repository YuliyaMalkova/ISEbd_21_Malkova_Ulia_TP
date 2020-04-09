﻿using System;
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
    public partial class FormConteynerovoz : Form
    {
        private Conteynerovoz car;
        public FormConteynerovoz()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCars.Width, pictureBoxCars.Height);
            Graphics gr = Graphics.FromImage(bmp);
            car.DrawCar(gr);
            pictureBoxCars.Image = bmp;
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            car = new Conteynerovoz(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.White, true, true, true);
            car.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCars.Width, pictureBoxCars.Height);
            Draw();

        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    car.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    car.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    car.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    car.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
