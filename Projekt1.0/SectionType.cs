using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class SectionType : INotifyPropertyChanged
    {
        private SectionTypeEnum section= SectionTypeEnum.Prostokątny;
        private string pathToDraw = "C:/Users/USER/Desktop/Praca mgr/C#/Projekt1.0/Projekt1.0/Draws/kotrys.jpg";

        public event PropertyChangedEventHandler PropertyChanged;

        public SectionTypeEnum Section
        {
            get
            {
                return section;
            }
            set
            {
                section = value;
                UpdateData();
            }
        }

        public string PathToDraw
        {
            get
            {
                if (section.Equals(SectionTypeEnum.Prostokątny))
                    {
                    return pathToDraw;
                }
                else
                {
                    return "C:/Users/USER/Desktop/Praca mgr/C#/Projekt1.0/Projekt1.0/Draws/myszrys.png";
                }
                
            }
            set
            {
                pathToDraw = value;
            }
        }

        public Array ArraySectionType
        {
            get
            {
                return Enum.GetValues(typeof(SectionTypeEnum));
            }
        }

        public enum SectionTypeEnum
        {
            Kołowy, Prostokątny
        }

        public void UpdateData()
        {
            PropertyChanged(this, new PropertyChangedEventArgs("PathToDraw"));
            PropertyChanged(this, new PropertyChangedEventArgs("Section"));
            PropertyChanged(this, new PropertyChangedEventArgs("IsProstokatnySection"));
            PropertyChanged(this, new PropertyChangedEventArgs("IsKolowySection"));
        }

        public bool IsProstokatnySection
        {
            get
                {
                if (section.Equals(SectionTypeEnum.Prostokątny))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           
        }

        public bool IsKolowySection
        {
            get
            {
                if (section.Equals(SectionTypeEnum.Kołowy))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }


    }
}
