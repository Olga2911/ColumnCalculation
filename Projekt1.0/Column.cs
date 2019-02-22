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
        private Statics statics = new Statics();
        private Calculate calculate = new Calculate();
        private Concrete concrete = new Concrete();


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

        public Statics Statics
        {
            get
            {
                return statics;
            }
            set
            {
                statics = value;
            }
        }

        public Concrete Concrete

        {
            get
            {
                return concrete;
            }
            set
            {
                concrete = value;
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
