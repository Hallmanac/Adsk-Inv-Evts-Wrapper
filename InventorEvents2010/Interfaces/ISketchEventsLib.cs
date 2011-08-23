using System;
using Inventor;

namespace InventorEvents2010.Interfaces
{
    public interface ISketchEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.SketchEvents object
        /// </summary>
        SketchEvents SketchEvents { get; }
        
        SketchEventsSink_OnDeleteEventHandler OnDeleteDelegate { get; set; }
        SketchEventsSink_OnNewSketch3DEventHandler OnNewSketch3DDelegate { get; set; }
        SketchEventsSink_OnNewSketchEventHandler OnNewSketchDelegate { get; set; }
        SketchEventsSink_OnSketch3DChangeEventHandler OnSketch3DChangeDelegate { get; set; }
        SketchEventsSink_OnSketch3DSolveEventHandler OnSketch3DSolveDelegate { get; set; }
        SketchEventsSink_OnSketchChangeEventHandler OnSketchChangeDelegate { get; set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
