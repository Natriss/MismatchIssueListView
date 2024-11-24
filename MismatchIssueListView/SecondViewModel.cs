using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MismatchIssueListView
{
    public class SecondViewModel : IQueryAttributable, INotifyPropertyChanged
    {
        private int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; OnPropertyChanged(nameof(Number)); }
        }

        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; OnPropertyChanged(nameof(Text)); }
        }

        private List<CustomClassList> _myPropertyList;

        public List<CustomClassList> MyPropertyList
        {
            get { return _myPropertyList; }
            set { _myPropertyList = value; OnPropertyChanged(nameof(MyPropertyList)); }
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            CustomClass customClass = query["details"] as CustomClass;
            Number = customClass.Number;
            Text = customClass.Text;
            MyPropertyList = customClass.MyPropertyList;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
