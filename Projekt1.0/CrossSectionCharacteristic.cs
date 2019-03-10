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
        private Double width = 0.3;
        private Double height = 0.5;
        private Double diameter = 0.4;
        private int countAs1 = 4;
        // fi [mm]
        private int fiAs1 = 12;
        //cover [m]
        private Double cover = 0.04;
        private Double areaConcrete = 0.0;
        private Double areaAs1 = 0.0;
        private Double aReiforcement = 0.0;
        
        public event PropertyChangedEventHandler PropertyChanged;

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value>0)
                {
                    width = value;
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
                }
                    
            }

        }

        public double Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                if (value > 0)
                {
                    diameter = value;
                }

            }

        }

        public double AreaConcrete
        {
            get
            {
                return areaConcrete;
            }
        }

        public int CountAs1
        {
            get
            {
                return countAs1;
            }
            set

            {
                if (value > 0)
                {
                countAs1 = value;
                }
                  
            }
        }

        public double AreaAs1
        {
            get
            {
                return areaAs1;
            }
        }

        public int FiAs1
        {
            get
            {
                return fiAs1;
            }
            set
            {
               if (value>0)
                {
                    fiAs1 = value;
                }
                
            }
        }

        public Double Cover
        {
            get
            {
                return cover;
            }
            set
            {
                if (value > 0)
                {
                    cover = value;
                }

            }
        }

        public Double AReinforcement
        {
            get
            {
                return aReiforcement;
            }
        }

        public void UpdateData(Boolean isProstokatny)
        {
            Calculate(isProstokatny );
            PropertyChanged(this, new PropertyChangedEventArgs("AreaAs1"));
            PropertyChanged(this, new PropertyChangedEventArgs("AreaConcrete"));
        }

        public void Calculate(Boolean isProstokatny)
        {
            areaAs1 = Math.PI * fiAs1 * fiAs1 * 0.25 * countAs1;
            aReiforcement = cover + 0.5 * fiAs1 / 1000;
            if (isProstokatny)
            {
                areaConcrete = width * height - (areaAs1 * 0.000001);
            }
            else
            {
               areaConcrete = Math.PI* diameter * diameter/4 - (areaAs1 * 0.000001);
            }
        }
    }
}


 