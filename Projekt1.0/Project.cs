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

        private BasicCalculations basicCalculations;
        private ReinforcementDetailsCommand reinforcementDetails = new ReinforcementDetailsCommand();
        private SecondOrderCalculations secondOrderCalculations; 


        public Project() //konstruktor
        {
            column.PropertyChanged += ColumnPropertyChangedEventHandler; //nasłuchiwanie
            basicCalculations = new BasicCalculations(this);
            secondOrderCalculations = new SecondOrderCalculations(this);
        }

        public Column Column
        {
            get
            {
                return column;
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
            basicCalculations.Calculate(this);
            secondOrderCalculations.Calculate(this);
        }
    }

}
