using Inventor;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class InteractionEventsLib : IInteractionEventsLib
    {
        private readonly Application inventorApp;
        private InteractionEvents interactionEvents;

        public InteractionEventsLib(Application inventorApp)
        {
            this.inventorApp = inventorApp;
            Activate();
        }

        #region IInteractionEventsLib Members

        public InteractionEventsSink_OnActivateEventHandler OnActivateDelegate { get; set; }
        public InteractionEventsSink_OnHelpEventHandler OnHelpDelegate { get; set; }
        public InteractionEventsSink_OnResumeEventHandler OnResumeDelegate { get; set; }
        public InteractionEventsSink_OnSuspendEventHandler OnSuspendDelegate { get; set; }
        public InteractionEventsSink_OnTerminateEventHandler OnTerminateDelegate { get; set; }

        public InteractionEvents InteractionEvents
        {
            set { interactionEvents = value; }

            get { return interactionEvents ?? (interactionEvents = inventorApp.CommandManager.CreateInteractionEvents()); }
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            InteractionEvents.OnActivate -= OnActivateDelegate;
            OnActivateDelegate = null;

            InteractionEvents.OnHelp -= OnHelpDelegate;
            OnHelpDelegate = null;

            InteractionEvents.OnResume -= OnResumeDelegate;
            OnResumeDelegate = null;

            InteractionEvents.OnSuspend -= OnSuspendDelegate;
            OnSuspendDelegate = null;

            InteractionEvents.OnTerminate -= OnTerminateDelegate;
            OnTerminateDelegate = null;
        }

        #endregion

        private void Activate()
        {
            interactionEvents.OnActivate += OnActivateDelegate;

            interactionEvents.OnHelp += OnHelpDelegate;

            interactionEvents.OnResume += OnResumeDelegate;

            interactionEvents.OnSuspend += OnSuspendDelegate;

            interactionEvents.OnTerminate += OnTerminateDelegate;
        }
    }
}