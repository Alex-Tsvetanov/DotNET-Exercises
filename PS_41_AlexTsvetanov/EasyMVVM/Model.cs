using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMVVM
{
    class Model
    {
        ObservableCollection<string> _data = new();

        public ObservableCollection<string> GetData()
        {
            _data.Clear();
            // these steps represent the same data to be returned each time GetData is called.
            // typically you'd query a database or put other buisness logic here
            _data.Add("First Entry");
            _data.Add("Second Entry");
            _data.Add("Third Entry");
            return _data;
        }
    }
}
