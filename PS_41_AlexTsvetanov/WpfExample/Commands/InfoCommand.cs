using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfExample.Commands
{
    public class InfoCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        public NamesWindow? window;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            window = new NamesWindow();
            window.Show();
        }
    }
}
