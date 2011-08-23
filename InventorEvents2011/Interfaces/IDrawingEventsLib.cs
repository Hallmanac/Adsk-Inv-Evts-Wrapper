using System;
using Inventor;

namespace InventorEvents2011.Interfaces
{
    public interface IDrawingEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.DrawingEvents object
        /// </summary>
        DrawingEvents DrawingEvents { get; }

        DrawingEventsSink_OnRetrieveDimensionsEventHandler 
            OnRetrieveDimensionsDelegate { get; set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
