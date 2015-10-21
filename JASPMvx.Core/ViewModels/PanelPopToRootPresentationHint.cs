using Cirrious.MvvmCross.ViewModels;

namespace JASPMvx.Core.ViewModels
{
    public class PanelPopToRootPresentationHint : MvxPresentationHint
    {
        public readonly PanelEnum Panel;

        public PanelPopToRootPresentationHint(PanelEnum panel)
        {
            Panel = panel;
        }
    }

    public class PanelResetRootPresentationHint : MvxPresentationHint
    {
        public readonly PanelEnum Panel;

        public PanelResetRootPresentationHint(PanelEnum panel)
        {
            Panel = panel;
        }
    }
}