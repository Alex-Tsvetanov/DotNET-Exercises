using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfExample.Classes;

namespace WpfExample.Commands
{
    public class RemoveCommand : ICommand
    {
        public void Execute(object? parameter)
        {
            var nameList = parameter as NamesList;
            if (nameList == null) return;
            var oldName = nameList.SelectedName;
            if (oldName == null) return;
            nameList.Names.Remove(oldName);
        }
        public bool CanExecute(object? parameter)
        {
            return true;
        }
        public event EventHandler? CanExecuteChanged;
    }
}
