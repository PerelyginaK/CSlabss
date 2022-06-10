using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseModel
{
    public class Door
    {
        public Door()
        {
            IsLocked = false;
            Name = "Дверь стандартная.";
        }
        public bool IsLocked { get; set; } 
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Дверь. Имя: {Name}, Закрыто: {(IsLocked ? "да" : "нет")}";
        }
    }
}
