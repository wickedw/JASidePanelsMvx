using Cirrious.MvvmCross.Binding.BindingContext;
using CoreGraphics;
using JASPMvx.Core.ViewModels;
using UIKit;

namespace JASPMvx.Ios.Views
{
    public class LeftView : BaseView
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.Green;

            var button = new UIButton(new CGRect(0, 100, 320, 40));
            button.SetTitle("Just Show Center", UIControlState.Normal);
            button.BackgroundColor = UIColor.White;
            button.SetTitleColor(UIColor.Black, UIControlState.Normal);
            Add(button);

            var buttonFirst = new UIButton(new CGRect(0, 150, 320, 40));
            buttonFirst.SetTitle("Menu Item First", UIControlState.Normal);
            buttonFirst.BackgroundColor = UIColor.White;
            buttonFirst.SetTitleColor(UIColor.Black, UIControlState.Normal);
            Add(buttonFirst);

            var buttonCenter1 = new UIButton(new CGRect(0, 200, 320, 40));
            buttonCenter1.SetTitle("Menu Item 1", UIControlState.Normal);
            buttonCenter1.BackgroundColor = UIColor.White;
            buttonCenter1.SetTitleColor(UIColor.Black, UIControlState.Normal);
            Add(buttonCenter1);

            var buttonCenter2 = new UIButton(new CGRect(0, 250, 320, 40));
            buttonCenter2.SetTitle("Menu Item 2", UIControlState.Normal);
            buttonCenter2.BackgroundColor = UIColor.White;
            buttonCenter2.SetTitleColor(UIColor.Black, UIControlState.Normal);
            Add(buttonCenter2);

            var set = this.CreateBindingSet<LeftView, LeftViewModel>();
            set.Bind(button).To(vm => vm.ShowCenterCommand);
            set.Bind(buttonFirst).To(vm => vm.FirstCommand);
            set.Bind(buttonCenter1).To(vm => vm.Center1Command);
            set.Bind(buttonCenter2).To(vm => vm.Center2Command);
            set.Apply();
        }

        public override void ViewWillAppear(bool animated)
        {
            Title = "Left Menu View";
            base.ViewWillAppear(animated);

            NavigationController.NavigationBarHidden = true;
        }
    }
}