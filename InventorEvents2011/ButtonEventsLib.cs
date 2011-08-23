using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class ButtonEventsLib : IButtonEventsLib
    {
        public ButtonDefinitionSink_OnExecuteEventHandler OnExecuteDelegate
        { get; set; }
        public ButtonDefinitionSink_OnHelpEventHandler OnHelpDelegate
        { get; set; }/*Used in 2011*/

        public ButtonDefinition ButtonDefinition { get; private set; }

        public ButtonEventsLib(ButtonDefinition buttonDef)
        {
            this.ButtonDefinition = buttonDef;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.ButtonDefinition.OnExecute -= this.OnExecuteDelegate;
            this.OnExecuteDelegate = null;
        }
    }
}
