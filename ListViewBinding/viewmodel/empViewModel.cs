using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using ListViewBinding.RelayCmd;

namespace ListViewBinding.viewmodel
{
    public class empViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<compareList> _items;
        private List<compareList> _itemsa;

        internal void onPropertyChnaged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public empViewModel()
        {
            _itemsa = new List<compareList>();
            ItemsA.Add(new compareList() { A = "42", B = "42"});
            ItemsA.Add(new compareList() { A = "42", B = "43"});
            ItemsA.Add(new compareList() { A = "42", B = "42"});
            ItemsA.Add(new compareList() { A = "42", B = "45"});

            _items = new List<compareList>();
            foreach (var iten in ItemsA)
            {                
                Items.Add(new compareList() { A = iten.A, B=iten.B, isValid = (iten.A).Equals(iten.B) });
            }

            
        }

        public List<compareList> ItemsA
        {
            get => _itemsa;
        }
        public List<compareList> Items
        {
            get => _items;
        }

        private ICommand _actionCommond;

        public ICommand ActionCommand
        {
            get => _actionCommond = _actionCommond ?? new emppRelayCmd(this);
            set => _actionCommond = value;
        }

    }
        
        public class compareList
        {
            public string A { get; set; }
            public string B { get; set; }
               
            public bool isValid { get; set; }
        
    }
        public class User
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public string Mail { get; set; }

            public bool isValid { get; set; }
        }
}

