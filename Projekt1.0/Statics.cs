using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class Statics : INotifyPropertyChanged 
    {
        private Double compressiveForce = 1200;
        private Double bendingMomenty = 150;
        private Double bendingMomentz = 30;

        public event PropertyChangedEventHandler PropertyChanged;

        public Double CompressiveForce
        {
            get
            {
                return compressiveForce;
            }
            set
            {
                compressiveForce = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CompressiveForce"));
            }
        }

        public Double BendingMomenty
        {
            get
            {
                return bendingMomenty;
            }
            set
            {
                bendingMomenty = value;
                PropertyChanged(this, new PropertyChangedEventArgs("BendingMomenty"));
            }
        }

        public Double BendingMomentz
        {
            get
            {
                return bendingMomentz;
            }
            set
            {
                bendingMomentz = value;
                PropertyChanged(this, new PropertyChangedEventArgs("BendingMomentz"));
            }
        }

    }
}
