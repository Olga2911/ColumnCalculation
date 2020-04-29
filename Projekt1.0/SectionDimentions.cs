using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
    {
    class SectionDimentions : INotifyPropertyChanged 

    {
        private Double width = 0.3;
        private Double height = 0.5;

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
    }
}


 