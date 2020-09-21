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
        private Double fiEffY = 0.0;
        private Double fiEffZ = 0.0;

        private Double aParameterY = 0.0;
        private Double aParameterZ = 0.0;

        private Double nForce = 0.0;
        private Double lambdalimY = 0.0;
        private Double lambdalimZ = 0.0;
        private Double height0y = 0.0;
        private Double lambday = 0.0;
        private Double height0z = 0.0;
        private Double lambdaz = 0.0;

        private Double e0 = 0.0;
        private Double eey = 0.0;
        private Double eez = 0.0;
        private Double e0y = 0.0;
        private Double e0z = 0.0;
        private Double eTotY = 0.0;
        private Double eTotZ = 0.0;
        private Double es1y = 0.0;
        private Double es2y = 0.0;
        private Double es1z = 0.0;
        private Double es2z = 0.0;

        private String commentyY = "";
        private String warningY;
        private String commentyZ;
        private String warningZ;

        //    //private String eYComment;
        //    //private String eZComment;
        //    //private String eYWarning;
        //    //private String eZWarning;


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
            //fiEffY = Math.Round((Double)fiEffY, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiEffY"));

            fiEffZ = project.Column.EnvironmentalCondition.FiKoncowe * project.Column.Statics.BendingMomentqpz / project.Column.Statics.BendingMomentz;
            //fiEffZ = Math.Round((Double)fiEffZ, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiEffZ"));

            aParameterY =1/(1+0.2*fiEffY);
            //aParameterY = Math.Round((Double)aParameterY, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AParameterY"));

            aParameterZ = 1 / (1 + 0.2 * fiEffZ);
            //aParameterZ = Math.Round((Double)aParameterZ, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AParameterZ"));

            nForce = 10 * project.Column.Statics.CompressiveForce / (project.BasicCalculations.AreaConcrete * project.BasicCalculations.Fcd);
            //nForce = Math.Round((Double)nForce, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NForce"));

            lambdalimY = 20 * aParameterY * project.Column.SecondOrderParameters.BParameter * project.Column.SecondOrderParameters.CParameter / Math.Sqrt(nForce);
            //lambdalimY = Math.Round((Double)lambdalimY, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LambdalimY"));

            lambdalimZ = 20 * aParameterZ * project.Column.SecondOrderParameters.BParameter * project.Column.SecondOrderParameters.CParameter / Math.Sqrt(nForce);
            //lambdalimZ = Math.Round((Double)lambdalimZ, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LambdalimZ"));

            height0y = project.Column.SecondOrderParameters.Miy * project.Column.Dimension.ColumnHeight;
            //height0y = Math.Round((Double)height0y, 2);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Height0y"));

            lambday = height0y * Math.Sqrt(12) / project.Column.Dimension.Height;
            //lambday = Math.Round((Double)lambday, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lambday"));

            height0z = project.Column.SecondOrderParameters.Miz * project.Column.Dimension.ColumnHeight;
            //height0z = Math.Round((Double)height0z, 2);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Height0z"));

            lambdaz = height0z * Math.Sqrt(12) / project.Column.Dimension.Width;
            //lambdaz = Math.Round((Double)lambdaz, 3);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lambdaz"));


            if (lambday <= lambdalimY)
            {
                commentyY = "SPEŁNIONY";
                warningY = "Pomija się efekty II-go rzędu.";
                project.Column.SecondOrderParameters.NiY = 1.0;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("commentyY"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("warningY"));
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NiY"));

            }
            else
            {
                commentyY = "NIESPEŁNIONY";
                warningY = "Uwzględnia się efekty II-go rzędu.";
                project.Column.SecondOrderParameters.NiY = 1.001; 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("commentyY"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("warningY"));
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NiY"));
            }

            if (lambdaz <= lambdalimZ)
            {
                commentyZ = "SPEŁNIONY";
                warningZ = "Pomija się efekty II-go rzędu.";
                project.Column.SecondOrderParameters.NiZ = 1.0;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("commentyZ"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("warningZ"));
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NiZ"));
            }
            else
            {
                commentyZ = "NIESPEŁNIONY";
                warningZ = "Uwzględnia się efekty II-go rzędu.";
                project.Column.SecondOrderParameters.NiZ = 1.001;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("commentyZ"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("warningZ"));
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NiZ"));
            }


            e0 = 0.01 * Math.Max(project.Column.Dimension.Height / 30.0, 2);
                //e0 = Math.Round((Double) e0, 4);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("E0"));

                eey = project.Column.Statics.BendingMomenty / project.Column.Statics.CompressiveForce;
                //eey = Math.Round((Double)eey, 4);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Eey"));

                eez = project.Column.Statics.BendingMomentz / project.Column.Statics.CompressiveForce;
                //eez = Math.Round((Double)eez, 4);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Eez"));

            e0y = eey+e0;
            //e0y = Math.Round((Double)e0y, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("E0y"));

            e0z = eez+e0;
            //e0z = Math.Round((Double)e0z, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("E0z"));

            eTotY = project.Column.SecondOrderParameters.NiY * e0y;
            //eTotY = Math.Round((Double)eTotY, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ETotY"));

            eTotZ = project.Column.SecondOrderParameters.NiZ * e0z;
            //eTotZ = Math.Round((Double)eTotZ, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ETotZ"));

            es1y = eTotY+0.5*project.Column.Dimension.Height*0.01-project.BasicCalculations.A1y*0.001;
            //es1y = Math.Round((Double)es1y, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Es1y"));

            es2y = -eTotY + 0.5 * project.Column.Dimension.Height*0.01 - project.BasicCalculations.A2y*0.001;
            //es2y = Math.Round((Double)es2y, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Es2y"));

            es1z = eTotZ + 0.5 * project.Column.Dimension.Width*0.01 - project.BasicCalculations.A1z*0.001;
            //es1z = Math.Round((Double)es1z, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Es1z"));

            es2z = -eTotZ + 0.5 * project.Column.Dimension.Width*0.01 - project.BasicCalculations.A2z*0.001;
            //es2z = Math.Round((Double)es2z, 4);
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

            //k1 = Math.Sqrt(project.Column.Concrete.Fck / 20);
            //k1 = Math.Round((Double)k1, 4);
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K1"));

            //k2y = Math.Min(nForce * lambday / 170, 0.2);
            //k2y = Math.Round((Double)k2y, 4);
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K2y"));

            //kcy = k1 * k2y / (1 + fiEffY);
            //kcy = Math.Round((Double)kcy, 4);
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Kcy"));

            //icy = project.Column.Dimension.Width * project.Column.Dimension.Height * project.Column.Dimension.Height * project.Column.Dimension.Height / 12;
            //icy = Math.Round((Double)icy, 0);
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Icy"));

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






