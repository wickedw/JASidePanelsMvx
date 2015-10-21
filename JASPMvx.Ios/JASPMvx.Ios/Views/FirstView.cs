using Cirrious.MvvmCross.Binding.BindingContext;
using CoreGraphics;
using JASPMvx.Core.ViewModels;
using UIKit;

namespace JASPMvx.Ios.Views
{
    public class FirstView : BaseView
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.White;

            var label = new UILabel(new CGRect(0, 50, 320, 40));
            label.TextAlignment= UITextAlignment.Center;
            Add(label);

            var button = new UIButton(new CGRect(0, 100, 320, 40));
            button.SetTitle("Show Child", UIControlState.Normal);
            button.BackgroundColor = UIColor.Red;
            Add(button);

            var buttonleft = new UIButton(new CGRect(0, 150, 320, 40));
            buttonleft.SetTitle("< Show Left", UIControlState.Normal);
            buttonleft.BackgroundColor = UIColor.Red;
            Add(buttonleft);

            var buttonright = new UIButton(new CGRect(0, 250, 320, 40));
            buttonright.SetTitle("Show Right >", UIControlState.Normal);
            buttonright.BackgroundColor = UIColor.Red;
            Add(buttonright);

            var buttonpushleft = new UIButton(new CGRect(0, 200, 320, 40));
            buttonpushleft.SetTitle("<< Push Child Left", UIControlState.Normal);
            buttonpushleft.BackgroundColor = UIColor.Red;            
            Add(buttonpushleft);

            var buttonpushright = new UIButton(new CGRect(0, 300, 320, 40));
            buttonpushright.SetTitle("Push Child Right >>", UIControlState.Normal);
            buttonpushright.BackgroundColor = UIColor.Red;
            Add(buttonpushright);

            var buttonmodal = new UIButton(new CGRect(0, 350, 320, 40));
            buttonmodal.SetTitle("Show Modal >>", UIControlState.Normal);
            buttonmodal.BackgroundColor = UIColor.Red;
            Add(buttonmodal);

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(label).To(vm => vm.ViewName);
            set.Bind(button).To(vm => vm.ShowChildCommand);
            set.Bind(buttonleft).To(vm => vm.ShowLeftCommand);
            set.Bind(buttonpushleft).To(vm => vm.ShowPushLeftCommand);
            set.Bind(buttonright).To(vm => vm.ShowRightCommand);
            set.Bind(buttonpushright).To(vm => vm.ShowPushRightCommand);
            set.Bind(buttonmodal).To(vm => vm.ShowModalCommand);
            set.Apply();
        }

        public override void ViewWillAppear(bool animated)
        {
            Title = "First View";

            base.ViewWillAppear(animated);
        }
    }
}