using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseModel
{
    public class Window
    {
        public Window()
        {
            IsLocked = false;
            Name = "Окно пластиковое.";
        }
        public bool IsLocked { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Окно. Имя: {Name}, Закрыто: {(IsLocked ? "да" : "нет")}";
        }
    }
}
