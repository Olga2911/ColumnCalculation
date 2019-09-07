﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class Project
    {
        private Column column = new Column();

        private BasicParameters basicParameters;

        public Project()
        {
            column.PropertyChanged += ColumnPropertyChangedEventHandler;
            basicParameters = new BasicParameters(this);

        }

        public Column Column
        {
            get
            {
                return column;
            }
        }

        void ColumnPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
        {
            Calculate();
        }

        void Calculate()
        {
            basicParameters.Calculate(this);
            //wpisać wszystkie metody
        }
    }

}
