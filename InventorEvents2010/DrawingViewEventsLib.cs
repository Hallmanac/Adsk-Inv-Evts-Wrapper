using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class DrawingViewEventsLib : IDrawingViewEventsLib
    {
        private Inventor.Application inventorApp;

        public DrawingViewEventsSink_OnViewUpdateEventHandler OnViewUpdateDelegate
        { get; set; }

        public DrawingViewEvents DrawingViewEvents { get; private set; }

        public DrawingViewEventsLib(Inventor.Application inventorApp, 
            DrawingView drawingView)
        {
            this.inventorApp = inventorApp;
            this.DrawingViewEvents = drawingView.DrawingViewEvents;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.DrawingViewEvents.OnViewUpdate -= this.OnViewUpdateDelegate;
            this.OnViewUpdateDelegate = null;
        }
    }
}
