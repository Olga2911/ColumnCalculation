﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class Steel : INotifyPropertyChanged
    {
        private SteelClasses steelClasses = SteelClasses.AIII35G2Y;
        private String steelClassDescription = EnumConvert.GetDescription(SteelClasses.AIII35G2Y);
        private Double fyk = 410.0;
        private Double gammaS = 1.15;
        private Double es = 200.0; //GPa
        private Double ksiEffLim = 0.539; //GPa

        public event PropertyChangedEventHandler PropertyChanged;

        public Array ClassesOfSteel
        {
            get
            {
                List<SteelClasses> steellist = Enum.GetValues(typeof(SteelClasses)).OfType<SteelClasses>().ToList();
                List<String> resultsteelList = new List<string>();
                foreach (SteelClasses type in steellist)
                {
                    var descript = EnumConvert.GetDescription(type);
                    resultsteelList.Add(descript);

                }


                return resultsteelList.ToArray();
            }
        }


        public String SteelClassDescription
        {
            get
            {
                return steelClassDescription;
            }
            set
            {
                steelClassDescription = value;
                steelClasses = EnumConvert.GetEnumValueFromDescription<SteelClasses>(steelClassDescription);
                switch (steelClasses)
                {
                    case SteelClasses.AIIINRB500:
                        fyk = 500.0;
                        gammaS = 1.15;
                        ksiEffLim = 0.500;
                        break;
                    case SteelClasses.A0St0Sb:
                        fyk = 220.0;
                        gammaS = 1.15;
                        ksiEffLim = 0.63;
                        break;
                    case SteelClasses.AISt3SXb:
                        fyk = 240.0;
                        gammaS = 1.15;
                        ksiEffLim = 0.62;
                        break;
                    case SteelClasses.AIISt50B:
                        fyk = 355.0;
                        gammaS = 1.15;
                        ksiEffLim = 0.55;
                        break;
                    case SteelClasses.AIII35G2Y:
                        fyk = 410.0;
                        gammaS = 1.15;
                        ksiEffLim = 0.53;
                        break;
                }
                UpdateData();
            }
        }
        public void UpdateData()
        {
            PropertyChanged(this, new PropertyChangedEventArgs("SteelClass"));
            PropertyChanged(this, new PropertyChangedEventArgs("SteelClassDescription"));
            PropertyChanged(this, new PropertyChangedEventArgs("fyk"));
            PropertyChanged(this, new PropertyChangedEventArgs("gammaS"));
            PropertyChanged(this, new PropertyChangedEventArgs("fyd"));
            PropertyChanged(this, new PropertyChangedEventArgs("es"));
            PropertyChanged(this, new PropertyChangedEventArgs("ksiEffLim"));

        }

        public enum SteelClasses
        {
            [Description("A-0")]
            A0St0Sb,
            [Description("A-I St3SXb")]
            AISt3SXb,
            [Description("A-II St50B")]
            AIISt50B,
            [Description("A-III 35G2Y")]
            AIII35G2Y,
            [Description("A-IIIN RB500")]
            AIIINRB500,
        }

        public double Fyk
        {
            get
            {
                return fyk;
            }
            set
            {
                if (value > 0)
                {
                    fyk = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Fyk"));
                }
            }
        }

        public double GammaS
        {
            get
            {
                return gammaS;
            }
            set
            {
                if (value > 0)
                {
                    gammaS = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("GammaS"));
                }
            }
        }

        public double Es
        {
            get
            {
                return es;
            }
            set
            {
                if (value > 0)
                {
                    es = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Es"));
                }
            }
        }

        public double KsiEffLim
        {
            get
            {
                return ksiEffLim;
            }
            set
            {
                if (value > 0)
                {
                    ksiEffLim = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("KsiEffLim"));
                }
            }
        }


    }
}
