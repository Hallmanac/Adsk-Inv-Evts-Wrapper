using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class ButtonEventsLib : IButtonEventsLib
    {
        public ButtonDefinitionSink_OnExecuteEventHandler OnExecuteDelegate
        { get; set; }
        //public ButtonDefinitionSink_OnHelpEventHandler OnHelpDelegate;/*Used in 2011*/

        public ButtonDefinition ButtonDef { get; private set; }

        public ButtonEventsLib(ButtonDefinition buttonDef)
        {
            this.ButtonDef = buttonDef;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.ButtonDef.OnExecute -= this.OnExecuteDelegate;
            this.OnExecuteDelegate = null;
        }
    }
}
