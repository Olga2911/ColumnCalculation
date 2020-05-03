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
        private Double areaAsmin = 0.0;
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

        private Double cmin = 0.0;
        private Double cnom = 0.0;

        private Double a1y = 0.0;
        private Double d1y = 0.0;
        private Double a2y = 0.0;
        private Double d2y = 0.0;
        private Double a1z = 0.0;
        private Double d1z = 0.0;
        private Double a2z = 0.0;
        private Double d2z = 0.0;

        private Double fiEfektywne = 0.0;

        private Double fcd = 0.0;
        private Double fyd = 0.0;

        public event PropertyChangedEventHandler PropertyChanged; 

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

        public double AreaAsmin
        {
            get
            {
                return areaAsmin;
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

        public double Cmin
        {
            get
            {
                return cmin;
            }
        }

        public double Cnom
        {
            get
            {
                return cnom;
            }
        }

        public double A1y
        {
            get
            {
                return a1y;
            }
        }

        public double D1y
        {
            get
            {
                return d1y;
            }
        }

        public double A2y
        {
            get
            {
                return a2y;
            }
        }

        public double D2y
        {
            get
            {
                return d2y;
            }
        }

        public double A1z
        {
            get
            {
                return a1z;
            }
        }

        public double D1z
        {
            get
            {
                return d1z;
            }
        }

        public double A2z
        {
            get
            {
                return a2z;
            }
        }

        public double D2z
        {
            get
            {
                return d2z;
            }
        }

        public double FiEfektywne
        {
            get
            {
                return fiEfektywne;
            }
        }

        public double Fcd
        {
            get
            {
                return fcd;
            }
        }


        public double Fyd
        {
            get
            {
                return fyd;
            }
        }





        public void Calculate(Project project)              //funkcja licząca - potrzebuje wszystkich danych 
        {
            areaConcrete = project.Column.Dimension.Height * project.Column.Dimension.Width;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AreaConcrete"));                                 //"wysłanie do widoku"

            areaAs = project.Column.Dimension.Quantity1y*(project.Column.Diameters.Fi1y*0.5)*(project.Column.Diameters.Fi1y * 0.5)*Math.PI+ + 
                project.Column.Dimension.Quantity2y*(project.Column.Diameters.Fi2y*0.5)*(project.Column.Diameters.Fi2y*0.5)*Math.PI+ 
                project.Column.Dimension.Quantity1z*(project.Column.Diameters.Fi1z*0.5)*(project.Column.Diameters.Fi1z * 0.5)*Math.PI+
                project.Column.Dimension.Quantity2z*(project.Column.Diameters.Fi2z*0.5)* (project.Column.Diameters.Fi2z * 0.5)*Math.PI;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AreaAs"));

            fiEfektywne = project.Column.EnvironmentalCondition.FiKoncowe * project.Column.EnvironmentalCondition.M0eqpm0ed;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiEfektywne"));

            fcd = project.Column.Concrete.Fck / project.Column.Concrete.GammaC;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fcd"));

            fyd = project.Column.Steel.Fyk / project.Column.Steel.GammaS;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fyd"));

            areaAsmin =100* Math.Max(project.Column.Statics.CompressiveForce / fyd, areaConcrete*0.002); //mm
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AreaAsmin"));

            areaAsmax = 0.4 * project.Column.Dimension.Height * project.Column.Dimension.Width;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AreaAsmax"));

            areaAs1y = project.Column.Dimension.Quantity1y * (project.Column.Diameters.Fi1y*0.5) * (project.Column.Diameters.Fi1y * 0.5) * Math.PI;
            areaAs2y = project.Column.Dimension.Quantity2y * (project.Column.Diameters.Fi2y*0.5) * (project.Column.Diameters.Fi2y * 0.5) * Math.PI;
            areaAs1z = project.Column.Dimension.Quantity1z * (project.Column.Diameters.Fi1z*0.5) * (project.Column.Diameters.Fi1z * 0.5) * Math.PI;
            areaAs2z = project.Column.Dimension.Quantity2z * (project.Column.Diameters.Fi2z*0.5) * (project.Column.Diameters.Fi2z * 0.5) * Math.PI;
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

            cmin = Math.Max(Math.Max(project.Column.ConcreteCoverParameters.Cminb, project.Column.ConcreteCoverParameters.Cmindur + project.Column.ConcreteCoverParameters.Cdurgamma - project.Column.ConcreteCoverParameters.Deltadurst - project.Column.ConcreteCoverParameters.Deltacduradd), 10);                //mm          
            cnom = cmin + project.Column.ConcreteCoverParameters.Deltacdev;              //mm          
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cnom"));

            a1y=cnom+project.Column.Diameters.FiS+0.5 * project.Column.Diameters.Fi1y;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("A1y"));
            d1y = project.Column.Dimension.Height - a1y;

            a2y = cnom + project.Column.Diameters.FiS + 0.5 * project.Column.Diameters.Fi2y;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("A2y"));
            d2y = project.Column.Dimension.Height - a2y;

            a1z = cnom + project.Column.Diameters.FiS + 0.5 * project.Column.Diameters.Fi1z;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("A1z"));
            d1z = project.Column.Dimension.Width - a1z;

            a2z = cnom + project.Column.Diameters.FiS + 0.5 * project.Column.Diameters.Fi2z;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("A2z"));
            d2z = project.Column.Dimension.Width - a2z;


            //wpisać wszystkie pola
        }
    }
}
