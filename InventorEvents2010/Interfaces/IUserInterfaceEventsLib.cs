using System;
using Inventor;

namespace InventorEvents2010.Interfaces
{
    public interface IUserInterfaceEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.UserInterfaceEvents object
        /// </summary>
        UserInterfaceEvents UserInterfaceEvents { get; }
        
        UserInterfaceEventsSink_OnEnvironmentChangeEventHandler 
            OnEnvironmentChangeDelegate { get; set; }
        UserInterfaceEventsSink_OnResetCommandBarsEventHandler 
            OnResetCommandBarsDelegate { get; set; }
        UserInterfaceEventsSink_OnResetEnvironmentsEventHandler 
            OnResetEnvironmentsDelegate { get; set; }
        UserInterfaceEventsSink_OnResetRibbonInterfaceEventHandler 
            OnResetRibbonInterfaceDelegate { get; set; }
        UserInterfaceEventsSink_OnResetShortcutsEventHandler OnResetShortcutsDelegate { get; set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
