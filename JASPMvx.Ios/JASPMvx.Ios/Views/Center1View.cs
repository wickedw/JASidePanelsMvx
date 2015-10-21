using UIKit;

namespace JASPMvx.Ios.Views
{
    public class Center1View : BaseView
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.Purple;
        }

        public override void ViewWillAppear(bool animated)
        {
            Title = "Center 1";
            base.ViewWillAppear(animated);
        }
    }

    public class Center2View : BaseView
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.DarkGray;
        }

        public override void ViewWillAppear(bool animated)
        {
            Title = "Center 2";
            base.ViewWillAppear(animated);
        }
    }
}