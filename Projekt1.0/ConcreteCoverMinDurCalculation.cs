using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class ConcreteCoverMinDurCalculation : INotifyPropertyChanged

    {
        private Double cMinDur = 10.0;

        public event PropertyChangedEventHandler PropertyChanged;

        public ConcreteCoverMinDurCalculation(Project project)
        {
            Calculate(project);
        }

        public double CMinDur
        {
            get
            {
                return cMinDur;
            }
        }

        public void Calculate(Project project)
        {
            if (project.Column.ConcreteCoverMinDur.ExposureClassDescription == "X0")
            {
                if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S1" || project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S2" || project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S3" || project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S4")
                {
                    cMinDur = 10;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S5")
                {
                    cMinDur = 15;
                }
                else
                {
                    cMinDur = 20;
                }
            }

            else if (project.Column.ConcreteCoverMinDur.ExposureClassDescription == "XC1")
            {
                if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S1" || project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S2" || project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S3")
                {
                    cMinDur = 10;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S4")
                {
                    cMinDur = 15;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S5")
                {
                    cMinDur = 20;
                }
                else
                {
                    cMinDur = 25;
                }
            }

            else if (project.Column.ConcreteCoverMinDur.ExposureClassDescription == "XC2" || project.Column.ConcreteCoverMinDur.ExposureClassDescription == "XC3")
            {
                if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S1")
                {
                    cMinDur = 10;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S2")
                {
                    cMinDur = 15;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S3")
                {
                    cMinDur = 20;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S4")
                {
                    cMinDur = 25;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S5")
                {
                    cMinDur = 30;
                }
                else
                {
                    cMinDur = 35;
                }
            }

            else if (project.Column.ConcreteCoverMinDur.ExposureClassDescription == "XC4")
            {
                if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S1")
                {
                    cMinDur = 15;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S2")
                {
                    cMinDur = 20;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S3")
                {
                    cMinDur = 25;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S4")
                {
                    cMinDur = 30;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S5")
                {
                    cMinDur = 35;
                }
                else
                {
                    cMinDur = 40;
                }
            }

            else if (project.Column.ConcreteCoverMinDur.ExposureClassDescription == "XD1" || project.Column.ConcreteCoverMinDur.ExposureClassDescription == "XS1")
            {
                if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S1")
                {
                    cMinDur = 20;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S2")
                {
                    cMinDur = 25;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S3")
                {
                    cMinDur = 30;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S4")
                {
                    cMinDur = 35;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S5")
                {
                    cMinDur = 40;
                }
                else
                {
                    cMinDur = 45;
                }
            }

            else if (project.Column.ConcreteCoverMinDur.ExposureClassDescription == "XD2" || project.Column.ConcreteCoverMinDur.ExposureClassDescription == "XS2")
            {
                if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S1")
                {
                    cMinDur = 25;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S2")
                {
                    cMinDur = 30;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S3")
                {
                    cMinDur = 35;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S4")
                {
                    cMinDur = 40;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S5")
                {
                    cMinDur = 45;
                }
                else
                {
                    cMinDur = 55;
                }
            }

            else
            {
                if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S1")
                {
                    cMinDur = 30;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S2")
                {
                    cMinDur = 35;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S3")
                {
                    cMinDur = 40;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S4")
                {
                    cMinDur = 45;
                }
                else if (project.Column.ConcreteCoverMinDur.StructuralClassDescription == "S5")
                {
                    cMinDur = 50;
                }
                else
                {
                    cMinDur = 55;
                }
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CMinDur"));
        }
    }
}

