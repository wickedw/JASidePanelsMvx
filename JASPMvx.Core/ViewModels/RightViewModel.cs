using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace JASPMvx.Core.ViewModels
{
    public class RightViewModel : BaseViewModel
    {
        public RightViewModel()
        {
            
        }
 
        public ICommand ShowChildCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    // You do not have to use the helper function, but ...
                    ChangePresentation(new ActivePanelPresentationHint(PanelEnum.Right));
                    ShowViewModel<RightChildViewModel>();
                });
            }
        }
    }
}