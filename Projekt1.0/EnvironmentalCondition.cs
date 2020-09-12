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
        //private Double m0eqpm0edy=0;
        //private Double m0eqpm0edz = 0;

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

        //public double M0eqpm0edy
        //{
        //    get
        //    {
        //        return m0eqpm0edy;
        //    }
        //    set
        //    {
        //        if (value > 0)
        //        {
        //            m0eqpm0edy = value;

        //            PropertyChanged(this, new PropertyChangedEventArgs("M0eqpm0edy"));
        //        }
        //    }
        //}

        //public double M0eqpm0edz
        //{
        //    get
        //    {
        //        return m0eqpm0edz;
        //    }
        //    set
        //    {
        //        if (value > 0)
        //        {
        //            m0eqpm0edz = value;
        //            PropertyChanged(this, new PropertyChangedEventArgs("M0eqpm0edz"));
        //        }
        //    }
        //}



    }
}

