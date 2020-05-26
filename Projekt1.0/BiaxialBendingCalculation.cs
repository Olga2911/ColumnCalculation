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
            
        private Double lambdaZlambdaY = 0.0;
        private Double bEq = 0.0;
        private Double hEq= 0.0;
        private Double biaxialBendingCriterium1 = 0.0;
        private Double biaxialBendingCriterium2 = 0.0;
        private Double nEdNRd = 0.0;


        public event PropertyChangedEventHandler PropertyChanged;

        public BiaxialBendingCalculation(Project project)
        {
            Calculate(project);
        }

        public Double LambdaZlambdaY
        {
            get
            {
                return lambdaZlambdaY;
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






        public void Calculate(Project project)
        {
            lambdaZlambdaY=project.SecondOrderCalculations.Lambdaz/ project.SecondOrderCalculations.Lambday;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LambdaZlambdaY"));

            bEq = Math.Sqrt(12 * project.SecondOrderCalculations.Icy / project.BasicCalculations.AreaConcrete);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BEq"));

            hEq = Math.Sqrt(12 * project.SecondOrderCalculations.Icz / project.BasicCalculations.AreaConcrete); //cm
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HEq"));

            biaxialBendingCriterium1 = 0.01*(project.SecondOrderCalculations.Eiy/HEq)/ (project.SecondOrderCalculations.Eiz/ BEq);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BiaxialBendingCriterium1"));

            biaxialBendingCriterium2 = 0.01*(project.SecondOrderCalculations.Eiz/ BEq) / (project.SecondOrderCalculations.Eiy/ HEq);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BiaxialBendingCriterium2"));

            nEdNRd = project.Column.Statics.CompressiveForce / ((project.BasicCalculations.AreaConcrete * project.BasicCalculations.Fcd + project.BasicCalculations.AreaAs *0.01* project.BasicCalculations.Fyd) * 0.1);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NEdNRd"));






        }



    }

}

