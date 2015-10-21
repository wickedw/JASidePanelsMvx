using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace JASPMvx.Core.ViewModels
{
    public class LeftViewModel : BaseViewModel
    {
        public ICommand ShowCenterCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    // Show Center Panel Only
                    ChangePresentation(new ActivePanelPresentationHint(PanelEnum.Center));
                });
            }
        }

        public ICommand FirstCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    ShowViewModel<FirstViewModel>(PanelEnum.Center, true);
                });
            }
        }

        public ICommand Center1Command
        {
            get
            {
                return new MvxCommand(() =>
                {
                    ShowViewModel<Center1ViewModel>(PanelEnum.Center, true);                   
                });
            }
        }

        public ICommand Center2Command
        {
            get
            {
                return new MvxCommand(() =>
                {
                    ShowViewModel<Center2ViewModel>(PanelEnum.Center, true);
                });
            }
        }
    }
}

