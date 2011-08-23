using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class UserInterfaceEventsLib : IUserInterfaceEventsLib
    {
        private Inventor.Application inventorApp;

        public UserInterfaceEventsSink_OnEnvironmentChangeEventHandler OnEnvironmentChangeDelegate
        { get; set; }
        public UserInterfaceEventsSink_OnResetCommandBarsEventHandler OnResetCommandBarsDelegate
        { get; set; }
        public UserInterfaceEventsSink_OnResetEnvironmentsEventHandler OnResetEnvironmentsDelegate
        { get; set; }
        public UserInterfaceEventsSink_OnResetRibbonInterfaceEventHandler
            OnResetRibbonInterfaceDelegate { get; set; }
        public UserInterfaceEventsSink_OnResetShortcutsEventHandler OnResetShortcutsDelegate
        { get; set; }

        public UserInterfaceEvents UserInterfaceEvents { get; private set; }

        public UserInterfaceEventsLib(Inventor.Application inventorApp)
        {
            this.inventorApp = inventorApp;
            this.UserInterfaceEvents = inventorApp.UserInterfaceManager.UserInterfaceEvents;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.UserInterfaceEvents.OnEnvironmentChange -= this.OnEnvironmentChangeDelegate;
            this.OnEnvironmentChangeDelegate = null;

            this.UserInterfaceEvents.OnResetCommandBars -= this.OnResetCommandBarsDelegate;
            this.OnResetCommandBarsDelegate = null;

            this.UserInterfaceEvents.OnResetEnvironments -= this.OnResetEnvironmentsDelegate;
            this.OnResetEnvironmentsDelegate = null;

            this.UserInterfaceEvents.OnResetRibbonInterface -= this.OnResetRibbonInterfaceDelegate;
            this.OnResetRibbonInterfaceDelegate = null;

            this.UserInterfaceEvents.OnResetShortcuts -= this.OnResetShortcutsDelegate;
            this.OnResetShortcutsDelegate = null;
        }
    }
}
