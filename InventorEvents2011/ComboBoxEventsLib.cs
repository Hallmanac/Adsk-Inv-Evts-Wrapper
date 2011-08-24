using Inventor;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class ComboBoxEventsLib : IComboBoxEventsLib
    {
        public ComboBoxEventsLib(ComboBoxDefinition comboBoxDefinition)
        {
            ComboBoxDefinition = comboBoxDefinition;
            Activate();
        }

        #region IComboBoxEventsLib Members

        public ComboBoxDefinitionSink_OnSelectEventHandler OnSelectDelegate { get; set; }

        public ComboBoxDefinition ComboBoxDefinition { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            ComboBoxDefinition.OnSelect -= OnSelectDelegate;
            OnSelectDelegate = null;
        }

        #endregion

        private void Activate()
        {
            ComboBoxDefinition.OnSelect += OnSelectDelegate;
        }
    }
}