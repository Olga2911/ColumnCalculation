using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekt1._0
{
    class Calculate:ICommand

    {
        public event EventHandler CanExecuteChanged;
        private bool executable = true;

        public bool Executable
        {
            get
            {
                return executable;
            }
            set
            {
                executable = value;
                CanExecuteChanged(this, null);
            }
        }

        public bool CanExecute (object parameter)
        {
            return Executable;
        }

        public void Execute(object parameter)
        {
            Column column = parameter as Column;
            CrossSectionCharacteristic crossSectionCharacteristic = column.CrossSectionCharacteristic;
            if (crossSectionCharacteristic!=null)
            {
                crossSectionCharacteristic.UpdateData(column.SectionType.IsProstokatnySection);
            }

            Statics statics = column.Statics;
            if (statics != null)
            {
                statics.UpdateData();
            }

            Concrete concrete = column.Concrete;
            if (concrete != null)
            {
                concrete.UpdateData();
            }

            SectionType type = column.SectionType;
            if (type != null)
            {
                type.UpdateData();
            }

            CheckEccentricity checkEccentricity = column.CheckEccentricity;
            if (checkEccentricity != null)
            {
                checkEccentricity.UpdateData(column.CrossSectionCharacteristic, column.Statics);
            }

        }

    }
}
