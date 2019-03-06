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
        private static  CrossSectionCharacteristic crossSectionCharacteristic = new CrossSectionCharacteristic();
        private static Statics statics = new Statics();
        private static Calculate calculate = new Calculate();
        private static Concrete concrete = new Concrete();
        private static SectionType sectionType = new SectionType();
        private static MaterialParametersCommand materialParametersCommand = new MaterialParametersCommand();


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

        public SectionType SectionType

        {
            get
            {
                return sectionType;
            }
            set
            {
                sectionType = value;
            }
        }

        public ICommand Calculate
        {
            get
            {
                return calculate;
            }
        }

        public ICommand ViewMaterialParameters
        {
            get
            {
                return materialParametersCommand;
            }
        }

    }
}
