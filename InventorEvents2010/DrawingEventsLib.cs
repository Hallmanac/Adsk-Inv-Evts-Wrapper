using Inventor;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class DrawingEventsLib : IDrawingEventsLib
    {
        private Application inventorApp;

        public DrawingEventsLib(Application inventorApp, DrawingDocument drawingDoc)
        {
            this.inventorApp = inventorApp;
            DrawingEvents = drawingDoc.DrawingEvents;
            Activate();
        }

        #region IDrawingEventsLib Members

        public DrawingEventsSink_OnRetrieveDimensionsEventHandler OnRetrieveDimensionsDelegate { get; set; }

        public DrawingEvents DrawingEvents { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            DrawingEvents.OnRetrieveDimensions -= OnRetrieveDimensionsDelegate;
            OnRetrieveDimensionsDelegate = null;
        }

        #endregion

        private void Activate()
        {
            DrawingEvents.OnRetrieveDimensions += OnRetrieveDimensionsDelegate;
        }
    }
}