using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace JASPMvx.Core.ViewModels
{
    public class FirstChildViewModel : BaseViewModel
    {
        public FirstChildViewModel()
        {
            ViewName = "First Child View";
        }

        private string _viewName;
        public string ViewName
        {
            get { return _viewName; }
            set { SetProperty(ref _viewName, value, () => ViewName); }
        }

        public ICommand CloseCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    Close(this);
                });
            }
        }
    }
}