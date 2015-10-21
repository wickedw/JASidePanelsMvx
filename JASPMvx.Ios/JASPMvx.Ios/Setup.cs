using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using Cirrious.MvvmCross.ViewModels;
using JASPMvx.Core;

namespace JASPMvx.Ios
{
	public class Setup : MvxTouchSetup
	{
        public Setup(MvxApplicationDelegate applicationDelegate, IMvxTouchViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }
	
		protected override IMvxApplication CreateApp()
		{
			return new App();
		}
		
        /* 
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
        */
	}
}