using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class BasicParameters : INotifyPropertyChanged //dziedziczenie klasy z bazy
    {
        private Double areaConcrete = 0.0;
        private Double areaAs1 = 0.0;
        private Double aReiforcement = 0.0;


        public event PropertyChangedEventHandler PropertyChanged; //opcja która potrafi wysłać informację o zmianie danych

        public BasicParameters(Project project)
        {
            Calculate(project);
        }

        public Double AreaConcrete
        {
            get
            {
                return areaConcrete;
            }
        }

        public Double AReinforcement
        {
            get
            {
                return aReiforcement;
            }
        }

        public double AreaAs1
        {
            get
            {
                return areaAs1;
            }
        }



        public void Calculate(Project project) //funkcja licząca - potrzebuje wszystkich danych 
        {
            areaConcrete = project.Column.SectionDimensions.Height * project.Column.SectionDimensions.Width;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AreaConcrete")); //"wysłanie do widoku"
            //wpisać wszystkie pola
        }
    }
}
