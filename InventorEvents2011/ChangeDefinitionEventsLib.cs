using Inventor;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class ChangeDefinitionEventsLib : IChangeDefinitionEventsLib
    {
        public ChangeDefinitionEventsLib(ChangeDefinition changeDefinition)
        {
            ChangeDefinition = changeDefinition;
            Activate();
        }

        #region IChangeDefinitionEventsLib Members

        public ChangeDefinitionSink_OnReplayEventHandler OnReplayDelegate { get; set; }

        public ChangeDefinition ChangeDefinition { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            ChangeDefinition.OnReplay -= OnReplayDelegate;
            OnReplayDelegate = null;
        }

        #endregion

        private void Activate()
        {
            ChangeDefinition.OnReplay += OnReplayDelegate;
        }
    }
}