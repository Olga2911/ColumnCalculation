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
        private Double aParameterY = 0.0;
        private Double aParameterZ = 0.0;
        private Double omega = 0.0;
        private Double bParameter = 0.0;
        private Double cParameter = 0.0;
        private Double nForce = 0.0;
        private Double lambdalimY = 0.0;
        private Double lambdalimZ = 0.0;
        private Double height0y = 0.0;
        private Double lambday = 0.0;
        private Double height0z = 0.0;
        private Double lambdaz = 0.0;
        //    private Double k1 = 0.0;
        //    private Double k2y = 0.0;
        //    private Double kcy = 0.0;
        //    private Double icy = 0.0;
        //    private Double isy = 0.0;
        //    private Double k2z = 0.0;
        //    private Double kcz = 0.0;
        //    private Double icz = 0.0;
        //    private Double isz = 0.0;
        //    private Double eiy = 0.0;
        //    private Double eiz = 0.0;

        //    private Double betaY = 0.0;
        //    private Double betaZ = 0.0;
        //    private Double nby = 0.0;
        //    private Double nbz = 0.0;
        //    private Double medy = 0.0;
        //    private Double medz = 0.0;
        private Double e0 = 0.0;
        private Double eey = 0.0;
        private Double eez = 0.0;
        //    private Double alfah = 0.0;
        //    private Double tetai = 0.0;
        private Double e0y = 0.0;
        private Double e0z = 0.0;
        private Double niY = 0.0;
        private Double niZ = 0.0;
        private Double eTotY = 0.0;
        private Double eTotZ = 0.0;
        //    private Double ey = 0.0;
        //    private Double ez = 0.0;

        private Double es1y = 0.0;
        private Double es2y = 0.0;
        private Double es1z = 0.0;
        private Double es2z = 0.0;


        private String commentyY;
        private String warningY;
        private String commentyZ;
        private String warningZ;

        //    //private String eYComment;
        //    //private String eZComment;
        //    //private String eYWarning;
        //    //private String eZWarning;

        private Double fiEffY = 0;
        private Double fiEffZ = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        public SecondOrderCalculations(Project project)
        {
            Calculate(project);
        }

        public Double AParameterY
        {
            get
            {
                return aParameterY;
            }
        }

        public Double AParameterZ
        {
            get
            {
                return aParameterZ;
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

        public Double LambdalimY
        {
            get
            {
                return lambdalimY;
            }
        }

        public Double LambdalimZ
        {
            get
            {
                return lambdalimZ;
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

        //    public Double K1
        //    {
        //        get
        //        {
        //            return k1;
        //        }
        //    }

        //    public Double K2y
        //    {
        //        get
        //        {
        //            return k2y;
        //        }
        //    }

        //    public Double Kcy
        //    {
        //        get
        //        {
        //            return kcy;
        //        }
        //    }

        //    public Double Icy
        //    {
        //        get
        //        {
        //            return icy;
        //        }
        //    }

        //    public Double Isy
        //    {
        //        get
        //        {
        //            return isy;
        //        }
        //    }

        //    public Double Eiy
        //    {
        //        get
        //        {
        //            return eiy;
        //        }
        //    }

        //    public Double K2z
        //    {
        //        get
        //        {
        //            return k2z;
        //        }
        //    }

        //    public Double Kcz
        //    {
        //        get
        //        {
        //            return kcz;
        //        }
        //    }

        //    public Double Icz
        //    {
        //        get
        //        {
        //            return icz;
        //        }
        //    }

        //    public Double Isz
        //    {
        //        get
        //        {
        //            return isz;
        //        }
        //    }

        //    public Double Eiz
        //    {
        //        get
        //        {
        //            return eiz;
        //        }
        //    }

        //    public Double BetaY
        //    {
        //        get
        //        {
        //            return betaY;
        //        }
        //    }

        //    public Double BetaZ
        //    {
        //        get
        //        {
        //            return betaZ;
        //        }
        //    }

        //    public Double Nby
        //    {
        //        get
        //        {
        //            return nby;
        //        }
        //    }

        //    public Double Nbz
        //    {
        //        get
        //        {
        //            return nbz;
        //        }
        //    }

        //    public Double Medy
        //    {
        //        get
        //        {
        //            return medy;
        //        }
        //    }

        //    public Double Medz
        //    {
        //        get
        //        {
        //            return medz;
        //        }
        //    }

        public Double Eez
        {
            get
            {
                return eez;
            }
        }

        public Double Eey
        {
            get
            {
                return eey;
            }
        }

        public Double E0
        {
            get
            {
                return e0;
            }
        }

        //    public Double Alfah
        //    {
        //        get
        //        {
        //            return alfah;
        //        }
        //    }

        //    public Double Tetai
        //    {
        //        get
        //        {
        //            return tetai;
        //        }
        //    }

        public Double E0y
        {
            get
            {
                return e0y;
            }
        }

        public Double E0z
        {
            get
            {
                return e0z;
            }
        }

        public Double ETotY
        {
            get
            {
                return eTotY;
            }
        }

        public Double ETotZ
        {
            get
            {
                return eTotZ;
            }
        }

        public Double Es1y
        {
            get
            {
                return es1y;
            }
        }

        public Double Es2y
        {
            get
            {
                return es2y;
            }
        }

        public Double Es1z
        {
            get
            {
                return es1z;
            }
        }

        public Double Es2z
        {
            get
            {
                return es2z;
            }
        }


        public Double NiY
        {
            get
            {
                return niY;
            }
        }

        public Double NiZ
        {
            get
            {
                return niZ;
            }
        }


        //    public Double Ey
        //    {
        //        get
        //        {
        //            return ey;
        //        }
        //    }

        //    public Double Ez
        //    {
        //        get
        //        {
        //            return ez;
        //        }
        //    }

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

        //    //public String EYComment
        //    //{
        //    //    get
        //    //    {
        //    //        return eYComment;
        //    //    }
        //    //    set
        //    //    {
        //    //        eYComment = value;
        //    //    }
        //    //}

        //    //public String EZComment
        //    //{
        //    //    get
        //    //    {
        //    //        return eZComment;
        //    //    }
        //    //    set
        //    //    {
        //    //        eZComment = value;
        //    //    }
        //    //}

        //    //public String EYWarning
        //    //{
        //    //    get
        //    //    {
        //    //        return eYWarning;
        //    //    }
        //    //    set
        //    //    {
        //    //        eYWarning = value;
        //    //    }
        //    //}

        //    //public String EZWarning
        //    //{
        //    //    get
        //    //    {
        //    //        return eZWarning;
        //    //    }
        //    //    set
        //    //    {
        //    //        eZWarning = value;
        //    //    }
        //    //}

        public Double FiEffY
        {
            get
            {
                return fiEffY;
            }
        }

        public Double FiEffZ
        {
            get
            {
                return fiEffZ;
            }
        }

        public void Calculate(Project project)
        {
            fiEffY = project.Column.EnvironmentalCondition.FiKoncowe * project.Column.Statics.BendingMomentqpy / project.Column.Statics.BendingMomenty;
            fiEffY = Math.Round((Double)fiEffY, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiEffY"));

            fiEffZ = project.Column.EnvironmentalCondition.FiKoncowe * project.Column.Statics.BendingMomentqpz / project.Column.Statics.BendingMomentz;
            fiEffZ = Math.Round((Double)fiEffZ, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiEffZ"));

            aParameterY =1/(1+0.2*fiEffZ);
            aParameterY = Math.Round((Double)aParameterY, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AParameterY"));

            aParameterZ = 1 / (1 + 0.2 * fiEffY);
            aParameterZ = Math.Round((Double)aParameterZ, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AParameterZ"));

            //omega = (project.BasicCalculations.AreaAs * project.BasicCalculations.Fyd) / (project.BasicCalculations.AreaConcrete * project.BasicCalculations.Fcd) * 0.01;
            //omega = Math.Round((Double)omega, 3);
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Omega"));

            //bParameter = Math.Sqrt(1 + 2 * omega);
            bParameter = 1.1;
            bParameter = Math.Round((Double)bParameter, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BParameter"));

            cParameter = 1.7 - project.Column.SecondOrderParameters.Rm;
            cParameter = Math.Round((Double)cParameter, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CParameter"));

            nForce = 10 * project.Column.Statics.CompressiveForce / (project.BasicCalculations.AreaConcrete * project.BasicCalculations.Fcd);
            nForce = Math.Round((Double)nForce, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NForce"));

            lambdalimY = 20 * aParameterY * BParameter * cParameter / Math.Sqrt(nForce);
            lambdalimY = Math.Round((Double)lambdalimY, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LambdalimY"));

            lambdalimZ = 20 * aParameterZ * BParameter * cParameter / Math.Sqrt(nForce);
            lambdalimZ = Math.Round((Double)lambdalimZ, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LambdalimZ"));

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

            //        k1 = Math.Sqrt(project.Column.Concrete.Fck / 20);
            //        k1 = Math.Round((Double)k1, 4);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K1"));

            //        k2y = Math.Min(nForce * lambday / 170, 0.2);
            //        k2y = Math.Round((Double)k2y, 4);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K2y"));

            //        kcy = k1 * k2y / (1 + project.BasicCalculations.FiEfektywne);
            //        kcy = Math.Round((Double)kcy, 4);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Kcy"));

            //        icy = project.Column.Dimension.Width * project.Column.Dimension.Height * project.Column.Dimension.Height * project.Column.Dimension.Height / 12;
            //        icy = Math.Round((Double)icy, 0);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Icy"));

            //        isy = project.BasicCalculations.AreaAs1y * 0.01 * (0.5 * project.Column.Dimension.Height - project.BasicCalculations.A1y * 0.1) * (0.5 * project.Column.Dimension.Height - project.BasicCalculations.A1y * 0.1) +
            //            project.BasicCalculations.AreaAs2y * 0.01 * (0.5 * project.Column.Dimension.Height - project.BasicCalculations.A2y * 0.1) * (0.5 * project.Column.Dimension.Height - project.BasicCalculations.A2y * 0.1);
            //        isy = Math.Round((Double)isy, 0);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Isy"));

            //        eiy = kcy * project.Column.Concrete.Ecm * Icy * 0.01 + project.Column.SecondOrderParameters.Ks * project.Column.Steel.Es * Isy * 0.01;
            //        eiy = Math.Round((Double)eiy, 2);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Eiy"));

            //        k2z = Math.Min(nForce * lambdaz / 170, 0.2);
            //        k2z = Math.Round((Double)k2z, 4);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K2z"));

            //        kcz = k1 * k2z / (1 + project.BasicCalculations.FiEfektywne);
            //        kcz = Math.Round((Double)kcz, 4);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Kcz"));

            //        icz = project.Column.Dimension.Height * project.Column.Dimension.Width * project.Column.Dimension.Width * project.Column.Dimension.Width / 12;
            //        icz = Math.Round((Double)icz, 0);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Icz"));

            //        isz = project.BasicCalculations.AreaAs1z * 0.01 * (0.5 * project.Column.Dimension.Width - project.BasicCalculations.A1z * 0.1) * (0.5 * project.Column.Dimension.Width - project.BasicCalculations.A1z * 0.1) +
            //            project.BasicCalculations.AreaAs2z * 0.01 * (0.5 * project.Column.Dimension.Width - project.BasicCalculations.A2z * 0.1) * (0.5 * project.Column.Dimension.Width - project.BasicCalculations.A2z * 0.1);
            //        isz = Math.Round((Double)isz, 0);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Isz"));

            //        eiz = kcz * project.Column.Concrete.Ecm * Icz * 0.01 + project.Column.SecondOrderParameters.Ks * project.Column.Steel.Es * Isz * 0.01;
            //        eiz = Math.Round((Double)eiz, 2);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Eiz"));



            //        betaY = Math.PI * Math.PI / project.Column.SecondOrderParameters.C0Y;
            //        betaY = Math.Round((Double)betaY, 3);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BetaY"));

            //        betaZ = Math.PI * Math.PI / project.Column.SecondOrderParameters.C0Z;
            //        betaZ = Math.Round((Double)betaZ, 3);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BetaZ"));


            //        nby = Math.PI * Math.PI * eiy / (height0y * height0y) * 10000;
            //        nby = Math.Round((Double)nby, 2);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nby"));

            //        nbz = Math.PI * Math.PI * eiz / (height0z * height0z) * 10000;
            //        nbz = Math.Round((Double)nbz, 2);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nbz"));

            //        medy = project.Column.Statics.BendingMomentz * (1 + betaZ / ((nbz / project.Column.Statics.CompressiveForce) - 1));
            //        medy = Math.Round((Double)medy, 2);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Medy"));

            //        medz = project.Column.Statics.BendingMomenty * (1 + betaY / ((nby / project.Column.Statics.CompressiveForce) - 1));
            //        medz = Math.Round((Double)medz, 2);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Medz"));

            e0 = 0.01 * Math.Max(project.Column.Dimension.Height / 30, 2);
                e0 = Math.Round((Double) e0, 4);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("E0"));

                eey = project.Column.Statics.BendingMomenty / project.Column.Statics.CompressiveForce;
                eey = Math.Round((Double)eey, 4);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Eey"));

                eez = project.Column.Statics.BendingMomentz / project.Column.Statics.CompressiveForce;
                eez = Math.Round((Double)eez, 4);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Eez"));

            //        alfah = Math.Min(Math.Max(2 / Math.Sqrt(project.Column.Dimension.ColumnHeight * 0.01), 2 / 3), 1);
            //        alfah = Math.Round((Double)alfah, 3);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Alfah"));

            //        tetai = alfah / 200;
            //        tetai = Math.Round((Double)tetai, 3);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tetai"));

            e0y = eey+e0;
            e0y = Math.Round((Double)e0y, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("E0y"));

            e0z = eez+e0;
            e0z = Math.Round((Double)e0z, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("E0z"));

            //        ey = e1y+eiyi;
            //        ey = Math.Round((Double)ey, 4);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ey"));

            //        ez = eizi+e1z;
            //        ez = Math.Round((Double)ez, 4);
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ez"));

            if (lambday <= lambdalimY)
            {
                commentyY = "SPEŁNIONY";
                warningY = "Pomija się efekty II-go rzędu.";
                niY = 1.0;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("commentyY"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("warningY"));
            }
            else
            {
                commentyY = "NIESPEŁNIONY";
                warningY = "Uwzględnia się efekty II-go rzędu.";
                niY = 1.752; //POPRAWIĆ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("commentyY"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("warningY"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NiY"));
            }

            if (lambdaz <= lambdalimZ)
            {
                commentyZ = "SPEŁNIONY";
                warningZ = "Pomija się efekty II-go rzędu.";
                niZ = 1.0;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("commentyZ"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("warningZ"));
            }
            else
            {
                commentyZ = "NIESPEŁNIONY";
                warningZ = "Uwzględnia się efekty II-go rzędu.";
                niZ = 2.005; //POPRAWIĆ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("commentyZ"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("warningZ"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NiZ"));
            }

            eTotY = niY * e0y;
            eTotY = Math.Round((Double)eTotY, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ETotY"));

            eTotZ = niZ * e0z;
            eTotZ = Math.Round((Double)eTotZ, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ETotZ"));

            es1y = eTotY+0.5*project.Column.Dimension.Height*0.01-project.BasicCalculations.A1y*0.001;
            es1y = Math.Round((Double)es1y, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Es1y"));

            es2y = -eTotY + 0.5 * project.Column.Dimension.Height*0.01 - project.BasicCalculations.A2y*0.001;
            es2y = Math.Round((Double)es2y, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Es2y"));

            es1z = eTotZ + 0.5 * project.Column.Dimension.Width*0.01 - project.BasicCalculations.A1z*0.001;
            es1z = Math.Round((Double)es1z, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Es1z"));

            es2z = -eTotZ + 0.5 * project.Column.Dimension.Width*0.01 - project.BasicCalculations.A2z*0.001;
            es2z = Math.Round((Double)es2z, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Es2z"));


            //        //if (ey <= e0)
            //        //{
            //        //    eYComment = "SPEŁNIONY";
            //        //    eYWarning = "Wpływ imperfekcji można pominąć.";
            //        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("eYComment"));
            //        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("eYWarning"));
            //        //}
            //        //else
            //        //{
            //        //    eYComment = "NIESPEŁNIONY";
            //        //    eYWarning = "Należy uwzględnić wpływ imperfekcji.";
            //        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("eYComment"));
            //        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("eYWarning"));
            //        //}

            //    }
        }
    }
}






