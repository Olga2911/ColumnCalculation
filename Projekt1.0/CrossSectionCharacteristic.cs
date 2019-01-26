using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class CrossSectionCharacteristic
    {
        public double b
        {
            get;
            set;

        }
        public double h
        {
            get;
            set;

        }

        public double a
        {
            get
            {
                return h * b;
            }
        }



    }
}


 