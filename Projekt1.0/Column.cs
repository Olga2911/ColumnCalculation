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
        private SectionType sectionType = new SectionType();
        private MaterialParametersCommand materialParametersCommand = new MaterialParametersCommand();
        private CheckEccentricity checkEccentricity = new CheckEccentricity();


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

        public CheckEccentricity CheckEccentricity

        {
            get
            {
                return checkEccentricity;
            }
            set
            {
                checkEccentricity = value;
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
