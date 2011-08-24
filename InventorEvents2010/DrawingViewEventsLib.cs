using Inventor;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class DrawingViewEventsLib : IDrawingViewEventsLib
    {
        private Application inventorApp;

        public DrawingViewEventsLib(Application inventorApp,
                                    DrawingView drawingView)
        {
            this.inventorApp = inventorApp;
            DrawingViewEvents = drawingView.DrawingViewEvents;
            Activate();
        }

        #region IDrawingViewEventsLib Members

        public DrawingViewEventsSink_OnViewUpdateEventHandler OnViewUpdateDelegate { get; set; }

        public DrawingViewEvents DrawingViewEvents { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            DrawingViewEvents.OnViewUpdate -= OnViewUpdateDelegate;
            OnViewUpdateDelegate = null;
        }

        #endregion

        private void Activate()
        {
            DrawingViewEvents.OnViewUpdate += OnViewUpdateDelegate;
        }
    }
}