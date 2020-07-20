using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class ConcreteCoverParameters : INotifyPropertyChanged

    {
        private Double deltacdev = 10;
        private Double cminb = 16;
        //private Double cmindur = 10;
        private Double cdurgamma = 0;
        private Double deltacdurst = 0;
        private Double deltacduradd= 0;


        public event PropertyChangedEventHandler PropertyChanged;


        public double Deltacdev
        {
            get
            {
                return deltacdev;
            }
            set
            {
                if (value > 0)
                {
                    deltacdev = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Deltacdev"));
                }
            }
        }

        public double Cminb
        {
            get
            {
                return cminb;
            }
            set
            {
                if (value > 0)
                {
                    cminb = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Cminb"));
                }
            }
        }

        //public double Cmindur
        //{
        //    get
        //    {
        //        return cmindur;
        //    }
        //    set
        //    {
        //        if (value > 0)
        //        {
        //            cmindur = value;
        //            PropertyChanged(this, new PropertyChangedEventArgs("Cmindur"));
        //        }
        //    }
        //}

        public double Cdurgamma
        {
            get
            {
                return cdurgamma;
            }
            set
            {
                if (value > 0)
                {
                    cdurgamma = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Cdurgamma"));
                }
            }
        }

        public double Deltadurst
        {
            get
            {
                return deltacdurst;
            }
            set
            {
                if (value > 0)
                {
                    deltacdurst = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Deltacdurst"));
                }
            }
        }

        public double Deltacduradd
        {
            get
            {
                return deltacduradd;
            }
            set
            {
                if (value > 0)
                {
                    deltacduradd = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Deltaduradd"));
                }
            }
        }



    }
}
