using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkModels
{
    public class NetworkChild : Network
    {
        public NetworkChild(string name, int count, double distance, double speed) 
            : base(name, count, distance)
        {
            Speed = speed;
        }
        public double Speed { get; set; }

        public override double Quality() => base.Quality() * Speed;

        public override string ToString()
        {
            return $"Название организации: {Name}\n Число рабочих станций: {Count}\n" +
               $" Среднее расстояние между станциями {Distance}м\n" +
               $" Средняя скорость передачи данных в сети {Speed}Мб/c\n Качество: {Quality()}\n";
        }

    }
}
