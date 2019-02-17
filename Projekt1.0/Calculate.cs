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
                crossSectionCharacteristic.UpdateData();
            }
        }

    }
}
