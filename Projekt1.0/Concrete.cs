using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class Concrete : INotifyPropertyChanged

    {
        private ConcreteClasses concreteClasses = ConcreteClasses.C20;
        private Double fck = 20.0;
        private Double gammaF = 1.4;
        private Double fcd = 0.0;

        public event PropertyChangedEventHandler PropertyChanged;

        public ConcreteClasses ConcreteClass
        {
            get
            {
                return concreteClasses;
            }
            set
            {
                concreteClasses = value;
            }
        }

        

        public void UpdateData()
        {

            fcd = fck / gammaF;

       

        }

        public enum ConcreteClasses
        {
            C1615, C20, C25, C30, C35, C40
        }
            

    }
}
