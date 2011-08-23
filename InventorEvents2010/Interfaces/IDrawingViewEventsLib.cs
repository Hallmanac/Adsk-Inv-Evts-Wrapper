using System;
using Inventor;

namespace InventorEvents2010.Interfaces
{
    public interface IDrawingViewEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.DrawingViewEvents
        /// </summary>
        DrawingViewEvents DrawingViewEvents { get; }

        DrawingViewEventsSink_OnViewUpdateEventHandler OnViewUpdateDelegate { get; set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
