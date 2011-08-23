using System;
using Inventor;

namespace InventorEvents2011.Interfaces
{
    public interface IButtonEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.ButtonDefinition object to which the OnExecute event
        /// will be attached.
        /// </summary>
        ButtonDefinition ButtonDefinition { get; }
        
        ButtonDefinitionSink_OnExecuteEventHandler OnExecuteDelegate { get; set; }
        ButtonDefinitionSink_OnHelpEventHandler OnHelpDelegate { get; set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
