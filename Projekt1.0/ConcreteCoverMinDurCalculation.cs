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

        public ConcreteCoverMinDurCalculation (Project project)
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

       


        }





        ////if (Column.conc )

        //if (exposureClassDescription == EnumConvert.GetDescription(ExposureClass.X0) || exposureClassDescription == EnumConvert.GetDescription(ExposureClass.XC1) || exposureClassDescription == EnumConvert.GetDescription(ExposureClass.XC2) || exposureClassDescription == EnumConvert.GetDescription(ExposureClass.XC3))
        ////{
        //    cMinDur = 10;
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CMinDur"));
        //}
        //else if (exposureClassDescription == EnumConvert.GetDescription(ExposureClass.XC4))
        //{
        //    cMinDur = 15;
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CMinDur"));
        //}
        //else if (exposureClassDescription == EnumConvert.GetDescription(ExposureClass.XD1) || exposureClassDescription == EnumConvert.GetDescription(ExposureClass.XS1))
        //{
        //    cMinDur = 20;
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CMinDur"));
        //}
        //else if (exposureClassDescription == EnumConvert.GetDescription(ExposureClass.XD2) || exposureClassDescription == EnumConvert.GetDescription(ExposureClass.XS2))
        //{
        //    cMinDur = 25;
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CMinDur"));
        //}
        //else
        //{
        //    cMinDur = 30;
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CMinDur"));
        //}



    }



}



