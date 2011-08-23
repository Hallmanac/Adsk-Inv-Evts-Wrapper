using System;
using Inventor;

namespace InventorEvents2010.Interfaces
{
    public interface IChangeDefinitionEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.ChangeDefinition object
        /// </summary>
        ChangeDefinition ChangeDefinition { get; }
        
        ChangeDefinitionSink_OnReplayEventHandler OnReplayDelegate { get; set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
