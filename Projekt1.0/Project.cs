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
        private ReinforcementDetailsCommand reinforcementDetails = new ReinforcementDetailsCommand();
        private SecondOrderCalculations secondOrderCalculations;
        //private EnvironmentalConditionCalculation environmentalConditionCalculation;
        //private LoadCapacityCalculation loadCapacityCalculation;
        //private BiaxialBendingCalculation biaxialBendingCalculation;

        public Project()
        {
            column.PropertyChanged += ColumnPropertyChangedEventHandler;
            concreteCoverMinDurCalculation = new ConcreteCoverMinDurCalculation(this);
            basicCalculations = new BasicCalculations(this);
            secondOrderCalculations = new SecondOrderCalculations(this);
            //environmentalConditionCalculation = new EnvironmentalConditionCalculation(this);
            //    loadCapacityCalculation = new LoadCapacityCalculation(this);
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

        //public EnvironmentalConditionCalculation EnvironmentalConditionCalculation
        //{
        //    get
        //    {
        //        return environmentalConditionCalculation;
        //    }
        //}

        //public LoadCapacityCalculation LoadCapacityCalculation
        //{
        //    get
        //    {
        //        return loadCapacityCalculation;
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
            //environmentalConditionCalculation.Calculate(this);
            //    loadCapacityCalculation.Calculate(this);
            //    biaxialBendingCalculation.Calculate(this);
        }
    }

}
