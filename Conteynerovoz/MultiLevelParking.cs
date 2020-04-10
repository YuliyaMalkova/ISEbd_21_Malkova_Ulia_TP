using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormCars
{
    public class MultiLevelParking
    {
        List<Parking<IConteynerovoz>> parkingStages;
        private const int countPlaces = 20;
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<IConteynerovoz>>();
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
    }

}
