using System;
using System.Linq.Expressions;
using Cirrious.MvvmCross.Platform;
using Cirrious.MvvmCross.ViewModels;

namespace JASPMvx.Core.ViewModels
{
    public abstract class BaseViewModel : MvxViewModel
    {
        /// <summary>
        /// Checks if a property already matches a desired value.  Sets the property and
        /// notifies listeners only when necessary.
        /// </summary>
        /// <typeparam name="T">Type of the property.</typeparam>
        /// <param name="backingStore">Reference to a property with both getter and setter.</param>
        /// <param name="value">Desired value for the property.</param>
        /// <param name="property">The property.</param>
        protected void SetProperty<T>(
            ref T backingStore,
            T value,
            Expression<Func<T>> property)
        {
            if (Equals(backingStore, value))
            {
                return;
            }

            backingStore = value;

            this.RaisePropertyChanged(property);
        }

        /// <summary>
        /// Convenience function which sets the active panel which the viewmodel will be pushed to
        /// And optionally replaces the current root of that panel with your ViewModel
        /// </summary>
        protected bool ShowViewModel<TViewModel>(
            PanelEnum panel,
            bool resetRootViewController = false,
            object parameterValuesObject = null,
            IMvxBundle presentationBundle = null,
            MvxRequestedBy requestedBy = null) where TViewModel : IMvxViewModel
        {
            if (resetRootViewController)
                ChangePresentation(new PanelResetRootPresentationHint(panel));

            ChangePresentation(new ActivePanelPresentationHint(panel));
            
            return ShowViewModel(
                        typeof(TViewModel),
                        new MvxBundle(parameterValuesObject.ToSimplePropertyDictionary()),
                        presentationBundle,
                        requestedBy);
        }        
    }
}