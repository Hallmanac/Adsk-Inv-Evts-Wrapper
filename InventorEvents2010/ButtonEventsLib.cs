using Inventor;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class ButtonEventsLib : IButtonEventsLib
    {
        public ButtonEventsLib(ButtonDefinition buttonDef)
        {
            ButtonDef = buttonDef;
            Activate();
        }

        #region IButtonEventsLib Members

        public ButtonDefinitionSink_OnExecuteEventHandler OnExecuteDelegate { get; set; }
        //public ButtonDefinitionSink_OnHelpEventHandler OnHelpDelegate;/*Used in 2011*/

        public ButtonDefinition ButtonDef { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            ButtonDef.OnExecute -= OnExecuteDelegate;
            OnExecuteDelegate = null;
        }

        #endregion

        private void Activate()
        {
            ButtonDef.OnExecute += OnExecuteDelegate;
        }
    }
}