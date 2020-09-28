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
        private Double compressiveForce = 1200.0;
        private Double bendingMomenty = 60.0;
        private Double bendingMomentz = 8.00;
        private Double bendingMomentqpy = 40.0;
        private Double bendingMomentqpz = 5.0;

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
