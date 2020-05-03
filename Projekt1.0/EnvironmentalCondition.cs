using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class EnvironmentalCondition : INotifyPropertyChanged
    {
        private Double fiKoncowe = 2.5;
        private Double m0eqpm0ed=0.5;

        public event PropertyChangedEventHandler PropertyChanged;

        public double FiKoncowe
        {
            get
            {
                return fiKoncowe;
            }
            set
            {
                if (value > 0)
                {
                    fiKoncowe = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("FiKoncowe"));
                }
            }
        }

        public double M0eqpm0ed
        {
            get
            {
                return m0eqpm0ed;
            }
            set
            {
                if (value > 0)
                {
                    m0eqpm0ed = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("M0eqpm0ed"));
                }
            }
        }




    }
}

