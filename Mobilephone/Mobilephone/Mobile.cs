using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilephone 
{
    internal abstract class Mobile : ICloneable
    {
        public int Memory { get; set; }

        public int Storage { get; set; }

        public double ScreenSize { get; set; }

        private ConsoleColor color;

       
        public void SetColor(ConsoleColor color)
        {
            this.color = color;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return String.Format($"memory:{this.Memory}, storage: {this.Storage}, screensize: {this.ScreenSize}, color: {this.color}");
        }
    }
}
