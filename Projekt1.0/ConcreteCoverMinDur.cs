using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class ConcreteCoverMinDur : INotifyPropertyChanged
    {

        private StructuralClass structuralClass = StructuralClass.S3;
        private String structuralClassDescription = EnumConvert.GetDescription(StructuralClass.S3);

        private ExposureClass exposureClass = ExposureClass.XC1;
        private String exposureClassDescription = EnumConvert.GetDescription(ExposureClass.XC1);

        public event PropertyChangedEventHandler PropertyChanged;

        public Array ClassOfStructural
        {
            get
            {
                List<StructuralClass> structuralclasslist = Enum.GetValues(typeof(StructuralClass)).OfType<StructuralClass>().ToList();
                List<String> resultList = new List<string>();
                foreach (StructuralClass type in structuralclasslist)
                {
                    var descript = EnumConvert.GetDescription(type);
                    resultList.Add(descript);
                }

                return resultList.ToArray();
            }
        }

        public Array ClassOfExposure
        {
            get
            {
                List<ExposureClass> exposureclasslist = Enum.GetValues(typeof(ExposureClass)).OfType<ExposureClass>().ToList();
                List<String> resultList = new List<string>();
                foreach (ExposureClass type in exposureclasslist)
                {
                    var descript = EnumConvert.GetDescription(type);
                    resultList.Add(descript);
                }
                return resultList.ToArray();
            }
        }

        public String ExposureClassDescription
        {
            get
            {
                return exposureClassDescription;
            }
            set
            {
                exposureClassDescription = value;
                exposureClass = EnumConvert.GetEnumValueFromDescription<ExposureClass>(exposureClassDescription);
                switch (exposureClass)
                {
                    case ExposureClass.X0:
                        break;
                    case ExposureClass.XC1:
                        break;
                    case ExposureClass.XC2:
                        break;
                    case ExposureClass.XC3:
                        break;
                    case ExposureClass.XC4:
                        break;
                    case ExposureClass.XD1:
                        break;
                    case ExposureClass.XD2:
                        break;
                    case ExposureClass.XD3:
                        break;
                    case ExposureClass.XS1:
                        break;
                    case ExposureClass.XS2:
                        break;
                    case ExposureClass.XS3:
                        break;
                }

                UpdateData();
            }
        }

        public String StructuralClassDescription
        {
            get
            {
                return structuralClassDescription;
            }
            set
            {
                structuralClassDescription = value;
                structuralClass = EnumConvert.GetEnumValueFromDescription<StructuralClass>(structuralClassDescription);
                switch (structuralClass)
                {
                    case StructuralClass.S1:
                        break;
                    case StructuralClass.S2:
                        break;
                    case StructuralClass.S3:
                        break;
                    case StructuralClass.S4:
                        break;
                    case StructuralClass.S5:
                        break;
                    case StructuralClass.S6:
                        break;
                }
                UpdateData();
            }
        }

        public void UpdateData()
        {
            PropertyChanged(this, new PropertyChangedEventArgs("StructuralClass"));
            PropertyChanged(this, new PropertyChangedEventArgs("StructuralClassDescription"));

            PropertyChanged(this, new PropertyChangedEventArgs("EsposureClass"));
            PropertyChanged(this, new PropertyChangedEventArgs("ExposureClassDescription"));
        }

        public enum StructuralClass
        {
            [Description("S1")]
            S1,
            [Description("S2")]
            S2,
            [Description("S3")]
            S3,
            [Description("S4")]
            S4,
            [Description("S5")]
            S5,
            [Description("S6")]
            S6
        }

        public enum ExposureClass
        {
            [Description("X0")]
            X0,
            [Description("XC1")]
            XC1,
            [Description("XC2")]
            XC2,
            [Description("XC3")]
            XC3,
            [Description("XC4")]
            XC4,
            [Description("XD1")]
            XD1,
            [Description("XD2")]
            XD2,
            [Description("XD3")]
            XD3,
            [Description("XS1")]
            XS1,
            [Description("XS2")]
            XS2,
            [Description("XS3")]
            XS3
        }
    }
}

