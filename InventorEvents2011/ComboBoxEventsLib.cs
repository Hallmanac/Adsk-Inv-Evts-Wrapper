using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class ComboBoxEventsLib : IComboBoxEventsLib
    {
        public ComboBoxDefinitionSink_OnSelectEventHandler OnSelectDelegate
        { get; set; }

        public ComboBoxDefinition ComboBoxDefinition { get; private set; }

        public ComboBoxEventsLib(ComboBoxDefinition comboBoxDefinition)
        {
            this.ComboBoxDefinition = comboBoxDefinition;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.ComboBoxDefinition.OnSelect -= this.OnSelectDelegate;
            this.OnSelectDelegate = null;
        }
    }
}
