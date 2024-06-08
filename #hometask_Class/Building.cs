using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _hometask_Class
{
    public class Building
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Area { get; set; }
        public string Address { get; set; }

        public string GetBuildingInfo()
        {
            double volume = Height * Area;
            return $"Name: {Name}, Height: {Height}, Area: {Area}, Address: {Address}, Volume: {volume}";
        }
    }
}
