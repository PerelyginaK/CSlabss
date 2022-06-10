using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoModel
{
    internal class Taxi : PublicTransport
    {
        public double Price { get; set; }
        public override void Repair()
        {
            if (Condition < 100)
                Condition += 20;

            if (Condition >= 100)
                Condition = 100;
        }

        public void UpPrice(int count)
        {
            Price += count;
        }

        public void DownPrice(int count)
        {
            Price -= count;
            if (Price < 0)
                Price = 0;
        }
    }
}
