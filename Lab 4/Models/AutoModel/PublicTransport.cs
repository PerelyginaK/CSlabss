using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoModel
{
    public abstract class PublicTransport : IAuto
    {
        public double Mileage { get; set; }
        public double Condition { get; set; }

        public string Name { get; set; } = "";

        public void Drive()
        {
            Condition -= 5;
            Mileage++;
        }
        public abstract void Repair();

        public double Quallity()
        {
            return Condition * Mileage;
        }
    }
}
