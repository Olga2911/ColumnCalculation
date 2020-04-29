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
        private Double columnHeight = 2;
        private Double compressiveForce = 50;
        private Double bendingMoment = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        public Double ColumnHeight
        {
            get
            {
                return columnHeight;
            }
            set
            {
                columnHeight = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ColumnHeight"));
            }
        }

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

        public Double BendingMoment
        {
            get
            {
                return bendingMoment;
            }
            set
            {
                bendingMoment = value;
                PropertyChanged(this, new PropertyChangedEventArgs("BendingMoment"));
            }
        }
    }
}
