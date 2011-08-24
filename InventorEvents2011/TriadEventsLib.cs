using Inventor;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class TriadEventsLib : ITriadEventsLib
    {
        private readonly Application invApp;
        private InteractionEvents localInteractionEvents;
        private TriadEvents triadEvents;

        public TriadEventsLib(Application inventorApp,
                              InteractionEvents interactionEvents = null)
        {
            invApp = inventorApp;

            if (interactionEvents == null) return;
            localInteractionEvents = interactionEvents;
            triadEvents = interactionEvents.TriadEvents;
            Activate();
        }

        #region ITriadEventsLib Members

        public TriadEventsSink_OnActivateEventHandler OnActivateDelegate { get; set; }
        public TriadEventsSink_OnEndMoveEventHandler OnEndMoveDelegate { get; set; }
        public TriadEventsSink_OnEndSequenceEventHandler OnEndSequenceDelegate { get; set; }
        public TriadEventsSink_OnMoveEventHandler OnMoveDelegate { get; set; }
        public TriadEventsSink_OnMoveTriadOnlyToggleEventHandler OnMoveTriadOnlyToggleDelegate { get; set; }

        public TriadEventsSink_OnSegmentSelectionChangeEventHandler
            OnSegmentSelectionChangeDelegate { get; set; }

        public TriadEventsSink_OnStartMoveEventHandler OnStartMoveDelegate { get; set; }
        public TriadEventsSink_OnStartSequenceEventHandler OnStartSequenceDelegate { get; set; }
        public TriadEventsSink_OnTerminateEventHandler OnTerminateDelegate { get; set; }

        public InteractionEvents LocalInteractionEvents
        {
            set { localInteractionEvents = value; }

            get
            {
                return localInteractionEvents ??
                       (localInteractionEvents = invApp.CommandManager.CreateInteractionEvents());
            }
        }

        public TriadEvents TriadEvents
        {
            get { return triadEvents ?? (triadEvents = LocalInteractionEvents.TriadEvents); }
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            triadEvents.OnActivate -= OnActivateDelegate;
            OnActivateDelegate = null;

            triadEvents.OnEndMove -= OnEndMoveDelegate;
            OnEndMoveDelegate = null;

            triadEvents.OnEndSequence -= OnEndSequenceDelegate;
            OnEndSequenceDelegate = null;

            triadEvents.OnMove -= OnMoveDelegate;
            OnMoveDelegate = null;

            triadEvents.OnMoveTriadOnlyToggle -= OnMoveTriadOnlyToggleDelegate;
            OnMoveTriadOnlyToggleDelegate = null;

            triadEvents.OnSegmentSelectionChange -= OnSegmentSelectionChangeDelegate;
            OnSegmentSelectionChangeDelegate = null;

            triadEvents.OnStartMove -= OnStartMoveDelegate;
            OnStartMoveDelegate = null;

            triadEvents.OnStartSequence -= OnStartSequenceDelegate;
            OnStartSequenceDelegate = null;

            triadEvents.OnTerminate -= OnTerminateDelegate;
            OnTerminateDelegate = null;
        }

        #endregion

        private void Activate()
        {
            triadEvents.OnActivate += OnActivateDelegate;

            triadEvents.OnEndMove += OnEndMoveDelegate;

            triadEvents.OnEndSequence += OnEndSequenceDelegate;

            triadEvents.OnMove += OnMoveDelegate;

            triadEvents.OnMoveTriadOnlyToggle += OnMoveTriadOnlyToggleDelegate;

            triadEvents.OnSegmentSelectionChange += OnSegmentSelectionChangeDelegate;

            triadEvents.OnStartMove += OnStartMoveDelegate;

            triadEvents.OnStartSequence += OnStartSequenceDelegate;

            triadEvents.OnTerminate += OnTerminateDelegate;
        }
    }
}