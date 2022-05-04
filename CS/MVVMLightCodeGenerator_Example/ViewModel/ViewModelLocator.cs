using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;

namespace MVVMLightCodeGenerator_Example.ViewModel
{
    public class ViewModelLocator
    {
        private static MainViewModel _main;
        private static ChildViewModel _child;
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<ChildViewModel>();
        }
        public static MainViewModel Main
        {
            get
            {
                if (_main == null)
                    _main = ServiceLocator.Current.GetInstance<MainViewModel>();
                return _main;
            }
        }
        public static ChildViewModel Child
        {
            get
            {
                if (_child == null)
                    _child = ServiceLocator.Current.GetInstance<ChildViewModel>();
                return _child;
            }
        }
        public static void Cleanup()
        {
            _main.Cleanup();
            _main = null;
            _child.Cleanup();
            _child = null;
        }
    }
}