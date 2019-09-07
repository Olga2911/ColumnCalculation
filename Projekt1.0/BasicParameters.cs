﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class BasicParameters : INotifyPropertyChanged
    {
        private Double areaConcrete = 0.0;

        public event PropertyChangedEventHandler PropertyChanged;

        public BasicParameters(Project project)
        {
            Calculate(project);
        }

        public Double AreaConcrete
        {
            get
            {
                return areaConcrete;
            }
        }

        public void Calculate(Project project)
        {
            areaConcrete = project.Column.CrossSectionCharacteristic.Height * project.Column.CrossSectionCharacteristic.Width;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AreaConcrete"));
            //wpisać wszystkie pola
        }
    }
}
