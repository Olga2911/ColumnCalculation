using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
    {
    class Dimension : INotifyPropertyChanged 

    {
        private Double width = 35;
        private Double height = 35;
        private Double columnHeight = 390;
        private Double s = 100;

        public event PropertyChangedEventHandler PropertyChanged;


        public double Width

        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                {
                    width = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Width"));
                }
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Height"));
                }
            }

        }

        public double ColumnHeight
        {
            get
            {
                return columnHeight;
            }
            set
            {
                if (value > 0)
                {
                    columnHeight = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("ColumnHeight"));
                }
            }
        }

        public double S
        {
            get
            {
                return s;
            }
            set
            {
                if (value > 0)
                {
                    s = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("S"));
                }
            }
        }

    }
}


 