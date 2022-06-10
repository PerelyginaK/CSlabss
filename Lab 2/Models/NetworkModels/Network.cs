using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkModels
{
    public class Network
    {
        public Network(string name, int count, double distance)
        {
            Name = name;
            Count = count;
            Distance = distance;
        }
        public string Name { get; set; }
        public int Count { get; set; }
        public double Distance { get; set; }

        public virtual double Quality() => Count * Distance;
        public override string ToString()
        {
            return $"Название организации: {Name}\n Число рабочих станций: {Count}\n" +
                $" Среднее расстояние между станциями {Distance}м.\n Качество: {Quality()}\n";
        }

    }
}
