using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class NiChecking : INotifyPropertyChanged
    {
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

        private Double nby = 0.0;
        private Double nbz = 0.0;

        private Double niY2 = 0.0;
        private Double niZ2 = 0.0;

        public event PropertyChangedEventHandler PropertyChanged;

        public NiChecking(Project project)
        {
            Calculate(project);
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

        public Double Nby
        {
            get
            {
                return nby;
            }
        }

        public Double Nbz
        {
            get
            {
                return nbz;
            }
        }

        public Double NiY2
        {
            get
            {
                return niY2;
            }
        }

        public Double NiZ2
        {
            get
            {
                return niZ2;
            }
        }

        public void Calculate(Project project)
        {

            //isy = project.LoadCapacityCalculation.As1yProv * 0.01 * Math.Pow((0.5 * project.Column.Dimension.Height - project.BasicCalculations.A1y * 0.1), 2) +
            //   project.LoadCapacityCalculation.As2yProv * 0.01 * Math.Pow((0.5 * project.Column.Dimension.Height - project.BasicCalculations.A2y * 0.1), 2);
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("isy"));

            //eiy = kcy * project.Column.Concrete.Ecm * Icy * 0.01 + project.Column.SecondOrderParameters.Ks * project.Column.Steel.Es * Isy * 0.01;
            //eiy = Math.Round((Double)eiy, 2);
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Eiy"));
            ///////////////////////////////////
            //k2z = Math.Min(nForce * lambdaz / 170, 0.2);
            //k2z = Math.Round((Double)k2z, 4);
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K2z"));

            //kcz = k1 * k2z / (1 + fiEffZ);
            //kcz = Math.Round((Double)kcz, 4);
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Kcz"));

            //icz = project.Column.Dimension.Height * project.Column.Dimension.Width * project.Column.Dimension.Width * project.Column.Dimension.Width / 12;
            //icz = Math.Round((Double)icz, 0);
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Icz"));

            //isz = project.LoadCapacityCalculation.AreaAs1z * 0.01 * (0.5 * project.Column.Dimension.Width - project.BasicCalculations.A1z * 0.1) * (0.5 * project.Column.Dimension.Width - project.BasicCalculations.A1z * 0.1) +
            //    project.BasicCalculations.AreaAs2z * 0.01 * (0.5 * project.Column.Dimension.Width - project.BasicCalculations.A2z * 0.1) * (0.5 * project.Column.Dimension.Width - project.BasicCalculations.A2z * 0.1);
            //isz = Math.Round((Double)isz, 0);
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Isz"));

            //        eiz = kcz * project.Column.Concrete.Ecm * Icz * 0.01 + project.Column.SecondOrderParameters.Ks * project.Column.Steel.Es * Isz * 0.01;
            //        eiz = Math.Round((Double)eiz, 2);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Eiz"));



            //        betaY = Math.PI * Math.PI / project.Column.SecondOrderParameters.C0Y;
            //        betaY = Math.Round((Double)betaY, 3);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BetaY"));

            //        betaZ = Math.PI * Math.PI / project.Column.SecondOrderParameters.C0Z;
            //        betaZ = Math.Round((Double)betaZ, 3);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BetaZ"));

            k1 = Math.Sqrt(project.Column.Concrete.Fck / 20);
            k1 = Math.Round((Double)k1, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K1"));

            //k2y = Math.Min(nForce * lambday / 170, 0.2);
            //k2y = Math.Round((Double)k2y, 4);
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K2y"));

            //kcy = k1 * k2y / (1 + fiEffY);
            kcy = Math.Round((Double)kcy, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Kcy"));

            icy = project.Column.Dimension.Width * project.Column.Dimension.Height * project.Column.Dimension.Height * project.Column.Dimension.Height / 12;
            icy = Math.Round((Double)icy, 0);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Icy"));

            //nby = Math.PI * Math.PI * eiy / (height0y * height0y) * 10000;
            //nby = Math.Round((Double)nby, 2);
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nby"));

            //niY2 = 1 / (1 - (project.Column.Statics.CompressiveForce / nby));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NiY2"));

            //bladNiY = (niY - NiY2) / niY2;
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BladNiY"));


            //        nbz = Math.PI * Math.PI * eiz / (height0z * height0z) * 10000;
            //        nbz = Math.Round((Double)nbz, 2);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nbz"));

            //        medy = project.Column.Statics.BendingMomentz * (1 + betaZ / ((nbz / project.Column.Statics.CompressiveForce) - 1));
            //        medy = Math.Round((Double)medy, 2);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Medy"));

            //        medz = project.Column.Statics.BendingMomenty * (1 + betaY / ((nby / project.Column.Statics.CompressiveForce) - 1));
            //        medz = Math.Round((Double)medz, 2);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Medz"));




        }
    }
}
