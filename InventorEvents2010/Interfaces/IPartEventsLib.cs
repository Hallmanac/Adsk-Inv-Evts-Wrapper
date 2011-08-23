using System;
using Inventor;

namespace InventorEvents2010.Interfaces
{
    public interface IPartEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.PartEvents object
        /// </summary>
        PartEvents PartEvents { get; }

        PartComponentDefinition PartComponentDefinition { get; set; }
        
        PartEventsSink_OnSurfaceBodyChangedEventHandler OnSurfaceBodyChangedDelegate { get; set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
