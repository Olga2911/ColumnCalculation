using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class CheckEccentricity
    {
        private Double eE = 0.0;
        private Double eA = 0.0;
        private Double e0 = 0.0;
        private Double eta = 2.2;
        private Double eTot = 0.0;
        private Double eS1 = 0.0;
        private Double eS2 = 0.0;
        private Double aSmin = 0.0;

        public Double EE
        {
            get
            {
                return eE;
            }
        }

        public Double EA
        {
            get
            {
                return eA;
            }
        }

        public Double E0
        {
            get
            {
                return e0;
            }
        }

        public Double Eta
        {
            get
            {
                return eta;
            }
            set
            {
                if (value>0)
                {
                    eta = value;
                }
            }
        }

        public Double ETot
        {
            get
            {
                return eTot;
            }
        }

        public Double ES1
        {
            get
            {
                return eS1;
            }
        }

        public Double ES2
        {
            get
            {
                return eS2;
            }
        }

        public Double ASmin
        {
            get
            {
                return aSmin;
            }
            set
            {
                if (value > 0)
                {
                    aSmin = value;
                }
            }

        }


        public void UpdateData(Dimension characteristic, Statics statics)
        {
            Calculate(characteristic, statics);
                    }


        public void Calculate(Dimension characteristic, Statics statics)
        {
            eE = statics.BendingMomenty / statics.CompressiveForce;

           // double ea1 = statics.ColumnHeight / 600;
            double ea2 = characteristic.Height / 30;
            double ea3 =0.01;

          //  eA = Math.Max(ea1, Math.Max(ea2, ea3));
            e0 = eE + eA;
            eTot = eta * e0;
            //eS1 = eTot + 0.5*characteristic.Height-characteristic.AReinforcement;
            //eS2=eTot - 0.5 * characteristic.Height - characteristic.AReinforcement;

            double asmin1 = 0.15 * statics.CompressiveForce;

        }
    }


}
