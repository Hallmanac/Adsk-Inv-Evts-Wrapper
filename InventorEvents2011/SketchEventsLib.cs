using Inventor;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class SketchEventsLib : ISketchEventsLib
    {
        private Application inventorApp;

        public SketchEventsLib(Application inventorApp)
        {
            this.inventorApp = inventorApp;
            SketchEvents = inventorApp.SketchEvents;
            Activate();
        }

        #region ISketchEventsLib Members

        public SketchEventsSink_OnDeleteEventHandler OnDeleteDelegate { get; set; }
        public SketchEventsSink_OnNewSketchEventHandler OnNewSketchDelegate { get; set; }
        public SketchEventsSink_OnNewSketch3DEventHandler OnNewSketch3DDelegate { get; set; }
        public SketchEventsSink_OnSketch3DChangeEventHandler OnSketch3DChangeDelegate { get; set; }
        public SketchEventsSink_OnSketch3DSolveEventHandler OnSketch3DSolveDelegate { get; set; }
        public SketchEventsSink_OnSketchChangeEventHandler OnSketchChangeDelegate { get; set; }

        public SketchEvents SketchEvents { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            SketchEvents.OnDelete -= OnDeleteDelegate;
            OnDeleteDelegate = null;

            SketchEvents.OnNewSketch -= OnNewSketchDelegate;
            OnNewSketchDelegate = null;

            SketchEvents.OnNewSketch3D -= OnNewSketch3DDelegate;
            OnNewSketch3DDelegate = null;

            SketchEvents.OnSketch3DChange -= OnSketch3DChangeDelegate;
            OnSketch3DChangeDelegate = null;

            SketchEvents.OnSketch3DSolve -= OnSketch3DSolveDelegate;
            OnSketch3DSolveDelegate = null;

            SketchEvents.OnSketchChange -= OnSketchChangeDelegate;
            OnSketchChangeDelegate = null;
        }

        #endregion

        private void Activate()
        {
            SketchEvents.OnDelete += OnDeleteDelegate;

            SketchEvents.OnNewSketch += OnNewSketchDelegate;

            SketchEvents.OnNewSketch3D += OnNewSketch3DDelegate;

            SketchEvents.OnSketch3DChange += OnSketch3DChangeDelegate;

            SketchEvents.OnSketch3DSolve += OnSketch3DSolveDelegate;

            SketchEvents.OnSketchChange += OnSketchChangeDelegate;
        }
    }
}