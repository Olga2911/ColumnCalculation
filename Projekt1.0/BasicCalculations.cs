using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class BasicCalculations : INotifyPropertyChanged //dziedziczenie klasy z bazy
    {
        private Double areaConcrete = 0.0;
        private Double areaAs = 0.0;

        public event PropertyChangedEventHandler PropertyChanged; //opcja która potrafi wysłać informację o zmianie danych

        public BasicCalculations(Project project)
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

        public double AreaAs
        {
            get
            {
                return areaAs;
            }
        }

        
        public void Calculate(Project project)              //funkcja licząca - potrzebuje wszystkich danych 
        {
            areaConcrete = project.Column.Dimension.Height * project.Column.Dimension.Width;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AreaConcrete"));                                 //"wysłanie do widoku"

            areaAs = project.Column.Dimension.Quantity1y*project.Column.Diameters.Fi1y + project.Column.Dimension.Quantity2y * project.Column.Diameters.Fi2y + project.Column.Dimension.Quantity1z * project.Column.Diameters.Fi1z + project.Column.Dimension.Quantity2z * project.Column.Diameters.Fi2z;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AreaAs"));



            //wpisać wszystkie pola
        }
    }
}
