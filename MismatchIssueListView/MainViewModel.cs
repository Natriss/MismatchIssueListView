using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MismatchIssueListView
{
    public class MainViewModel
    {
        public List<CustomClass> customClasses { get; set; }
        public MainViewModel()
        {
            List<CustomClassList> customClassLists = new List<CustomClassList>()
            {
                new CustomClassList() { MyProperty = 1 },
                new CustomClassList() { MyProperty = 2 },
                new CustomClassList() { MyProperty = 3 },
                new CustomClassList() { MyProperty = 4 },
                new CustomClassList() { MyProperty = 5 },
                new CustomClassList() { MyProperty = 6 },
                new CustomClassList() { MyProperty = 7 },
                new CustomClassList() { MyProperty = 8 },
                new CustomClassList() { MyProperty = 9},
                new CustomClassList() { MyProperty = 10 },
            };
            customClasses = new List<CustomClass>()
            {
                new CustomClass() { Number = 1, Text = "Demo text 1", MyPropertyList = customClassLists},
                new CustomClass() { Number = 2, Text = "Demo text 2", MyPropertyList = customClassLists },
                new CustomClass() { Number = 3, Text = "Demo text 3", MyPropertyList = customClassLists },
                new CustomClass() { Number = 4, Text = "Demo text 4", MyPropertyList = customClassLists },
                new CustomClass() { Number = 5, Text = "Demo text 5", MyPropertyList = customClassLists },
            };

        }
    }
}
