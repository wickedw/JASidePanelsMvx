using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using CoreGraphics;
using JASPMvx.Core.ViewModels;
using UIKit;

namespace JASPMvx.Ios.Views
{
    public class Modal1View : BaseView, IMvxModalTouchView
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.Cyan;

            var label = new UILabel(new CGRect(0, 50, 320, 40));
            label.TextAlignment = UITextAlignment.Center;
            Add(label);
            
            var button = new UIButton(new CGRect(0, 100, 320, 40));
            button.SetTitle("Close", UIControlState.Normal);
            button.BackgroundColor = UIColor.Red;
            Add(button);

            var set = this.CreateBindingSet<Modal1View, FirstChildViewModel>();
            set.Bind(label).To(vm => vm.ViewName);
            set.Bind(button).To(vm => vm.CloseCommand);
            set.Apply();
        }

        public override void ViewWillAppear(bool animated)
        {
            Title = "Modal 1 View";

            base.ViewWillAppear(animated);
        }
    }
}