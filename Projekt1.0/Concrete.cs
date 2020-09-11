using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class Concrete : INotifyPropertyChanged

    {
        private ConcreteClasses concreteClasses = ConcreteClasses.C25;
        private String concreteClassDescription = EnumConvert.GetDescription(ConcreteClasses.C25);
        private Double fck = 25.0;
        private Double gammaC = 1.5;
        private Double fcd = 0.0;
        private Double ecm = 31.0;
        private Double epsilonCu2 = 0.0035;
        private Double epsilonC3 = 0.00175;

        public event PropertyChangedEventHandler PropertyChanged;

        public Array ClassesOfConcrete
        {
            get
            {
                List<ConcreteClasses> concretelist = Enum.GetValues(typeof(ConcreteClasses)).OfType<ConcreteClasses>().ToList();
                List<String> resultList = new List<string>();
                foreach (ConcreteClasses type in concretelist )
                {
                    var descript = EnumConvert.GetDescription(type);
                    resultList.Add(descript);
                }

                return resultList.ToArray();
            }
        }

        public String ConcreteClassDescription
        {
            get
            {
                return concreteClassDescription;
            }
            set
            {
                concreteClassDescription = value;
                concreteClasses = EnumConvert.GetEnumValueFromDescription<ConcreteClasses>(concreteClassDescription);
                switch(concreteClasses)
                {
                    case ConcreteClasses.C16:
                        fck = 16;
                        ecm = 29;
                        break;
                    case ConcreteClasses.C20:
                        fck = 20;
                        ecm = 30;
                        break;
                    case ConcreteClasses.C25:
                        fck = 25;
                        ecm = 31;
                        break;
                    case ConcreteClasses.C30:
                        fck = 30;
                        ecm = 32;
                        break;
                    case ConcreteClasses.C35:
                        fck = 35;
                        ecm = 34;
                        break;
                    case ConcreteClasses.C40:
                        fck = 40;
                        ecm = 35;
                        break;
                }
                UpdateData();
            }
        }

        public void UpdateData()
        {
            PropertyChanged(this, new PropertyChangedEventArgs("ConcreteClass"));
            PropertyChanged(this, new PropertyChangedEventArgs("ConcreteClassDescription"));
            PropertyChanged(this, new PropertyChangedEventArgs("fck"));
            PropertyChanged(this, new PropertyChangedEventArgs("gammaC"));
            PropertyChanged(this, new PropertyChangedEventArgs("fcd"));
            PropertyChanged(this, new PropertyChangedEventArgs("Ecm"));
            PropertyChanged(this, new PropertyChangedEventArgs("EpsilonCu2"));
            PropertyChanged(this, new PropertyChangedEventArgs("EpsilonC3"));

        }

        public enum ConcreteClasses
        {
            [Description("C16/20")]
            C16,
            [Description("C20/25")]
            C20,
            [Description("C25/30")]
            C25,
            [Description("C30/37")]
            C30,
            [Description("C35/45")]
            C35,
            [Description("C40/50")]
            C40
        }

        public double Fck
        {
            get
            {
                return fck;
            }
            set
            {
                if (value > 0)
                {
                    fck = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Fck"));
                }
            }
        }

        public double GammaC
        {
            get
            {
                return gammaC;
            }
            set
            {
                if (value > 0)
                {
                    gammaC = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("GammaC"));
                }
            }
        }

        public double Ecm
        {
            get
            {
                return ecm;
            }
            set
            {
                if (value > 0)
                {
                    ecm = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Ecm"));
                }
            }
        }

        public double EpsilonCu2
        {
            get
            {
                return epsilonCu2;
            }
            set
            {
                if (value > 0)
                {
                    epsilonCu2 = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("EpsilonCu2"));
                }
            }
        }

        public double EpsilonC3
        {
            get
            {
                return epsilonC3;
            }
            set
            {
                if (value > 0)
                {
                    epsilonC3 = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("EpsilonC3"));
                }
            }
        }







    }
}
