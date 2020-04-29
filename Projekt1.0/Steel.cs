using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class Steel : INotifyPropertyChanged
    {
        private SteelClasses steelClasses = SteelClasses.AIIINRB500;
        private String steelClassDescription = EnumConvert.GetDescription(SteelClasses.AIIINRB500);
        private Double fyk = 500.0;
        private Double gammaS = 1.15;
        private Double fyd = 0.0;
        private int countAs1 = 4; //fi [mm]
        private int fiAs1 = 12;
        private Double cover = 0.04; //cover [m]

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

        public int FiAs1
        {
            get
            {
                return fiAs1;
            }
            set
            {
                if (value > 0)
                {
                    fiAs1 = value;
                }

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
                        fyd = 0.0;
                        break;
                    case SteelClasses.A0St0Sb:
                        fyk = 220.0;
                        gammaS = 1.15;
                        fyd = 0.0;
                        break;
                    case SteelClasses.AISt3SXb:
                        fyk = 240.0;
                        gammaS = 1.15;
                        fyd = 0.0;
                        break;
                    case SteelClasses.AIISt50B:
                        fyk = 355.0;
                        gammaS = 1.15;
                        fyd = 0.0;
                        break;
                    case SteelClasses.AIII35G2Y:
                        fyk = 410.0;
                        gammaS = 1.15;
                        fyd = 0.0;
                        break;
                }
                UpdateData();
            }
        }
        public void UpdateData()
        {
            Calculate();
            PropertyChanged(this, new PropertyChangedEventArgs("SteelClass"));
            PropertyChanged(this, new PropertyChangedEventArgs("SteelClassDescription"));
            PropertyChanged(this, new PropertyChangedEventArgs("fyk"));
            PropertyChanged(this, new PropertyChangedEventArgs("gammaS"));
            PropertyChanged(this, new PropertyChangedEventArgs("fyd"));
            PropertyChanged(this, new PropertyChangedEventArgs("countAs1"));
            PropertyChanged(this, new PropertyChangedEventArgs("fiAs1"));
            PropertyChanged(this, new PropertyChangedEventArgs("cover"));
        }

        public void Calculate()
        {
            fyd = fyk / gammaS;
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

    }
}
