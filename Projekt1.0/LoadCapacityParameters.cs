using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class LoadCapacityParameters : INotifyPropertyChanged
    {
        private Double ni = 1.0;
        private Double lambda = 0.8;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Ni
        {
            get
            {
                return ni;
            }
            set
            {
                if (value > 0)
                {
                    ni= value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Ni"));
                }
            }
        }

        public double Lambda
        {
            get
            {
                return lambda;
            }
            set
            {
                if (value > 0)
                {
                    lambda = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Lambda"));
                }
            }
        }



    }
}
