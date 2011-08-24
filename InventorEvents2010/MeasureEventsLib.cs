using Inventor;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class MeasureEventsLib : IMeasureEventsLib
    {
        private readonly Application invApp;
        private InteractionEvents localInteractionEvents;
        private MeasureEvents measureEvents;

        public MeasureEventsLib(Application inventorApp,
                                InteractionEvents interactionEvents)
        {
            invApp = inventorApp;

            if (interactionEvents == null) return;
            localInteractionEvents = interactionEvents;
            measureEvents = interactionEvents.MeasureEvents;
            Activate();
        }

        #region IMeasureEventsLib Members

        public MeasureEventsSink_OnMeasureEventHandler OnMeasureDelegate { get; set; }
        public MeasureEventsSink_OnSelectParameterEventHandler OnSelectParameterDelegate { get; set; }

        public InteractionEvents LocalInteractionEvents
        {
            set { localInteractionEvents = value; }

            get
            {
                return localInteractionEvents ??
                       (localInteractionEvents = invApp.CommandManager.CreateInteractionEvents());
            }
        }

        public MeasureEvents MeasureEvents
        {
            get { return measureEvents ?? (measureEvents = LocalInteractionEvents.MeasureEvents); }
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void
            Deactivate()
        {
            measureEvents.OnMeasure -= OnMeasureDelegate;
            OnMeasureDelegate = null;

            measureEvents.OnSelectParameter -= OnSelectParameterDelegate;
            OnSelectParameterDelegate = null;
        }

        #endregion

        private void Activate()
        {
            MeasureEvents.OnMeasure += OnMeasureDelegate;
            MeasureEvents.OnSelectParameter += OnSelectParameterDelegate;
        }
    }
}