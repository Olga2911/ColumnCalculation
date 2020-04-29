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
        private ConcreteClasses concreteClasses = ConcreteClasses.C20;
        private String concreteClassDescription = EnumConvert.GetDescription(ConcreteClasses.C20);
        private Double fck = 20.0;
        private Double gammaC = 1.5;
        private Double fcd = 0.0;
        private Double Ecm = 30.0;

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
                        Ecm = 29;
                        break;
                    case ConcreteClasses.C20:
                        fck = 20;
                        Ecm = 30;
                        break;
                    case ConcreteClasses.C25:
                        fck = 25;
                        Ecm = 31;
                        break;
                    case ConcreteClasses.C30:
                        fck = 30;
                        Ecm = 32;
                        break;
                    case ConcreteClasses.C35:
                        fck = 35;
                        Ecm = 34;
                        break;
                }
                UpdateData();
            }
        }

        public void UpdateData()
        {
            //Calculate();
            PropertyChanged(this, new PropertyChangedEventArgs("ConcreteClass"));
            PropertyChanged(this, new PropertyChangedEventArgs("ConcreteClassDescription"));
            PropertyChanged(this, new PropertyChangedEventArgs("fck"));
            PropertyChanged(this, new PropertyChangedEventArgs("gammaC"));
            PropertyChanged(this, new PropertyChangedEventArgs("fcd"));
            PropertyChanged(this, new PropertyChangedEventArgs("Ecm"));
        }

        //public void Calculate()
        //{
        //    fcd = fck / gammaC;
        //}

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
    }
}
