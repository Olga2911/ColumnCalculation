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
        //private EnvironmentalConditionCalculation environmentalConditionCalculation;
        //private BiaxialBendingCalculation biaxialBendingCalculation;

        private ReinforcementDetailsCommand reinforcementDetails = new ReinforcementDetailsCommand();

        public Project()
        {
            column.PropertyChanged += ColumnPropertyChangedEventHandler;
            concreteCoverMinDurCalculation = new ConcreteCoverMinDurCalculation(this);
            basicCalculations = new BasicCalculations(this);
            secondOrderCalculations = new SecondOrderCalculations(this);
            loadCapacityCalculation = new LoadCapacityCalculation(this);
            niChecking = new NiChecking(this);
            //environmentalConditionCalculation = new EnvironmentalConditionCalculation(this);
            //    biaxialBendingCalculation = new BiaxialBendingCalculation(this);
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

        //public EnvironmentalConditionCalculation EnvironmentalConditionCalculation
        //{
        //    get
        //    {
        //        return environmentalConditionCalculation;
        //    }
        //}

        //public BiaxialBendingCalculation BiaxialBendingCalculation
        //{
        //    get
        //    {
        //        return biaxialBendingCalculation;
        //    }
        //}

        public ICommand ReinforcementDetailsView
        {
            get
            {
                return reinforcementDetails;
            }
        }


        void ColumnPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
        {
            Calculate();
        }

        void Calculate()
        {
            concreteCoverMinDurCalculation.Calculate(this);
            basicCalculations.Calculate(this);
            secondOrderCalculations.Calculate(this);
            loadCapacityCalculation.Calculate(this);
            niChecking.Calculate(this);
            //environmentalConditionCalculation.Calculate(this);
            //    biaxialBendingCalculation.Calculate(this);
        }
    }

}
