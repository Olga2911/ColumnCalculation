using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class Diameters : INotifyPropertyChanged
    {
        private int fi1y = 16; //mm
        private int fi2y = 16; //mm
        private int fi1z = 8; //mm
        private int fi2z = 8; //mm
        private int fiS = 6; //mm

        public event PropertyChangedEventHandler PropertyChanged;

        public int Fi1y
        {
            get
            {
                return fi1y;
            }
            set
            {
                    fi1y = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Fi1y"));    //nasłuchiwanie
            }
        }

        public int Fi2y
        {
            get
            {
                return fi2y;
            }
            set
            {
                fi2y = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Fi2y"));    
            }
        }

        public int Fi1z
        {
            get
            {
                return fi1z;
            }
            set
            {
                fi1z = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Fi1z"));   
            }
        }

        public int Fi2z
        {
            get
            {
                return fi2z;
            }
            set
            {
                fi2z = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Fi2z"));
            }
        }

        public int FiS
        {
            get
            {
                return fiS;
            }
            set
            {
                fiS = value;
                PropertyChanged(this, new PropertyChangedEventArgs("FiS"));
            }
        }

        public Array FiArray
        {
            get
            {
                return new int[] {6, 8, 10, 12, 16, 20, 25, 32 };
            }
        }

    }
}

