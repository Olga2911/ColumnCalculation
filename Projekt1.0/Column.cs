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
        private EnvironmentalCondition environmentalCondition = new EnvironmentalCondition();
        private Diameters diameters = new Diameters();
        private ConcreteCoverParameters concreteCoverParameters = new ConcreteCoverParameters();
        private ConcreteParametersCommand materialParametersCommand = new ConcreteParametersCommand();
        private SteelParametersCommand steelParametersCommand = new SteelParametersCommand();
        private ConcreteCoverCommand concreteCover = new ConcreteCoverCommand();

        //private CheckEccentricity checkEccentricity = new CheckEccentricity();

        public event PropertyChangedEventHandler PropertyChanged;

        public Column () //konstruktor klasy
        {
            dimension.PropertyChanged += InputPropertyChangedEventChandler;
            statics.PropertyChanged += InputPropertyChangedEventChandler;
            concrete.PropertyChanged += InputPropertyChangedEventChandler;
            steel.PropertyChanged += InputPropertyChangedEventChandler;
            environmentalCondition.PropertyChanged += InputPropertyChangedEventChandler;
            diameters.PropertyChanged += InputPropertyChangedEventChandler;
            concreteCoverParameters.PropertyChanged += InputPropertyChangedEventChandler;

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

        public EnvironmentalCondition EnvironmentalCondition

        {
            get
            {
                return environmentalCondition;
            }
            set
            {
                environmentalCondition = value;
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

        public ConcreteCoverParameters ConcreteCoverParameters

        {
            get
            {
                return concreteCoverParameters;
            }
            set
            {
                concreteCoverParameters = value;
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

        public ICommand ConcreteCoverView
        {
            get
            {
                return concreteCover;
            }
        }

        void InputPropertyChangedEventChandler (object sender, PropertyChangedEventArgs e )
        {
            PropertyChanged(sender, e);
        }
    }
}
