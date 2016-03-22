using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProiectDiplomaWPF.ViewModel
{
    class RelayCommand:ICommand
    {
        
        
        public bool CanExecute (object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

       
        
        public void Execute (object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
