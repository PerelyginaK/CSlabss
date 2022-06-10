using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoModel
{
    public class Tram : PublicTransport
    {
        public int MaxSpeed { get; set; }
        public string Color { get; set; }

        public void  Degrade()
        {
            MaxSpeed -= 15;
        }

        public void Update()
        {
            MaxSpeed += 15;
        }

        public override void Repair()
        {
            if (Condition < 100)
                Condition += 15;

            if (Condition >= 100)
                Condition = 100;
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Максимальная скорость: {MaxSpeed}, Цвет: {Color}";
        }

        public Tram()
        {
            Name = "Номер 1772";
            MaxSpeed = 90;
            Color = "Серый";
            Mileage = 20000;
            Condition = 100;
        }
    }
}
