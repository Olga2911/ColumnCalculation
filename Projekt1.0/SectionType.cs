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
            }
        }

        public string PathToDraw
        {
            get
            {
                return pathToDraw;
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
        }

    }
}
