using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoModel
{
    public interface IAuto
    {
        public double Mileage { get; set; }
        public void Go();
        public void Repair();
    }
}
