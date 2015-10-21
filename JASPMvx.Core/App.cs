using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;
using JASPMvx.Core.ViewModels;

namespace JASPMvx.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
				
            RegisterAppStart<FirstViewModel>();            
        }
    }
}