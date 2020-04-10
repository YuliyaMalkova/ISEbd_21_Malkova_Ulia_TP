using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormCars
{
    class MultiLevelParking
    {
        List<Parking<IConteynerovoz>> parkingStages;
        private int pictureWidth;
        private int pictureHeight;
        private const int countPlaces = 20;
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<IConteynerovoz>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<IConteynerovoz>(countPlaces, pictureWidth, pictureHeight));
            }
        }
        public Parking<IConteynerovoz> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("CountLevels:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    sw.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var boat = level[i];
                        if (boat != null)
                        {
                            if (boat.GetType().Name == "Boat")
                            {
                                sw.Write(i + ":Boat:");
                            }
                            if (boat.GetType().Name == "Conteynerovoz")
                            {
                                sw.Write(i + ":Conteynerovoz:");
                            }
                            sw.WriteLine(boat);
                        }
                    }
                }
            }
            return true;
        }
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                var strs = sr.ReadLine();
                if (strs.Contains("CountLevels"))
                {
                    int count = Convert.ToInt32(strs.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Parking<IConteynerovoz>>(count);
                }
                else
                {
                    return false;
                }
                int counter = -1;
                IConteynerovoz boat = null;
                while (counter < parkingStages.Count)
                {
                    strs = sr.ReadLine();
                    if (strs == "Level")
                    {
                        counter++;
                        parkingStages.Add(new Parking<IConteynerovoz>(countPlaces, pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(strs))
                    {
                        break;
                    }
                    if (strs.Split(':')[1] == "Boat")
                    {
                        boat = new Boat(strs.Split(':')[2]);
                    }
                    else if (strs.Split(':')[1] == "Conteynerovoz")
                    {
                        boat = new Conteynerovoz(strs.Split(':')[2]);
                    }
                    parkingStages[counter][Convert.ToInt32(strs.Split(':')[0])] = boat;
                }
            }
            return true;
        }
    }
}
