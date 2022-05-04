using GalaSoft.MvvmLight.Messaging;
using System.Windows;
using DevExpress.Mvvm.CodeGenerators.MvvmLight;

namespace MVVMLightCodeGenerator_Example.ViewModel
{
    [GenerateViewModel(ImplementICleanup = true)]
    public partial class MainViewModel
    {
        [GenerateProperty]
        string message;
        [GenerateCommand]
        public void SendMessage()
        {
            MessengerInstance.Send(Message);
        }
        public MainViewModel()
        {
            Message = "Test message";
        }
        public void OnCleanup()
        {
            MessageBox.Show("You can release unmanaged resources here");
        }
    }
}