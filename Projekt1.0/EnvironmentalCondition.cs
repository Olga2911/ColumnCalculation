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
        private Double fiKoncowe = 2.8;

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

    }
}

