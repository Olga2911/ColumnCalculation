using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class BiaxialBendingCalculation : INotifyPropertyChanged
    {
            
        //private Double lambdaZlambdaY = 0.0;
        private Double lambdaYlambdaZ = 0.0;
        private Double bEq = 0.0;
        private Double hEq= 0.0;
        private Double biaxialBendingCriterium1 = 0.0;
        private Double biaxialBendingCriterium2 = 0.0;
        private Double nEdNRd = 0.0;

        private String biaxalConditionChecking1Comment;
        private String biaxalConditionChecking2Comment;
        private String biaxalbendingComment;

        public event PropertyChangedEventHandler PropertyChanged;

        public BiaxialBendingCalculation(Project project)
        {
            Calculate(project);
        }

        //public Double LambdaZlambdaY
        //{
        //    get
        //    {
        //        return lambdaZlambdaY;
        //    }
        //}

        public Double LambdaYlambdaZ
        {
            get
            {
                return lambdaYlambdaZ;
            }
        }

        public Double BEq
        {
            get
            {
                return bEq;
            }
        }

        public Double HEq
        {
            get
            {
                return hEq;
            }
        }

        public Double BiaxialBendingCriterium1
        {
            get
            {
                return biaxialBendingCriterium1;
            }
        }

        public Double BiaxialBendingCriterium2
        {
            get
            {
                return biaxialBendingCriterium2;
            }
        }

        public Double NEdNRd
        {
            get
            {
                return nEdNRd;
            }
        }

        public String BiaxalConditionChecking1Comment
        {
            get
            {
                return biaxalConditionChecking1Comment;
            }
            set
            {
                biaxalConditionChecking1Comment = value;
            }
        }

        public String BiaxalConditionChecking2Comment
        {
            get
            {
                return biaxalConditionChecking2Comment;
            }
            set
            {
                biaxalConditionChecking2Comment = value;
            }
        }




        public void Calculate(Project project)
        {
            //lambdaZlambdaY=project.SecondOrderCalculations.Lambdaz/ project.SecondOrderCalculations.Lambday;
            //lambdaZlambdaY = Math.Round((Double)lambdaZlambdaY, 2);
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LambdaZlambdaY"));

            lambdaYlambdaZ = project.SecondOrderCalculations.Lambday / project.SecondOrderCalculations.Lambdaz;
            lambdaYlambdaZ = Math.Round((Double)lambdaYlambdaZ, 2);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LambdaYlambdaZ"));

            if (0.5 <= lambdaYlambdaZ && lambdaYlambdaZ <= 2)
            {
                biaxalConditionChecking1Comment = "SPEŁNIONY";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BiaxalConditionChecking1Comment"));
            }

            else
            {
                biaxalConditionChecking1Comment = "NIESPEŁNIONY";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BiaxalConditionChecking1Comment"));
            }

            bEq = Math.Sqrt(12 * project.SecondOrderCalculations.Icy / project.BasicCalculations.AreaConcrete);
            bEq = Math.Round((Double)bEq, 2);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BEq"));

            hEq = Math.Sqrt(12 * project.SecondOrderCalculations.Icz / project.BasicCalculations.AreaConcrete); //cm
            hEq = Math.Round((Double)hEq, 2);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HEq"));

            biaxialBendingCriterium1 = (project.SecondOrderCalculations.Ey/HEq)/(project.SecondOrderCalculations.Ez/ BEq);
            biaxialBendingCriterium1 = Math.Round((Double)biaxialBendingCriterium1, 2);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BiaxialBendingCriterium1"));

            biaxialBendingCriterium2 = (project.SecondOrderCalculations.Ez/ BEq)/(project.SecondOrderCalculations.Ey/ HEq);
            biaxialBendingCriterium2 = Math.Round((Double)biaxialBendingCriterium2, 2);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BiaxialBendingCriterium2"));

            if ((biaxialBendingCriterium1 <= 0.2) || (biaxialBendingCriterium2 <= 0.2))
            {
                biaxalConditionChecking2Comment = "SPEŁNIONY";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BiaxalConditionChecking1Comment"));
            }

            else
            {
                biaxalConditionChecking2Comment = "NIESPEŁNIONY";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BiaxalConditionChecking1Comment"));
            }


            


            nEdNRd = project.Column.Statics.CompressiveForce / ((project.BasicCalculations.AreaConcrete * project.BasicCalculations.Fcd + project.BasicCalculations.AreaAs *0.01* project.BasicCalculations.Fyd) * 0.1);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NEdNRd"));



            



        }



    }

}

