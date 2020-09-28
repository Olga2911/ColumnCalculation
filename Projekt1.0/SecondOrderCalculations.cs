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

        private String commentY;
        private String warningY;
        private String commentZ;
        private String warningZ;

        public event PropertyChangedEventHandler PropertyChanged;

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

        public String CommentY
        {
            get
            {
                return commentY;
            }
            set
            {
                commentY = value;
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

        public String CommentZ
        {
            get
            {
                return commentZ;
            }
            set
            {
                commentZ = value;
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
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiEffY"));

            fiEffZ = project.Column.EnvironmentalCondition.FiKoncowe * project.Column.Statics.BendingMomentqpz / project.Column.Statics.BendingMomentz;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiEffZ"));

            aParameterY =1/(1+0.2*fiEffY);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AParameterY"));

            aParameterZ = 1 / (1 + 0.2 * fiEffZ);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AParameterZ"));

            nForce = 10 * project.Column.Statics.CompressiveForce / (project.BasicCalculations.AreaConcrete * project.BasicCalculations.Fcd);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NForce"));

            lambdalimY = 20 * aParameterY * project.Column.SecondOrderParameters.BParameter * project.Column.SecondOrderParameters.CParameter / Math.Sqrt(nForce);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LambdalimY"));

            lambdalimZ = 20 * aParameterZ * project.Column.SecondOrderParameters.BParameter * project.Column.SecondOrderParameters.CParameter / Math.Sqrt(nForce);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LambdalimZ"));

            height0y = project.Column.SecondOrderParameters.Miy * project.Column.Dimension.ColumnHeight;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Height0y"));

            lambday = height0y * Math.Sqrt(12) / project.Column.Dimension.Height;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lambday"));

            height0z = project.Column.SecondOrderParameters.Miz * project.Column.Dimension.ColumnHeight;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Height0z"));

            lambdaz = height0z * Math.Sqrt(12) / project.Column.Dimension.Width;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lambdaz"));


            if (lambday <= lambdalimY)
            {
                commentY = "SPEŁNIONY";
                warningY = "Pomija się efekty II-go rzędu.";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CommentY"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("WarningY"));
            }
            else
            {
                commentY = "NIESPEŁNIONY";
                warningY = "Uwzględnia się efekty II-go rzędu.";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CommentY"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("WarningY"));
            }

            if (lambdaz <= lambdalimZ)
            {
                commentZ = "SPEŁNIONY";
                warningZ = "Pomija się efekty II-go rzędu.";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CommentZ"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("WarningZ"));
            }
            else
            {
                commentZ = "NIESPEŁNIONY";
                warningZ = "Uwzględnia się efekty II-go rzędu.";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CommentZ"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("WarningZ"));
            }


            e0 = 0.01 * Math.Max(project.Column.Dimension.Height / 30.0, 2);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("E0"));

                eey = project.Column.Statics.BendingMomenty / project.Column.Statics.CompressiveForce;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Eey"));

                eez = project.Column.Statics.BendingMomentz / project.Column.Statics.CompressiveForce;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Eez"));

            e0y = eey+e0;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("E0y"));

            e0z = eez+e0;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("E0z"));

            eTotY = project.NiChecking.NiY * e0y;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ETotY"));

            eTotZ = project.NiChecking.NiZ * e0z;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ETotZ"));

            es1y = eTotY+0.5*project.Column.Dimension.Height*0.01-project.BasicCalculations.A1y*0.001;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Es1y"));

            es2y = -eTotY + 0.5 * project.Column.Dimension.Height*0.01 - project.BasicCalculations.A2y*0.001;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Es2y"));

            es1z = eTotZ + 0.5 * project.Column.Dimension.Width*0.01 - project.BasicCalculations.A1z*0.001;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Es1z"));

            es2z = -eTotZ + 0.5 * project.Column.Dimension.Width*0.01 - project.BasicCalculations.A2z*0.001;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Es2z"));

        }
    }
}






