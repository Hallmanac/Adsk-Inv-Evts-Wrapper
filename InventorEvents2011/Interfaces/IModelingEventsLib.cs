using System;
using Inventor;

namespace InventorEvents2011.Interfaces
{
    public interface IModelingEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.ModelingEvents object
        /// </summary>
        ModelingEvents ModelingEvents { get; }

        ModelingEventsSink_OnClientFeatureDoubleClickEventHandler 
            OnClientFeatureDoubleClickDelegate { get; set; }
        ModelingEventsSink_OnClientFeatureSolveEventHandler 
            OnClientFeatureSolveDelegate { get; set; }
        ModelingEventsSink_OnDeleteEventHandler OnDeleteDelegate { get; set; }
        ModelingEventsSink_OnFeatureChangeEventHandler OnFeatureChangeDelegate { get; set; }
        ModelingEventsSink_OnGenerateMemberEventHandler OnGenerateMemberDelegate { get; set; }
        ModelingEventsSink_OnNewFeatureEventHandler OnNewFeatureDelegate { get; set; }
        ModelingEventsSink_OnNewParameterEventHandler OnNewParameterDelegate { get; set; }
        ModelingEventsSink_OnParameterChangeEventHandler OnParameterChangeDelegate { get; set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
