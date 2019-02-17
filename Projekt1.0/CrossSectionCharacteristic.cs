using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
    {
    class CrossSectionCharacteristic : INotifyPropertyChanged

    {
        private Double width = 0.0;
        private Double height = 0.0;
        private Double areaConcrete = 0.0;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
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
                height = value;
            }

        }

        public double AreaConcrete
        {
            get
            {
                return areaConcrete;
            }
        }

        public void UpdateData()
        {
            areaConcrete = width * height;
            PropertyChanged(this, new PropertyChangedEventArgs("AreaConcrete"));
        }


    }
}


 