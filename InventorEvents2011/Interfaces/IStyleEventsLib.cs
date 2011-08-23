using System;
using Inventor;

namespace InventorEvents2011.Interfaces
{
    public interface IStyleEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.StyleEvents object
        /// </summary>
        StyleEvents StyleEvents { get; }
        
        StyleEventsSink_OnActivateStyleEventHandler OnActivateStyleDelegate { get; set; }
        StyleEventsSink_OnDeleteEventHandler OnDeleteDelegate { get; set; }
        StyleEventsSink_OnMigrateStyleLibraryEventHandler OnMigrateStyleLibraryDelegate { get; set; }
        StyleEventsSink_OnNewStyleEventHandler OnNewStyleDelegate { get; set; }
        StyleEventsSink_OnStyleChangeEventHandler OnStyleChangeDelegate { get; set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
