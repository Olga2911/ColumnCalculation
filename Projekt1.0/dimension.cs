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
        private Double width = 40;
        private Double height = 60;
        private Double columnHeight = 250;
        private Double quantity1y = 4;
        private Double quantity2y = 3;
        private Double quantity1z = 2;
        private Double quantity2z = 2;
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

        public double Quantity1y
        {
            get
            {
                return quantity1y;
            }
            set
            {
                if (value > 0)
                {
                    quantity1y = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Quantity1y"));
                }
            }

        }

        public double Quantity2y
        {
            get
            {
                return quantity2y;
            }
            set
            {
                if (value > 0)
                {
                    quantity2y = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Quantity2y"));
                }
            }
        }

        public double Quantity1z
        {
            get
            {
                return quantity1z;
            }
            set
            {
                if (value > 0)
                {
                    quantity1z = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Quantity1z"));
                }
            }
        }

        public double Quantity2z
        {
            get
            {
                return quantity2z;
            }
            set
            {
                if (value > 0)
                {
                    quantity2z = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Quantity2z"));
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
                    s= value;
                    PropertyChanged(this, new PropertyChangedEventArgs("S"));
                }
            }
        }

    }
}


 