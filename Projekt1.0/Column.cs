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
        private Dimension dimension = new Dimension();
        private Statics statics = new Statics();
        private Concrete concrete = new Concrete();
        private Steel steel = new Steel();
        private Diameters diameters = new Diameters();
        private ConcreteParametersCommand materialParametersCommand = new ConcreteParametersCommand();
        private SteelParametersCommand steelParametersCommand = new SteelParametersCommand();

        //private CheckEccentricity checkEccentricity = new CheckEccentricity();

        public event PropertyChangedEventHandler PropertyChanged;

        public Column () //konstruktor klasy
        {
            dimension.PropertyChanged += InputPropertyChangedEventChandler;
            statics.PropertyChanged += InputPropertyChangedEventChandler;
            concrete.PropertyChanged += InputPropertyChangedEventChandler;
            steel.PropertyChanged += InputPropertyChangedEventChandler;
            diameters.PropertyChanged += InputPropertyChangedEventChandler;
            //materialParametersCommand.PropertyChanged += InputPropertyChangedEventChandler;
            //steelParametersCommand.PropertyChanged += InputPropertyChangedEventChandler;
            //wymienić wszystkie klasy
        }

        public Dimension Dimension
        {
            get
            {
                return dimension;
            }
            set
            {
                dimension = value;
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

        public Diameters Diameters

        {
            get
            {
                return diameters;
            }
            set
            {
                diameters = value;
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
        public ICommand ViewSteelParameters
        {
            get
            {
                return steelParametersCommand;
            }
        }

        void InputPropertyChangedEventChandler (object sender, PropertyChangedEventArgs e )
        {
            PropertyChanged(sender, e);
        }
    }
}
