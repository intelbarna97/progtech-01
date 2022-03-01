using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilephone
{
    internal class MobileFactory : Mobile
    {
        private Mobile prototype;

        public void SetPrototype(Mobile prototype)
        { this.prototype = prototype; }

        public Mobile Produce(ConsoleColor color)
        {
            Mobile mobile = (Mobile)prototype.Clone();
            mobile.SetColor(color);
            return mobile;
        }
    }
}
