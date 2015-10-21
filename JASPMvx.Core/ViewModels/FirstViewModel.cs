using System.Collections.Generic;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace JASPMvx.Core.ViewModels
{
    public class FirstViewModel : BaseViewModel
    {
        public FirstViewModel()
        {
            ViewName = "First View";

            // We can set up our Panel presentation as we see fit, but for now
            // lets load up a Left, Right and back to our Center
            ChangePresentation(new ActivePanelPresentationHint(PanelEnum.Left, false));
            ShowViewModel<LeftViewModel>();

            ChangePresentation(new ActivePanelPresentationHint(PanelEnum.Right, false));
            ShowViewModel<RightViewModel>();

            ChangePresentation(new ActivePanelPresentationHint(PanelEnum.Center, false));
        }

        private string _viewName;
        public string ViewName
        {
            get { return _viewName; }
            set { SetProperty(ref _viewName, value, () => ViewName); }
        }

        public ICommand ShowChildCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    ShowViewModel<FirstChildViewModel>(
                        PanelEnum.Center,  
                        false, 
                        new {panelEnum = PanelEnum.Center});                 
                });
            }
        }

        public ICommand ShowLeftCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    // Show Left Panel only
                    ChangePresentation(new ActivePanelPresentationHint(PanelEnum.Left));
                });
            }
        }

        public ICommand ShowRightCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    // Show Right Panel only
                    ChangePresentation(new ActivePanelPresentationHint(PanelEnum.Right));
                });
            }
        }

        public ICommand ShowPushLeftCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    ShowViewModel<FirstChildViewModel>(
                        PanelEnum.Left,
                        false,
                        new { panelEnum = PanelEnum.Left });  
                });
            }
        }

        public ICommand ShowPushRightCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    ShowViewModel<RightChildViewModel>(PanelEnum.Right);                   
                });
            }
        }

        public ICommand ShowModalCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    ShowViewModel<Modal1ViewModel>();
                });
            }
        }

    }
}
