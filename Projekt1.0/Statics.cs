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
        private Double compressiveForce = 1316.6;
        private Double bendingMomenty = 19.76;
        private Double bendingMomentz = 1.90;
        private Double bendingMomentqpy = 12.67;
        private Double bendingMomentqpz = 1.10;

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

        public Double BendingMomentqpy
        {
            get
            {
                return bendingMomentqpy;
            }
            set
            {
                bendingMomentqpy = value;
                PropertyChanged(this, new PropertyChangedEventArgs("BendingMomentqpy"));
            }
        }

        public Double BendingMomentqpz
        {
            get
            {
                return bendingMomentqpz;
            }
            set
            {
                bendingMomentqpz = value;
                PropertyChanged(this, new PropertyChangedEventArgs("BendingMomentqpz"));
            }
        }


    }
}
