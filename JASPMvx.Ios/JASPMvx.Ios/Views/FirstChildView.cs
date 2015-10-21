using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using CoreGraphics;
using JASPMvx.Core.ViewModels;
using UIKit;

namespace JASPMvx.Ios.Views
{
    public class FirstChildView : BaseView
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.Yellow;

            var label = new UILabel(new CGRect(0, 50, 320, 40));
            label.TextAlignment = UITextAlignment.Center;
            Add(label);
            
            var button = new UIButton(new CGRect(0, 100, 320, 40));
            button.SetTitle("Close", UIControlState.Normal);
            button.BackgroundColor = UIColor.Red;
            Add(button);

            var set = this.CreateBindingSet<FirstChildView, FirstChildViewModel>();
            set.Bind(label).To(vm => vm.ViewName);
            set.Bind(button).To(vm => vm.CloseCommand);
            set.Apply();
        }

        public override void ViewWillAppear(bool animated)
        {
            Title = "First Child View";

            base.ViewWillAppear(animated);
        }
    }

    public class BaseView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            EdgesForExtendedLayout = UIRectEdge.None;
            
            base.ViewDidLoad();
        }
    }
}