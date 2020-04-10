﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using NLog;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormCars
{

    public partial class FormParking : Form
    {
        MultiLevelParking parking;
        FormCarConfig form;
        private const int countLevel = 5;
        private Logger logger;
        private Logger exception;
        public FormParking()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            exception = LogManager.GetCurrentClassLogger();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width, pictureBoxParking.Height);
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
        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBoxMesto.Text != "")
                {
                    try
                    {
                        var boat = parking[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxMesto.Text);
                        Bitmap bmp = new Bitmap(pictureBoxtakeboat.Width, pictureBoxtakeboat.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        boat.SetPosition(10, 5, pictureBoxtakeboat.Width, pictureBoxtakeboat.Height);
                        boat.DrawCar(gr);
                        pictureBoxtakeboat.Image = bmp;
                        logger.Info("Изъят трактор " + boat.ToString() + " с места " + maskedTextBoxMesto.Text);
                        Draw();
                    }
                    catch (ParkingNotFoundException ex)
                    {
                        exception.Debug(ex.Message);
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxtakeboat.Width, pictureBoxtakeboat.Height);
                        pictureBoxtakeboat.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        exception.Debug(ex.Message);
                        MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void AddCar(IConteynerovoz boat)
        {
            if (boat != null && listBoxLevels.SelectedIndex > -1)
            {
                try
                {
                    int place = parking[listBoxLevels.SelectedIndex] + boat;
                    logger.Info("Добавлен трактор " + boat.ToString() + " на место " + place);
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    exception.Debug(ex.Message);
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    exception.Debug(ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            form = new FormCarConfig();
            form.AddEvent(AddCar);
            form.Show();
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                parking.SaveData(saveFileDialog1.FileName);
                MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logger.Info("Сохранено в файл " + saveFileDialog1.FileName);
            }
            catch (Exception ex)
            {
                exception.Debug(ex.Message);
                MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    parking.LoadData(openFileDialog1.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    exception.Debug(ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }


        private void сохранитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно",
                        "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void загрузитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                Draw();
            }
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
