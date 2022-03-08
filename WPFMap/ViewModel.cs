using Framework.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMap
{
    public class MainViewModel:BindingBase
    {
        public MainViewModel()
        {
            StatusByColor = new Dictionary<EColor, MyDataStatus>
            {
                { EColor.One, new MyDataStatus { Name = "111" } },
                { EColor.Two, new MyDataStatus { Name = "222" } },
                { EColor.Three, new MyDataStatus { Name = "333" } },
                { EColor.Four, new MyDataStatus { Name = "444" } },
                { EColor.Five, new MyDataStatus { Name = "555" } },
            };
            StatusBystring = new Dictionary<string, MyDataStatus>
            {
                { "One", new MyDataStatus { Name = "111" } },
                { "Two", new MyDataStatus { Name = "222" } },
                { "Three", new MyDataStatus { Name = "333" } },
                { "Four", new MyDataStatus { Name = "444" } },
                { "Five", new MyDataStatus { Name = "555" } },
            };
            var test = StatusByColor[(EColor)1];
        }
        public Dictionary<EColor, MyDataStatus> StatusByColor { get; set; }
        public Dictionary<string, MyDataStatus> StatusBystring { get; set; }
    }
    public class MyDataStatus
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
    public enum EColor
    {
       One = 1,
       Two = 2,
       Three = 3,
       Four = 4,
       Five = 5,
    }
}
