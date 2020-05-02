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
        private Double areaAsmax = 0.0;
        private Double areaAs1y = 0.0;
        private Double areaAs2y = 0.0;
        private Double areaAs1z = 0.0;
        private Double areaAs2z = 0.0;
        private Double areaAsy = 0.0;
        private Double areaAsz = 0.0;

        private Double fiSmin = 0.0;
        private Double sCltmax = 0.0;
        private Double sCltmax06 = 0.0;

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

        public double AreaAsmax
        {
            get
            {
                return areaAsmax;
            }
        }

        public double AreaAs1y
        {
            get
            {
                return areaAs1y;
            }
        }
        public double AreaAs2y
        {
            get
            {
                return areaAs2y;
            }
        }
        public double AreaAs1z
        {
            get
            {
                return areaAs1z;
            }
        }
        public double AreaAs2z
        {
            get
            {
                return areaAs2z;
            }
        }
        public double AreaAsy
        {
            get
            {
                return areaAsy;
            }
        }
        public double AreaAsz
        {
            get
            {
                return areaAsz;
            }
        }

        public double FiSmin
        {
            get
            {
                return fiSmin;
            }
        }

        public double SCltmax
        {
            get
            {
                return sCltmax;
            }
        }

        public double SCltmax06
        {
            get
            {
                return sCltmax06;
            }
        }




        public void Calculate(Project project)              //funkcja licząca - potrzebuje wszystkich danych 
        {
            areaConcrete = project.Column.Dimension.Height * project.Column.Dimension.Width;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AreaConcrete"));                                 //"wysłanie do widoku"

            areaAs = project.Column.Dimension.Quantity1y*project.Column.Diameters.Fi1y + project.Column.Dimension.Quantity2y * project.Column.Diameters.Fi2y + project.Column.Dimension.Quantity1z * project.Column.Diameters.Fi1z + project.Column.Dimension.Quantity2z * project.Column.Diameters.Fi2z;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AreaAs"));

            areaAsmax = 0.4 * project.Column.Dimension.Height * project.Column.Dimension.Width;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AreaAsmax"));

            areaAs1y = project.Column.Dimension.Quantity1y * project.Column.Diameters.Fi1y;
            areaAs2y = project.Column.Dimension.Quantity2y * project.Column.Diameters.Fi2y;
            areaAs1z = project.Column.Dimension.Quantity1z * project.Column.Diameters.Fi1z;
            areaAs2z = project.Column.Dimension.Quantity2z * project.Column.Diameters.Fi2z;
            areaAsy = AreaAs1y + AreaAs2y;
            areaAsz = AreaAs1z + AreaAs2z;

            fiSmin = Math.Max(Math.Max(Math.Max(0.25 * project.Column.Diameters.Fi1y, 0.25 * project.Column.Diameters.Fi2y), Math.Max(0.25 * project.Column.Diameters.Fi1z, 0.25 * project.Column.Diameters.Fi2z)), 6); //mm          
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiSmin"));

            sCltmax =
                Math.Min(
                Math.Min(20 * Math.Min(Math.Min(project.Column.Diameters.Fi1y, project.Column.Diameters.Fi2y), Math.Min(project.Column.Diameters.Fi1z, project.Column.Diameters.Fi2z)),
                10 * Math.Min(project.Column.Dimension.Height, project.Column.Dimension.Width)),
                400);               //mm          

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SCltmax"));

            sCltmax06 =0.6*sCltmax;               //mm          

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SCltmax06"));


            //wpisać wszystkie pola
        }
    }
}
