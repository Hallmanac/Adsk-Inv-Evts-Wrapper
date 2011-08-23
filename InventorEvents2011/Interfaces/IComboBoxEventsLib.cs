using System;
using Inventor;

namespace InventorEvents2011.Interfaces
{
    public interface IComboBoxEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.ComboBoxDefinition
        /// </summary>
        ComboBoxDefinition ComboBoxDefinition { get; }
        
        ComboBoxDefinitionSink_OnSelectEventHandler OnSelectDelegate { get; set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
