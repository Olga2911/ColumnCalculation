using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class EnvironmentalConditionCalculation : INotifyPropertyChanged
    {
        private Double fiEffY = 0;
        private Double fiEffZ = 0;

        public event PropertyChangedEventHandler PropertyChanged;

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

        public EnvironmentalConditionCalculation (Project project)
        {
            Calculate(project);
        }


        public void Calculate(Project project)
        {
            fiEffY = project.Column.EnvironmentalCondition.FiKoncowe* project.Column.Statics.BendingMomentqpy/project.Column.Statics.BendingMomenty;
            fiEffY = Math.Round((Double)fiEffY, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiEffY"));

            fiEffZ = project.Column.EnvironmentalCondition.FiKoncowe * project.Column.Statics.BendingMomentqpz / project.Column.Statics.BendingMomentz;
            fiEffZ = Math.Round((Double)fiEffZ, 4);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiEffZ"));

        }
    }
}
