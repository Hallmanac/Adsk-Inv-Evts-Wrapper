using System;
using Inventor;

namespace InventorEvents2011.Interfaces
{
    public interface IMeasureEventsLib
    {
        /// <summary>
        /// Property representing an Inventor.InteractionEvents object which is used to initialize
        /// the MeasureEvents property
        /// </summary>
        InteractionEvents LocalInteractionEvents { get; set; }

        /// <summary>
        /// Property representing the Inventor.MeasureEvents object.  It is automatically initialized
        /// in the Getter.
        /// </summary>
        MeasureEvents MeasureEvents { get; }

        #region Event Handler Delegates
        MeasureEventsSink_OnMeasureEventHandler OnMeasureDelegate { get; set; }
        MeasureEventsSink_OnSelectParameterEventHandler OnSelectParameterDelegate { get; set; }
        #endregion

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
