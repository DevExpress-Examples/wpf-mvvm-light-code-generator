using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.CodeGenerators.MvvmLight;

namespace MVVMLightCodeGenerator_Example.ViewModel
{
    [GenerateViewModel(ImplementICleanup = true)]
    public partial class ChildViewModel
    {
        [GenerateProperty]
        ObservableCollection<string> recievedMessages = new ObservableCollection<string>();
        public ChildViewModel()
        {
            MessengerInstance.Register<string>(this, (message) => { RecievedMessages.Add(message); });
        }
    }
}
