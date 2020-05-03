using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class SecondOrderCalculations : INotifyPropertyChanged

    {
        private Double aParameter = 0.0;
        private Double omega = 0.0;
        private Double bParameter = 0.0;
        private Double cParameter = 0.0;
        private Double nForce = 0.0;
        private Double lambdalim = 0.0;
        private Double height0y = 0.0;
        private Double lambday = 0.0;
        private Double height0z = 0.0;
        private Double lambdaz = 0.0;
        private Double k1 = 0.0;
        private Double k2y = 0.0;
        private Double kcy = 0.0;
        private Double icy = 0.0;
        private Double isy = 0.0;
        private Double k2z = 0.0;
        private Double kcz = 0.0;
        private Double icz = 0.0;
        private Double isz = 0.0;
        private Double eiy = 0.0;
        private Double eiz = 0.0;

        public event PropertyChangedEventHandler PropertyChanged;

        public SecondOrderCalculations(Project project)
        {
            Calculate(project);
        }

        public Double AParameter
        {
            get
            {
                return aParameter;
            }
        }

        public Double Omega
        {
            get
            {
                return omega;
            }
        }

        public Double BParameter
        {
            get
            {
                return bParameter;
            }
        }

        public Double CParameter
        {
            get
            {
                return cParameter;
            }
        }

        public Double NForce
        {
            get
            {
                return nForce;
            }
        }

        public Double Lambdalim
        {
            get
            {
                return lambdalim;
            }
        }

        public Double Height0y
        {
            get
            {
                return height0y;
            }
        }

        public Double Lambday
        {
            get
            {
                return lambday;
            }
        }

        public Double Height0z
        {
            get
            {
                return height0z;
            }
        }

        public Double Lambdaz
        {
            get
            {
                return lambdaz;
            }
        }

        public Double K1
        {
            get
            {
                return k1;
            }
        }

        public Double K2y
        {
            get
            {
                return k2y;
            }
        }

        public Double Kcy
        {
            get
            {
                return kcy;
            }
        }

        public Double Icy
        {
            get
            {
                return icy;
            }
        }

        public Double Isy
        {
            get
            {
                return isy;
            }
        }

        public Double Eiy
        {
            get
            {
                return eiy;
            }
        }

        public Double K2z
        {
            get
            {
                return k2z;
            }
        }

        public Double Kcz
        {
            get
            {
                return kcz;
            }
        }

        public Double Icz
        {
            get
            {
                return icz;
            }
        }

        public Double Isz
        {
            get
            {
                return isz;
            }
        }

        public Double Eiz
        {
            get
            {
                return eiz;
            }
        }






        public void Calculate(Project project)
        {
            aParameter = 1 / (1 + 0.2 * project.BasicCalculations.FiEfektywne);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AParameter"));

            omega =(project.BasicCalculations.AreaAs*project.BasicCalculations.Fyd)/(project.BasicCalculations.AreaConcrete * project.BasicCalculations.Fcd);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Omega"));

            bParameter = Math.Sqrt(1 + 2 * omega);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BParameter"));

            cParameter = 1.7 - project.Column.SecondOrderParameters.Rm;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CParameter"));

            nForce = 10*project.Column.Statics.CompressiveForce/(project.BasicCalculations.AreaConcrete*project.BasicCalculations.Fcd);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NForce"));

            lambdalim = 20 * aParameter * BParameter * cParameter / Math.Sqrt(nForce);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lambdalim"));

            height0y = project.Column.SecondOrderParameters.Miy*project.Column.Dimension.ColumnHeight;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Height0y"));

            lambday = height0y * Math.Sqrt(12) / project.Column.Dimension.Height;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lambday"));

            height0z = project.Column.SecondOrderParameters.Miz * project.Column.Dimension.ColumnHeight;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Height0z"));

            lambdaz = height0z * Math.Sqrt(12) / project.Column.Dimension.Width;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lambdaz"));

            k1 = Math.Sqrt(project.Column.Concrete.Fck/20);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K1"));

            k2y = Math.Min(nForce*lambday/170, 0.2);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K2y"));

            kcy = k1*k2y/(1+project.BasicCalculations.FiEfektywne);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Kcy"));

            icy = project.Column.Dimension.Width*project.Column.Dimension.Height* project.Column.Dimension.Height* project.Column.Dimension.Height/12;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Icy"));

            isy = project.BasicCalculations.AreaAs1y*0.01*(0.5*project.Column.Dimension.Height-project.BasicCalculations.A1y*0.1)* (0.5 * project.Column.Dimension.Height - project.BasicCalculations.A1y * 0.1)+
                project.BasicCalculations.AreaAs2y * 0.01 * (0.5 * project.Column.Dimension.Height - project.BasicCalculations.A2y * 0.1) * (0.5 * project.Column.Dimension.Height - project.BasicCalculations.A2y * 0.1);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Isy"));

            //eiy = kcy * project.Column.Concrete.Ecm * Icy + project.Column.SecondOrderParameters.Ks * project.Column.Steel.Fyk * Isy;
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Eiy"));

            k2z = Math.Min(nForce * lambdaz / 170, 0.2);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K2z"));

            kcz = k1 * k2z / (1 + project.BasicCalculations.FiEfektywne);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Kcz"));

            icz = project.Column.Dimension.Height * project.Column.Dimension.Width * project.Column.Dimension.Width * project.Column.Dimension.Width / 12;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Icz"));

            isz = project.BasicCalculations.AreaAs1z * 0.01 * (0.5 * project.Column.Dimension.Width - project.BasicCalculations.A1z * 0.1) * (0.5 * project.Column.Dimension.Width - project.BasicCalculations.A1z * 0.1) +
                project.BasicCalculations.AreaAs2z * 0.01 * (0.5 * project.Column.Dimension.Width - project.BasicCalculations.A2z * 0.1) * (0.5 * project.Column.Dimension.Width - project.BasicCalculations.A2z * 0.1);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Isz"));

        }



    }

}
