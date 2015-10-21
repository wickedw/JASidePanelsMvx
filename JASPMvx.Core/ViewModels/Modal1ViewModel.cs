using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace JASPMvx.Core.ViewModels
{
    public class Modal1ViewModel : BaseViewModel
    {
        public ICommand CloseCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    Close(this);

                    // We will also test the showing of another ViewModel after modal close which is very common use case
                    ShowViewModel<FirstChildViewModel>();
                });
            }
        }
    }
}