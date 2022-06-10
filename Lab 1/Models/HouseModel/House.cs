using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseModel
{
    public class House
    {
        public List<Door> Doors { get; set; }
        public List<Window> Windows { get; set; }

        public House( )
        {
            Doors = new List<Door>();
            Windows = new List<Window>();
        }

        public void Close()
        {
            foreach (var item in Doors)
            {
                item.IsLocked = true;
            }
        }

        public void Open()
        {
            foreach (var item in Doors)
            {
                item.IsLocked = false;
            }
        }

        public int CountOfDoors()
        {
            return Doors.Count;
        }

        public int CountOfWindow()
        {
            return Windows.Count;
        }

    }
}
