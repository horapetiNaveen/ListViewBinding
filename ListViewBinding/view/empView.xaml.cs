using ListViewBinding.viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ListViewBinding.view
{
    /// <summary>
    /// Interaction logic for empView.xaml
    /// </summary>
    public partial class empView : Window
    {
        public empView()
        {
            InitializeComponent();
            empViewModel empViewModel = new empViewModel();
            this.DataContext = empViewModel;
        }
    }
}
