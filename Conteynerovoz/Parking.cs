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
        private Dictionary<int, T> _places;
        private int _maxCount;
        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }
        private const int _placeSizeWidth = 310;
        private const int _placeSizeHeight = 150;
        public Parking(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = 9;
            _places = new Dictionary<int, T>();
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
        }
        public static int operator +(Parking<T> p, T boat)
        {
            if (p._places.Count == p._maxCount)
            {
                throw new ParkingOverflowException();
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places.Add(i, boat);
                    p._places[i].SetPosition(35 + i / 3 * _placeSizeWidth + 5,
                    i % 3 * _placeSizeHeight + 35, p.PictureWidth, p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }
        public static T operator -(Parking<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T car = p._places[index];
                p._places.Remove(index);
                return car;
            }
            throw new ParkingNotFoundException(index);
        }
        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = _places.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                _places[keys[i]].DrawCar(g);
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (_maxCount / 3) * _placeSizeWidth, 480);
            for (int i = 0; i < _maxCount / 3; i++)
            {
                for (int j = 0; j < 3; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                    i * _placeSizeWidth + 110, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }
        public T this[int ind]
        {
            get
            {
                if (_places.ContainsKey(ind))
                {
                    return _places[ind];
                }
                return null;
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].SetPosition(5 + ind / 3 * _placeSizeWidth + 20, ind % 3 * _placeSizeHeight + 29, PictureWidth, PictureHeight);
                }
            }
        }
    }

}
