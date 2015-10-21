using Cirrious.MvvmCross.Binding.BindingContext;
using CoreGraphics;
using JASPMvx.Core.ViewModels;
using UIKit;

namespace JASPMvx.Ios.Views
{
    public class RightChildView : BaseView
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.Orange;

            var button = new UIButton(new CGRect(0, 100, 320, 40));
            button.SetTitle("Close", UIControlState.Normal);
            button.BackgroundColor = UIColor.Red;
            Add(button);

            var set = this.CreateBindingSet<RightChildView, RightChildViewModel>();
            set.Bind(button).To(vm => vm.CloseCommand);
            set.Apply();
        }

        public override void ViewWillAppear(bool animated)
        {
            Title = "Right Child View";
            base.ViewWillAppear(animated);
        }
    }
}