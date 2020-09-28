using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class BasicCalculations : INotifyPropertyChanged
    {
        private Double areaConcrete = 0.0;
        private Double areaAsmin = 0.0;
        private Double areaAsmax = 0.0;

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

        private Double fcd = 0.0;
        private Double fyd = 0.0;

        private String fiSComment;
        private String sComment;

        public event PropertyChangedEventHandler PropertyChanged;

        public Double AreaConcrete
        {
            get
            {
                return areaConcrete;
            }
        }

        public double AreaAsmin
        {
            get
            {
                return areaAsmin;
            }
        }

        public double AreaAsminV
        {
            get
            {
                return areaAsmin/100;
            }
        }

        public double AreaAsmax
        {
            get
            {
                return areaAsmax;
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

        public string FiSComment
        {
            get
            {
                return fiSComment;
            }
        }

        public string SComment
        {
            get
            {
                return sComment;
            }
        }

        public void Calculate(Project project)           
        {
            areaConcrete = project.Column.Dimension.Height * project.Column.Dimension.Width;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AreaConcrete"));

            fcd = project.Column.Concrete.Fck / project.Column.Concrete.GammaC;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fcd"));

            fyd = project.Column.Steel.Fyk / project.Column.Steel.GammaS;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fyd"));

            areaAsmin = 100 * Math.Max(project.Column.Statics.CompressiveForce *0.5 / fyd, areaConcrete * 0.5 * 0.002); //mm2
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AreaAsmin"));

            fiSmin = Math.Max(Math.Max(Math.Max(0.25 * project.Column.Diameters.Fi1y, 0.25 * project.Column.Diameters.Fi2y), Math.Max(0.25 * project.Column.Diameters.Fi1z, 0.25 * project.Column.Diameters.Fi2z)), 6); //mm          
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiSmin"));

            sCltmax =
                Math.Min(
                Math.Min(20 * Math.Min(Math.Min(project.Column.Diameters.Fi1y, project.Column.Diameters.Fi2y), Math.Min(project.Column.Diameters.Fi1z, project.Column.Diameters.Fi2z)),
                10 * Math.Min(project.Column.Dimension.Height, project.Column.Dimension.Width)),
                400);               //mm          
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SCltmax"));
            sCltmax06 = 0.6 * sCltmax;               //mm          
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SCltmax06"));

            cmin = Math.Max(Math.Max(project.Column.ConcreteCoverParameters.Cminb, project.ConcreteCoverMinDurCalculation.CMinDur + project.Column.ConcreteCoverParameters.Cdurgamma - project.Column.ConcreteCoverParameters.Deltadurst - project.Column.ConcreteCoverParameters.Deltacduradd), 10);                //mm          
            cnom = cmin + project.Column.ConcreteCoverParameters.Deltacdev;              //mm          
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cnom"));

            a1y = cnom + project.Column.Diameters.FiS + 0.5 * project.Column.Diameters.Fi1y;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("A1y"));
            d1y = project.Column.Dimension.Height - a1y * 0.1;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("D1y"));

            a2y = cnom + project.Column.Diameters.FiS + 0.5 * project.Column.Diameters.Fi2y;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("A2y"));
            d2y = project.Column.Dimension.Height - a2y * 0.1;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("D2y"));

            a1z = cnom + project.Column.Diameters.FiS + 0.5 * project.Column.Diameters.Fi1z;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("A1z"));
            d1z = project.Column.Dimension.Width - a1z * 0.1;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("D1z"));

            a2z = cnom + project.Column.Diameters.FiS + 0.5 * project.Column.Diameters.Fi2z;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("A2z"));
            d2z = project.Column.Dimension.Width - a2z * 0.1;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("D2z"));

            if (project.Column.Diameters.FiS >= fiSmin)
            {
                fiSComment = "SPEŁNIONY";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiSComment"));
            }
            else
            {
                fiSComment = "NIESPEŁNIONY";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiSComment"));
            }


            if (project.Column.Dimension.S <= sCltmax)
            {
                sComment = "SPEŁNIONY";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SComment"));
            }
            else
            {
                sComment = "NIESPEŁNIONY";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SComment"));
            }
        }
    }
}
