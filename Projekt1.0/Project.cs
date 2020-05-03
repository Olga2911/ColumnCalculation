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

        private BasicCalculations basicCalculations; //więcej klas
        private ReinforcementDetailsCommand reinforcementDetails = new ReinforcementDetailsCommand();

        public Project() //konstruktor
        {
            column.PropertyChanged += ColumnPropertyChangedEventHandler; //nasłuchiwanie
            basicCalculations = new BasicCalculations(this);
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
            //wpisać wszystkie metody
        }
    }

}
