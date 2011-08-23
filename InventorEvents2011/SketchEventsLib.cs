using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class SketchEventsLib : ISketchEventsLib
    {
        private Inventor.Application inventorApp;

        public SketchEventsSink_OnDeleteEventHandler OnDeleteDelegate
        { get; set; }
        public SketchEventsSink_OnNewSketchEventHandler OnNewSketchDelegate
        { get; set; }
        public SketchEventsSink_OnNewSketch3DEventHandler OnNewSketch3DDelegate
        { get; set; }
        public SketchEventsSink_OnSketch3DChangeEventHandler OnSketch3DChangeDelegate
        { get; set; }
        public SketchEventsSink_OnSketch3DSolveEventHandler OnSketch3DSolveDelegate
        { get; set; }
        public SketchEventsSink_OnSketchChangeEventHandler OnSketchChangeDelegate
        { get; set; }

        public SketchEvents SketchEvents { get; private set; }

        public SketchEventsLib(Inventor.Application inventorApp)
        {
            this.inventorApp = inventorApp;
            this.SketchEvents = inventorApp.SketchEvents;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.SketchEvents.OnDelete -= this.OnDeleteDelegate;
            this.OnDeleteDelegate = null;

            this.SketchEvents.OnNewSketch -= this.OnNewSketchDelegate;
            this.OnNewSketchDelegate = null;

            this.SketchEvents.OnNewSketch3D -= this.OnNewSketch3DDelegate;
            this.OnNewSketch3DDelegate = null;

            this.SketchEvents.OnSketch3DChange -= this.OnSketch3DChangeDelegate;
            this.OnSketch3DChangeDelegate = null;

            this.SketchEvents.OnSketch3DSolve -= this.OnSketch3DSolveDelegate;
            this.OnSketch3DSolveDelegate = null;

            this.SketchEvents.OnSketchChange -= this.OnSketchChangeDelegate;
            this.OnSketchChangeDelegate = null;
        }
    }
}
