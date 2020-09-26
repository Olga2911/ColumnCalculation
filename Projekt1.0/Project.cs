﻿using System;
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
            iterationNi();
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
            //column.SecondOrderParameters.NiY = 1.01;
            Calculate();
        }

        void Calculate()
        {
            concreteCoverMinDurCalculation.Calculate(this);
            basicCalculations.Calculate(this);
            secondOrderCalculations.Calculate(this);
            loadCapacityCalculation.Calculate(this);
            niChecking.Calculate(this);
            iterationNi();
            //environmentalConditionCalculation.Calculate(this);
            //    biaxialBendingCalculation.Calculate(this);
        }

        void Calculate2()
        {
            concreteCoverMinDurCalculation.Calculate(this);
            basicCalculations.Calculate(this);
            secondOrderCalculations.Calculate(this);
            loadCapacityCalculation.Calculate(this);
            niChecking.Calculate(this);
            //environmentalConditionCalculation.Calculate(this);
            //    biaxialBendingCalculation.Calculate(this);
        }

        private void iterationNi()
        {
            if (column.SecondOrderParameters.NiY != 1.0)
            {
                while (Math.Abs((column.SecondOrderParameters.NiY - niChecking.NiY2) / niChecking.NiY2) > 0.05)
                {
                    column.SecondOrderParameters.NiY = column.SecondOrderParameters.NiY + 0.05;
                    Calculate2();
                }
            }
            // TYLKO TUTAJ MUSISZ DOPISAĆ SPRAWDZENIE NA Y !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // if...
        }
    }
}
