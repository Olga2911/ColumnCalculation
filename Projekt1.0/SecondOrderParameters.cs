﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class SecondOrderParameters : INotifyPropertyChanged
    {
        private Double rm = 1.0;
        private Double miy = 1;
        private Double miz = 1;
        private Double ks = 1.0;
        private Double bParameter = 1.1;
        private Double cParameter = 0.7;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Rm

        {
            get
            {
                return rm;
            }
            set
            {
                if (value > 0)
                {
                    rm = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Rm"));
                }
            }
        }

        public double Miy
        {
            get
            {
                return miy;
            }
            set
            {
                if (value > 0)
                {
                    miy = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Miy"));
                }
            }
        }

        public double Miz
        {
            get
            {
                return miz;
            }
            set
            {
                if (value > 0)
                {
                    miz = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Miz"));
                }
            }
        }

        public double Ks
        {
            get
            {
                return ks;
            }
            set
            {
                if (value > 0)
                {
                    ks = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Ks"));
                }
            }
        }

        public double BParameter
        {
            get
            {
                return bParameter;
            }
            set
            {
                if (value > 0)
                {
                    bParameter = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("BParameter"));
                }
            }
        }

        public double CParameter
        {
            get
            {
                return cParameter;
            }
            set
            {
                if (value > 0)
                {
                    cParameter = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("CParameter"));
                }
            }
        }
    }
}








