using Inventor;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class UserInterfaceEventsLib : IUserInterfaceEventsLib
    {
        public UserInterfaceEventsLib(Application inventorApp)
        {
            UserInterfaceEvents = inventorApp.UserInterfaceManager.UserInterfaceEvents;
            Activate();
        }

        #region IUserInterfaceEventsLib Members

        public UserInterfaceEventsSink_OnEnvironmentChangeEventHandler OnEnvironmentChangeDelegate { get; set; }
        public UserInterfaceEventsSink_OnResetCommandBarsEventHandler OnResetCommandBarsDelegate { get; set; }
        public UserInterfaceEventsSink_OnResetEnvironmentsEventHandler OnResetEnvironmentsDelegate { get; set; }

        public UserInterfaceEventsSink_OnResetRibbonInterfaceEventHandler
            OnResetRibbonInterfaceDelegate { get; set; }

        public UserInterfaceEventsSink_OnResetShortcutsEventHandler OnResetShortcutsDelegate { get; set; }

        public UserInterfaceEvents UserInterfaceEvents { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            UserInterfaceEvents.OnEnvironmentChange -= OnEnvironmentChangeDelegate;
            OnEnvironmentChangeDelegate = null;

            UserInterfaceEvents.OnResetCommandBars -= OnResetCommandBarsDelegate;
            OnResetCommandBarsDelegate = null;

            UserInterfaceEvents.OnResetEnvironments -= OnResetEnvironmentsDelegate;
            OnResetEnvironmentsDelegate = null;

            UserInterfaceEvents.OnResetRibbonInterface -= OnResetRibbonInterfaceDelegate;
            OnResetRibbonInterfaceDelegate = null;

            UserInterfaceEvents.OnResetShortcuts -= OnResetShortcutsDelegate;
            OnResetShortcutsDelegate = null;
        }

        #endregion

        private void Activate()
        {
            UserInterfaceEvents.OnEnvironmentChange += OnEnvironmentChangeDelegate;

            UserInterfaceEvents.OnResetCommandBars += OnResetCommandBarsDelegate;

            UserInterfaceEvents.OnResetEnvironments += OnResetEnvironmentsDelegate;

            UserInterfaceEvents.OnResetRibbonInterface += OnResetRibbonInterfaceDelegate;

            UserInterfaceEvents.OnResetShortcuts += OnResetShortcutsDelegate;
        }
    }
}