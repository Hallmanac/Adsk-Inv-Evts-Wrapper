using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class DrawingEventsLib : IDrawingEventsLib
    {
        private Inventor.Application inventorApp;

        public DrawingEventsSink_OnRetrieveDimensionsEventHandler OnRetrieveDimensionsDelegate
        { get; set; }

        public DrawingEvents DrawingEvents { get; private set; }

        public DrawingEventsLib(Inventor.Application inventorApp, DrawingDocument drawingDoc)
        {
            this.inventorApp = inventorApp;
            this.DrawingEvents = drawingDoc.DrawingEvents;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.DrawingEvents.OnRetrieveDimensions -= this.OnRetrieveDimensionsDelegate;
            this.OnRetrieveDimensionsDelegate = null;
        }
    }
}
