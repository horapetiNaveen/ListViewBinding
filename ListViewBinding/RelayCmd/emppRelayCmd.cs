using ListViewBinding.viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ListViewBinding.RelayCmd
{
    class emppRelayCmd : ICommand
    {
        empViewModel _empViewModel;
        public emppRelayCmd(empViewModel viewModel)
        {
            _empViewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "editBtn":
                    editObject();
                    break;
            }


        }

        private void editObject()
        {
            throw new NotImplementedException();
        }
    }
}
