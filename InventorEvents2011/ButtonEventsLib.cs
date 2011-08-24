using Inventor;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class ButtonEventsLib : IButtonEventsLib
    {
        public ButtonEventsLib(ButtonDefinition buttonDef)
        {
            ButtonDefinition = buttonDef;
            Activate();
        }

        #region IButtonEventsLib Members

        public ButtonDefinitionSink_OnExecuteEventHandler OnExecuteDelegate { get; set; }
        public ButtonDefinitionSink_OnHelpEventHandler OnHelpDelegate { get; set; } /*Used in 2011*/

        public ButtonDefinition ButtonDefinition { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            ButtonDefinition.OnExecute -= OnExecuteDelegate;
            OnExecuteDelegate = null;
            ButtonDefinition.OnHelp -= OnHelpDelegate;
            OnHelpDelegate = null;
        }

        #endregion

        private void Activate()
        {
            ButtonDefinition.OnExecute += OnExecuteDelegate;
            ButtonDefinition.OnHelp += OnHelpDelegate;
        }
    }
}