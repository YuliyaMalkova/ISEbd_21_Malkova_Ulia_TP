﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormCars
{
    public class Parking<T> where T : class, IConteynerovoz
    {
        private T[] _places;
        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }
private const int _placeSizeWidth = 310;
        private const int _placeSizeHeight = 150;
        public Parking(int sizes, int pictureWidth, int pictureHeight)
        {
            _places = new T[sizes];
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i] = null;
            }
        }
        public static int operator +(Parking<T> p, T car)
        {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places[i] = car;
                    p._places[i].SetPosition(20 + i / 3 * _placeSizeWidth + 3,
                    i % 3 * _placeSizeHeight + 35, p.PictureWidth, p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }
        public static T operator -(Parking<T> p, int index)
        {
            if (index < 0 || index > p._places.Length)
            {
                return null;
            }
            if (!p.CheckFreePlace(index))
                
        {
                T car = p._places[index];
                p._places[index] = null;
                return car;
            }
            return null;
        }
        private bool CheckFreePlace(int index)
        {
            return _places[index] == null;
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                if (!CheckFreePlace(i))
                {
                    _places[i].DrawCar(g);
                }
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (_places.Length / 3) * _placeSizeWidth, 480);
            for (int i = 0; i < _places.Length / 3; i++)
            {
                for (int j = 0; j < 3; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                    i * _placeSizeWidth + 110, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }
    }
}
