using System;
using Inventor;

namespace InventorEvents2010.Interfaces
{
    public interface IButtonEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.ButtonDefinition object to which the OnExecute event
        /// will attach
        /// </summary>
        ButtonDefinition ButtonDef { get; }
        
        ButtonDefinitionSink_OnExecuteEventHandler OnExecuteDelegate { get; set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
