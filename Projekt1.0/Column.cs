using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekt1._0
{
    class Column : INotifyPropertyChanged
    {
        private CrossSectionCharacteristic crossSectionCharacteristic = new CrossSectionCharacteristic();
        private Statics statics = new Statics();
        private Concrete concrete = new Concrete();
        private Steel steel = new Steel();
        private MaterialParametersCommand materialParametersCommand = new MaterialParametersCommand();
        //private CheckEccentricity checkEccentricity = new CheckEccentricity();

        public event PropertyChangedEventHandler PropertyChanged;

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

        public Steel Steel

        {
            get
            {
                return steel;
            }
            set
            {
                steel = value;
            }
        }


        //public CheckEccentricity CheckEccentricity

        //{
        //    get
        //    {
        //        return checkEccentricity;
        //    }
        //    set
        //    {
        //        checkEccentricity = value;
        //    }
        //}


        public ICommand ViewMaterialParameters
        {
            get
            {
                return materialParametersCommand;
            }
        }

        void InputPropertyChangedEventChandler (object sender, PropertyChangedEventArgs e )
        {
            PropertyChanged(sender, e);
        }
    }
}
