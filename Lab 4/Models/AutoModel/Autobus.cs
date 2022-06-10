using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoModel
{
    public class Autobus : PublicTransport
    {
        public int MaxCapacity { get; set; }
        public override void Repair()
        {
            if (Condition < 100)
                Condition += 10;

            if (Condition >= 100)
                Condition = 100;
        }

        public void UpCapacity(int count)
        {
            MaxCapacity += count;
        }

        public void DownCapacity(int count)
        {
            MaxCapacity -= count;
            if (MaxCapacity < 0)
                MaxCapacity = 0;
        }
    }
}
