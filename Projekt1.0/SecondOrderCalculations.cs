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

        private Double betaY = 0.0;
        private Double betaZ = 0.0;
        private Double nby = 0.0;
        private Double nbz = 0.0;
        private Double medy = 0.0;
        private Double medz = 0.0;
        private Double e1y = 0.0;
        private Double e1z = 0.0;
        private Double e0 = 0.0;

        private Double alfah = 0.0;
        private Double tetai = 0.0;
        private Double eiyi = 0.0;
        private Double eizi = 0.0;
        private Double ey = 0.0;
        private Double ez = 0.0;

        private String commentyY;
        private String warningY;
        private String commentyZ;
        private String warningZ;

        //private String eYComment;
        //private String eZComment;
        //private String eYWarning;
        //private String eZWarning;

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

        public Double BetaY
        {
            get
            {
                return betaY;
            }
        }

        public Double BetaZ
        {
            get
            {
                return betaZ;
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

        public Double Medy
        {
            get
            {
                return medy;
            }
        }

        public Double Medz
        {
            get
            {
                return medz;
            }
        }

        public Double E1z
        {
            get
            {
                return e1z;
            }
        }

        public Double E1y
        {
            get
            {
                return e1y;
            }
        }

        public Double E0
        {
            get
            {
                return e0;
            }
        }

        public Double Alfah
        {
            get
            {
                return alfah;
            }
        }

        public Double Tetai
        {
            get
            {
                return tetai;
            }
        }

        public Double Eiyi
        {
            get
            {
                return eiyi;
            }
        }

        public Double Eizi
        {
            get
            {
                return eizi;
            }
        }

        public Double Ey
        {
            get
            {
                return ey;
            }
        }

        public Double Ez
        {
            get
            {
                return ez;
            }
        }

        public String CommentyY
        {
            get
            {
                return commentyY;
            }
            set
            {
                commentyY = value;
            }
        }

        public String WarningY
        {
            get
            {
                return warningY;
            }
            set
            {
                warningY = value;
            }
        }

        public String CommentyZ
        {
            get
            {
                return commentyZ;
            }
            set
            {
                commentyZ = value;
            }
        }

        public String WarningZ
        {
            get
            {
                return warningZ;
            }
            set
            {
                warningZ = value;
            }
        }
        
        //public String EYComment
        //{
        //    get
        //    {
        //        return eYComment;
        //    }
        //    set
        //    {
        //        eYComment = value;
        //    }
        //}

        //public String EZComment
        //{
        //    get
        //    {
        //        return eZComment;
        //    }
        //    set
        //    {
        //        eZComment = value;
        //    }
        //}

        //public String EYWarning
        //{
        //    get
        //    {
        //        return eYWarning;
        //    }
        //    set
        //    {
        //        eYWarning = value;
        //    }
        //}

        //public String EZWarning
        //{
        //    get
        //    {
        //        return eZWarning;
        //    }
        //    set
        //    {
        //        eZWarning = value;
        //    }
        //}


        public void Calculate(Project project)
        {
            aParameter = 1 / (1 + 0.2 * project.BasicCalculations.FiEfektywne);
            aParameter = Math.Round((Double)aParameter, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AParameter"));

            omega = (project.BasicCalculations.AreaAs * project.BasicCalculations.Fyd) / (project.BasicCalculations.AreaConcrete * project.BasicCalculations.Fcd) * 0.01;
            omega = Math.Round((Double)omega, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Omega"));

            bParameter = Math.Sqrt(1 + 2 * omega);
            bParameter = Math.Round((Double)bParameter, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BParameter"));

            cParameter = 1.7 - project.Column.SecondOrderParameters.Rm;
            cParameter = Math.Round((Double)cParameter, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CParameter"));

            nForce = 10 * project.Column.Statics.CompressiveForce / (project.BasicCalculations.AreaConcrete * project.BasicCalculations.Fcd);
            nForce = Math.Round((Double)nForce, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NForce"));

            lambdalim = 20 * aParameter * BParameter * cParameter / Math.Sqrt(nForce);
            lambdalim = Math.Round((Double)lambdalim, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lambdalim"));

            height0y = project.Column.SecondOrderParameters.Miy * project.Column.Dimension.ColumnHeight;
            height0y = Math.Round((Double)height0y, 2);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Height0y"));

            lambday = height0y * Math.Sqrt(12) / project.Column.Dimension.Height;
            lambday = Math.Round((Double)lambday, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lambday"));

            height0z = project.Column.SecondOrderParameters.Miz * project.Column.Dimension.ColumnHeight;
            height0z = Math.Round((Double)height0z, 2);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Height0z"));

            lambdaz = height0z * Math.Sqrt(12) / project.Column.Dimension.Width;
            lambdaz = Math.Round((Double)lambdaz, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lambdaz"));

            k1 = Math.Sqrt(project.Column.Concrete.Fck / 20);
            k1 = Math.Round((Double)k1, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K1"));

            k2y = Math.Min(nForce * lambday / 170, 0.2);
            k2y = Math.Round((Double)k2y, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K2y"));

            kcy = k1 * k2y / (1 + project.BasicCalculations.FiEfektywne);
            kcy = Math.Round((Double)kcy, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Kcy"));

            icy = project.Column.Dimension.Width * project.Column.Dimension.Height * project.Column.Dimension.Height * project.Column.Dimension.Height / 12;
            icy = Math.Round((Double)icy, 0);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Icy"));

            isy = project.BasicCalculations.AreaAs1y * 0.01 * (0.5 * project.Column.Dimension.Height - project.BasicCalculations.A1y * 0.1) * (0.5 * project.Column.Dimension.Height - project.BasicCalculations.A1y * 0.1) +
                project.BasicCalculations.AreaAs2y * 0.01 * (0.5 * project.Column.Dimension.Height - project.BasicCalculations.A2y * 0.1) * (0.5 * project.Column.Dimension.Height - project.BasicCalculations.A2y * 0.1);
            isy = Math.Round((Double)isy, 0);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Isy"));

            eiy = kcy * project.Column.Concrete.Ecm * Icy * 0.01 + project.Column.SecondOrderParameters.Ks * project.Column.Steel.Es * Isy * 0.01;
            eiy = Math.Round((Double)eiy, 2);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Eiy"));

            k2z = Math.Min(nForce * lambdaz / 170, 0.2);
            k2z = Math.Round((Double)k2z, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K2z"));

            kcz = k1 * k2z / (1 + project.BasicCalculations.FiEfektywne);
            kcz = Math.Round((Double)kcz, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Kcz"));

            icz = project.Column.Dimension.Height * project.Column.Dimension.Width * project.Column.Dimension.Width * project.Column.Dimension.Width / 12;
            icz = Math.Round((Double)icz, 0);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Icz"));

            isz = project.BasicCalculations.AreaAs1z * 0.01 * (0.5 * project.Column.Dimension.Width - project.BasicCalculations.A1z * 0.1) * (0.5 * project.Column.Dimension.Width - project.BasicCalculations.A1z * 0.1) +
                project.BasicCalculations.AreaAs2z * 0.01 * (0.5 * project.Column.Dimension.Width - project.BasicCalculations.A2z * 0.1) * (0.5 * project.Column.Dimension.Width - project.BasicCalculations.A2z * 0.1);
            isz = Math.Round((Double)isz, 0);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Isz"));

            eiz = kcz * project.Column.Concrete.Ecm * Icz * 0.01 + project.Column.SecondOrderParameters.Ks * project.Column.Steel.Es * Isz * 0.01;
            eiz = Math.Round((Double)eiz, 2);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Eiz"));



            betaY = Math.PI * Math.PI / project.Column.SecondOrderParameters.C0Y;
            betaY = Math.Round((Double)betaY, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BetaY"));

            betaZ = Math.PI * Math.PI / project.Column.SecondOrderParameters.C0Z;
            betaZ = Math.Round((Double)betaZ, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BetaZ"));


            nby = Math.PI * Math.PI * eiy / (height0y * height0y) * 10000;
            nby = Math.Round((Double)nby, 2);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nby"));

            nbz = Math.PI * Math.PI * eiz / (height0z * height0z) * 10000;
            nbz = Math.Round((Double)nbz, 2);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nbz"));

            medy = project.Column.Statics.BendingMomentz * (1 + betaZ / ((nbz / project.Column.Statics.CompressiveForce) - 1));
            medy = Math.Round((Double)medy, 2);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Medy"));

            medz = project.Column.Statics.BendingMomenty * (1 + betaY / ((nby / project.Column.Statics.CompressiveForce) - 1));
            medz = Math.Round((Double)medz, 2);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Medz"));

            e0 = 0.01 * Math.Max(project.Column.Dimension.Height / 30, 2);
            e0 = Math.Round((Double)e0, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("E0"));

            e1y = Math.Max(medz/project.Column.Statics.CompressiveForce, e0);
            e1y = Math.Round((Double)e1y, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("E1y"));

            e1z = Math.Max(medy / project.Column.Statics.CompressiveForce, e0);
            e1z = Math.Round((Double)e1z, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("E1z"));

            alfah = Math.Min(Math.Max(2 / Math.Sqrt(project.Column.Dimension.ColumnHeight * 0.01), 2 / 3), 1);
            alfah = Math.Round((Double)alfah, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Alfah"));

            tetai = alfah / 200;
            tetai = Math.Round((Double)tetai, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tetai"));

            eiyi = 0.5 * tetai * height0y / 100;
            eiyi = Math.Round((Double)eiyi, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Eiyi"));

            eizi = 0.5 * tetai * height0z / 100;
            eizi = Math.Round((Double)eizi, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Eizi"));

            ey = e1y+eiyi;
            ey = Math.Round((Double)ey, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ey"));

            ez = eizi+e1z;
            ez = Math.Round((Double)ez, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ez"));

            if (lambday <= lambdalim)
            {
                commentyY = "SPEŁNIONY";
                warningY = "Efekty II-go rzędu można pominąć.";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("commentyY"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("warningY"));
            }
            else
            {
                commentyY = "NIESPEŁNIONY";
                warningY = "Należy uwzględnić efekty II-go rzędu.";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("commentyY"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("warningY"));
            }

            if (lambdaz <= lambdalim)
            {
                commentyZ = "SPEŁNIONY";
                warningZ = "Efekty II-go rzędu można pominąć.";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("commentyZ"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("warningZ"));
            }
            else
            {
                commentyZ = "NIESPEŁNIONY";
                warningZ = "Należy uwzględnić efekty II-go rzędu.";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("commentyZ"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("warningZ"));
            }

            //if (ey <= e0)
            //{
            //    eYComment = "SPEŁNIONY";
            //    eYWarning = "Wpływ imperfekcji można pominąć.";
            //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("eYComment"));
            //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("eYWarning"));
            //}
            //else
            //{
            //    eYComment = "NIESPEŁNIONY";
            //    eYWarning = "Należy uwzględnić wpływ imperfekcji.";
            //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("eYComment"));
            //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("eYWarning"));
            //}

        }
    }
}






