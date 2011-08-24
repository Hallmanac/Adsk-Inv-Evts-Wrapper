using Inventor;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class ModelingEventsLib : IModelingEventsLib
    {
        private Application inventorApp;

        public ModelingEventsLib(Application inventorApp)
        {
            this.inventorApp = inventorApp;
            ModelingEvents = inventorApp.ModelingEvents;
            Activate();
        }

        #region IModelingEventsLib Members

        public ModelingEventsSink_OnClientFeatureDoubleClickEventHandler
            OnClientFeatureDoubleClickDelegate { get; set; }

        public ModelingEventsSink_OnClientFeatureSolveEventHandler OnClientFeatureSolveDelegate { get; set; }
        public ModelingEventsSink_OnDeleteEventHandler OnDeleteDelegate { get; set; }
        public ModelingEventsSink_OnFeatureChangeEventHandler OnFeatureChangeDelegate { get; set; }
        public ModelingEventsSink_OnGenerateMemberEventHandler OnGenerateMemberDelegate { get; set; }
        public ModelingEventsSink_OnNewFeatureEventHandler OnNewFeatureDelegate { get; set; }
        public ModelingEventsSink_OnNewParameterEventHandler OnNewParameterDelegate { get; set; }
        public ModelingEventsSink_OnParameterChangeEventHandler OnParameterChangeDelegate { get; set; }

        public ModelingEvents ModelingEvents { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            ModelingEvents.OnClientFeatureDoubleClick -=
                OnClientFeatureDoubleClickDelegate;
            OnClientFeatureDoubleClickDelegate = null;

            ModelingEvents.OnClientFeatureSolve -= OnClientFeatureSolveDelegate;
            OnClientFeatureSolveDelegate = null;

            ModelingEvents.OnDelete -= OnDeleteDelegate;
            OnDeleteDelegate = null;

            ModelingEvents.OnFeatureChange -= OnFeatureChangeDelegate;
            OnFeatureChangeDelegate = null;

            ModelingEvents.OnGenerateMember -= OnGenerateMemberDelegate;
            OnGenerateMemberDelegate = null;

            ModelingEvents.OnNewFeature -= OnNewFeatureDelegate;
            OnNewFeatureDelegate = null;

            ModelingEvents.OnNewParameter -= OnNewParameterDelegate;
            OnNewParameterDelegate = null;

            ModelingEvents.OnParameterChange -= OnParameterChangeDelegate;
            OnParameterChangeDelegate = null;
        }

        #endregion

        private void Activate()
        {
            ModelingEvents.OnClientFeatureDoubleClick +=
                OnClientFeatureDoubleClickDelegate;

            ModelingEvents.OnClientFeatureSolve += OnClientFeatureSolveDelegate;

            ModelingEvents.OnDelete += OnDeleteDelegate;

            ModelingEvents.OnFeatureChange += OnFeatureChangeDelegate;

            ModelingEvents.OnGenerateMember += OnGenerateMemberDelegate;

            ModelingEvents.OnNewFeature += OnNewFeatureDelegate;

            ModelingEvents.OnNewParameter += OnNewParameterDelegate;

            ModelingEvents.OnParameterChange += OnParameterChangeDelegate;
        }
    }
}