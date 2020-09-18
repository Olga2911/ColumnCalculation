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
        private ConcreteCoverMinDur concreteCoverMinDur = new ConcreteCoverMinDur();
        private EnvironmentalCondition environmentalCondition = new EnvironmentalCondition();
        private Diameters diameters = new Diameters();
        private ConcreteCoverParameters concreteCoverParameters = new ConcreteCoverParameters();
        private SecondOrderParameters secondOrderParameters = new SecondOrderParameters();
        private LoadCapacityParameters loadCapacityParameters = new LoadCapacityParameters();


        private ConcreteParametersCommand materialParametersCommand = new ConcreteParametersCommand();
        private SteelParametersCommand steelParametersCommand = new SteelParametersCommand();
        private ConcreteCoverCommand concreteCoverCommand = new ConcreteCoverCommand();
        private StructuralClassCommand structuralClassCommand = new StructuralClassCommand();
        private ExposureClassCommand exposureClassCommand = new ExposureClassCommand();
        private EnvironmentalClassCommand environmentalClassCommand = new EnvironmentalClassCommand();
        private MiParameterInformationCommand miParameterInformationCommand = new MiParameterInformationCommand();
        private RMParameterInformationCommand rMParameterInformationCommand = new RMParameterInformationCommand();
        private KSParameterInformationCommand kSParameterInformationCommand = new KSParameterInformationCommand();
        private C0ParameterInformationCommand c0ParameterInformationCommand = new C0ParameterInformationCommand();
        private AParameterCommand aParameterCommand = new AParameterCommand();

        public event PropertyChangedEventHandler PropertyChanged;

        public Column () //konstruktor klasy
        {
            dimension.PropertyChanged += InputPropertyChangedEventChandler;
            statics.PropertyChanged += InputPropertyChangedEventChandler;
            concrete.PropertyChanged += InputPropertyChangedEventChandler;
            steel.PropertyChanged += InputPropertyChangedEventChandler;
            concreteCoverMinDur.PropertyChanged += InputPropertyChangedEventChandler;
            environmentalCondition.PropertyChanged += InputPropertyChangedEventChandler;
            diameters.PropertyChanged += InputPropertyChangedEventChandler;
            concreteCoverParameters.PropertyChanged += InputPropertyChangedEventChandler;
            secondOrderParameters.PropertyChanged += InputPropertyChangedEventChandler;
            loadCapacityParameters.PropertyChanged += InputPropertyChangedEventChandler;
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

        public ConcreteCoverMinDur ConcreteCoverMinDur

        {
            get
            {
                return concreteCoverMinDur;
            }
            set
            {
                concreteCoverMinDur = value;
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

        public SecondOrderParameters SecondOrderParameters

        {
            get
            {
                return secondOrderParameters;
            }
            set
            {
                secondOrderParameters = value;
            }
        }

        public LoadCapacityParameters LoadCapacityParameters

        {
            get
            {
                return loadCapacityParameters;
            }
            set
            {
                loadCapacityParameters = value;
            }
        }

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

        public ICommand ConcreteCover
        {
            get
            {
                return concreteCoverCommand;
            }
        }

        public ICommand StructuralClassParameters
        {
            get
            {
                return structuralClassCommand;
            }
        }

        public ICommand ExposureClassParameters
        {
            get
            {
                return exposureClassCommand;
            }
        }

        public ICommand EnvironmentalClassParameters
        {
            get
            {
                return environmentalClassCommand;
            }
        }

        public ICommand MiParameterInformation
        {
            get
            {
                return miParameterInformationCommand;
            }
        }

        public ICommand RMParameterInformation
        {
            get
            {
                return rMParameterInformationCommand;
            }
        }

        public ICommand KSParameterInformation
        {
            get
            {
                return kSParameterInformationCommand;
            }
        }

        public ICommand C0ParameterInformation
        {
            get
            {
                return c0ParameterInformationCommand;
            }
        }

        public ICommand AParameter
        {
            get
            {
                return aParameterCommand;
            }
        }

        void InputPropertyChangedEventChandler (object sender, PropertyChangedEventArgs e )
        {
            PropertyChanged(sender, e);
        }
    }
}
