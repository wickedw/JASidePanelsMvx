using Cirrious.CrossCore;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using Cirrious.MvvmCross.ViewModels;
using Foundation;
using UIKit;

namespace JASPMvx.Ios
{
	[Register("AppDelegate")]
	public partial class AppDelegate : MvxApplicationDelegate
	{
		UIWindow _window;

		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			_window = new UIWindow(UIScreen.MainScreen.Bounds);

            MvxTouchViewPresenter presenter = new JaSidePanelsMvxPresenter(this, _window);
            var setup = new Setup(this, presenter);
            setup.Initialize();

			var startup = Mvx.Resolve<IMvxAppStart>();
			startup.Start();

			_window.MakeKeyAndVisible();
			
			return true;
		}
	}
}