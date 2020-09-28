using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekt1._0
{
    class Project
    {
        private Column column = new Column();

        private ConcreteCoverMinDurCalculation concreteCoverMinDurCalculation;
        private BasicCalculations basicCalculations;
        private SecondOrderCalculations secondOrderCalculations;
        private LoadCapacityCalculation loadCapacityCalculation;
        private NiChecking niChecking;

        public Project()
        {
            column.PropertyChanged += ColumnPropertyChangedEventHandler;
            concreteCoverMinDurCalculation = new ConcreteCoverMinDurCalculation();
            basicCalculations = new BasicCalculations();
            secondOrderCalculations = new SecondOrderCalculations();
            loadCapacityCalculation = new LoadCapacityCalculation();
            niChecking = new NiChecking();
            niChecking.FindNi(this);
        }

        public Column Column
        {
            get
            {
                return column;
            }
        }

        public ConcreteCoverMinDurCalculation ConcreteCoverMinDurCalculation
        {
            get
            {
                return concreteCoverMinDurCalculation;
            }
        }

        public BasicCalculations BasicCalculations
        {
            get
            {
                return basicCalculations;
            }
        }

        public SecondOrderCalculations SecondOrderCalculations
        {
            get
            {
                return secondOrderCalculations;
            }
        }

        public LoadCapacityCalculation LoadCapacityCalculation
        {
            get
            {
                return loadCapacityCalculation;
            }
        }

        public NiChecking NiChecking
        {
            get
            {
                return niChecking;
            }
        }


        void ColumnPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
        {
            niChecking.FindNi(this);
        }

        public void Calculate()
        {
            concreteCoverMinDurCalculation.Calculate(this);
            basicCalculations.Calculate(this);
            secondOrderCalculations.Calculate(this);
            loadCapacityCalculation.Calculate(this);
            niChecking.Calculate(this);
        }
    }
}
