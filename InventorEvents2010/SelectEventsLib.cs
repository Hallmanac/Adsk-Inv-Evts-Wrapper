using Inventor;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class SelectEventsLib : ISelectEventsLib
    {
        private readonly Application invApp;
        private InteractionEvents localInteractionEvents;
        private SelectEvents selectEvents;

        public SelectEventsLib(Application inventorApp,
                               InteractionEvents interactionEvents = null)
        {
            invApp = inventorApp;

            if (interactionEvents == null) return;
            localInteractionEvents = interactionEvents;
            selectEvents = interactionEvents.SelectEvents;
            Activate();
        }

        #region ISelectEventsLib Members

        public SelectEventsSink_OnPreSelectEventHandler OnPreSelectDelegate { get; set; }
        public SelectEventsSink_OnPreSelectMouseMoveEventHandler OnPreSelectMouseMoveDelegate { get; set; }
        public SelectEventsSink_OnSelectEventHandler OnSelectDelegate { get; set; }
        public SelectEventsSink_OnStopPreSelectEventHandler OnStopPreSelectDelegate { get; set; }
        public SelectEventsSink_OnUnSelectEventHandler OnUnSelectDelegate { get; set; }

        public InteractionEvents LocalInteractionEvents
        {
            set { localInteractionEvents = value; }

            get
            {
                return localInteractionEvents ??
                       (localInteractionEvents = invApp.CommandManager.CreateInteractionEvents());
            }
        }

        public SelectEvents SelectEvents
        {
            get { return selectEvents ?? (selectEvents = LocalInteractionEvents.SelectEvents); }
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            selectEvents.OnPreSelect -= OnPreSelectDelegate;
            OnPreSelectDelegate = null;

            selectEvents.OnPreSelectMouseMove -= OnPreSelectMouseMoveDelegate;
            OnPreSelectMouseMoveDelegate = null;

            selectEvents.OnSelect -= OnSelectDelegate;
            OnSelectDelegate = null;

            selectEvents.OnStopPreSelect -= OnStopPreSelectDelegate;
            OnStopPreSelectDelegate = null;

            selectEvents.OnUnSelect -= OnUnSelectDelegate;
            OnUnSelectDelegate = null;
        }

        #endregion

        private void Activate()
        {
            selectEvents.OnPreSelect += OnPreSelectDelegate;

            selectEvents.OnPreSelectMouseMove += OnPreSelectMouseMoveDelegate;

            selectEvents.OnSelect += OnSelectDelegate;

            selectEvents.OnStopPreSelect += OnStopPreSelectDelegate;

            selectEvents.OnUnSelect += OnUnSelectDelegate;
        }
    }
}