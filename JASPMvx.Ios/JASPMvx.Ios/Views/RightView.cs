using Cirrious.MvvmCross.Binding.BindingContext;
using CoreGraphics;
using JASPMvx.Core.ViewModels;
using UIKit;

namespace JASPMvx.Ios.Views
{
    public class RightView : BaseView
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.Blue;

            var button = new UIButton(new CGRect(0, 100, 320, 40));
            button.SetTitle("Show Child", UIControlState.Normal);
            button.BackgroundColor = UIColor.Red;
            Add(button);

            var set = this.CreateBindingSet<RightView, RightViewModel>();
            set.Bind(button).To(vm => vm.ShowChildCommand);
            set.Apply();
        }

        public override void ViewWillAppear(bool animated)
        {
            Title = "Right View";

            base.ViewWillAppear(animated);
        }
    }
}