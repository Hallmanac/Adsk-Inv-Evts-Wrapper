using System;
using Inventor;

namespace InventorEvents2011.Interfaces
{
    public interface IPartEventsLib
    {
        /// <summary>
        /// Property used to access the Inventor.PartEvents object in the "PartEvents" property
        /// </summary>
        PartComponentDefinition PartComponentDefinition { get; set; }

        /// <summary>
        /// Property representing the Inventor.PartEvents object
        /// </summary>
        PartEvents PartEvents { get; }
        
        PartEventsSink_OnSurfaceBodyChangedEventHandler OnSurfaceBodyChangedDelegate { get; set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
