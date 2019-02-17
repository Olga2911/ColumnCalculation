using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekt1._0
{
    class Column
    {
        private CrossSectionCharacteristic crossSectionCharacteristic = new CrossSectionCharacteristic();
        private Calculate calculate = new Calculate();

        public CrossSectionCharacteristic CrossSectionCharacteristic
        {
            get
            {
                return crossSectionCharacteristic;
            }
            set
            {
                crossSectionCharacteristic = value;
            }
        }

        public ICommand Calculate
        {
            get
            {
                return calculate;
            }
        }


    }
}
