using Inventor;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class ApplicationEventsLib : IApplicationEventsLib
    {
        private readonly Application inventorApp;

        public ApplicationEventsLib(Application inventorApp)
        {
            this.inventorApp = inventorApp;
            ApplicationEvents = this.inventorApp.ApplicationEvents;
            Activate();
        }

        #region IApplicationEventsLib Members

        public ApplicationEventsSink_OnActivateDocumentEventHandler OnActivateDocumentDelegate { get; set; }
        public ApplicationEventsSink_OnActivateViewEventHandler OnActivateViewDelegate { get; set; }

        public ApplicationEventsSink_OnActiveProjectChangedEventHandler
            OnActiveProjectChangedDelegate { get; set; }

        public ApplicationEventsSink_OnApplicationOptionChangeEventHandler
            OnApplicationOptionChangeDelegate { get; set; }

        public ApplicationEventsSink_OnCloseDocumentEventHandler OnCloseDocumentDelegate { get; set; }
        public ApplicationEventsSink_OnCloseViewEventHandler OnCloseViewDelegate { get; set; }
        public ApplicationEventsSink_OnDeactivateDocumentEventHandler OnDeactivateDocumentDelegate { get; set; }
        public ApplicationEventsSink_OnDeactivateViewEventHandler OnDeactivateViewDelegate { get; set; }
        public ApplicationEventsSink_OnDisplayModeChangeEventHandler OnDisplayModeChangeDelegate { get; set; }
        public ApplicationEventsSink_OnDocumentChangeEventHandler OnDocumentChangeDelegate { get; set; }
        public ApplicationEventsSink_OnInitializeDocumentEventHandler OnInitializeDocumentDelegate { get; set; }
        public ApplicationEventsSink_OnMigrateDocumentEventHandler OnMigrateDocumentDelegate { get; set; }
        public ApplicationEventsSink_OnNewDocumentEventHandler OnNewDocumentDelegate { get; set; }
        public ApplicationEventsSink_OnNewEditObjectEventHandler OnNewEditObjectDelegate { get; set; }
        public ApplicationEventsSink_OnNewViewEventHandler OnNewViewDelegate { get; set; }
        public ApplicationEventsSink_OnOpenDocumentEventHandler OnOpenDocumentDelegate { get; set; }
        public ApplicationEventsSink_OnQuitEventHandler OnQuitDelegate { get; set; }
        public ApplicationEventsSink_OnReadyEventHandler OnReadyDelegate { get; set; }
        public ApplicationEventsSink_OnSaveDocumentEventHandler OnSaveDocumentDelegate { get; set; }
        public ApplicationEventsSink_OnTerminateDocumentEventHandler OnTerminateDocumentDelegate { get; set; }
        public ApplicationEventsSink_OnTranslateDocumentEventHandler OnTranslateDocumentDelegate { get; set; }

        public ApplicationEvents ApplicationEvents { get; private set; }

        //Constructor

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            ApplicationEvents.OnActivateDocument -= OnActivateDocumentDelegate;
            OnActivateDocumentDelegate = null;

            ApplicationEvents.OnActivateView -= OnActivateViewDelegate;
            OnActivateViewDelegate = null;

            ApplicationEvents.OnActiveProjectChanged -= OnActiveProjectChangedDelegate;
            OnActiveProjectChangedDelegate = null;

            ApplicationEvents.OnApplicationOptionChange -=
                OnApplicationOptionChangeDelegate;
            OnApplicationOptionChangeDelegate = null;

            ApplicationEvents.OnCloseDocument -= OnCloseDocumentDelegate;
            OnCloseDocumentDelegate = null;

            ApplicationEvents.OnCloseView -= OnCloseViewDelegate;
            OnCloseViewDelegate = null;

            ApplicationEvents.OnDeactivateDocument -= OnDeactivateDocumentDelegate;
            OnDeactivateDocumentDelegate = null;

            ApplicationEvents.OnDeactivateView -= OnDeactivateViewDelegate;
            OnDeactivateViewDelegate = null;

            ApplicationEvents.OnDisplayModeChange -= OnDisplayModeChangeDelegate;
            OnDisplayModeChangeDelegate = null;

            ApplicationEvents.OnDocumentChange -= OnDocumentChangeDelegate;
            OnDocumentChangeDelegate = null;

            ApplicationEvents.OnInitializeDocument -= OnInitializeDocumentDelegate;
            OnInitializeDocumentDelegate = null;

            ApplicationEvents.OnMigrateDocument -= OnMigrateDocumentDelegate;
            OnMigrateDocumentDelegate = null;

            ApplicationEvents.OnNewDocument -= OnNewDocumentDelegate;
            OnNewDocumentDelegate = null;

            ApplicationEvents.OnNewEditObject -= OnNewEditObjectDelegate;
            OnNewEditObjectDelegate = null;

            ApplicationEvents.OnNewView -= OnNewViewDelegate;
            OnNewViewDelegate = null;

            ApplicationEvents.OnOpenDocument -= OnOpenDocumentDelegate;
            OnOpenDocumentDelegate = null;

            ApplicationEvents.OnQuit -= OnQuitDelegate;
            OnQuitDelegate = null;

            ApplicationEvents.OnReady -= OnReadyDelegate;
            OnReadyDelegate = null;

            ApplicationEvents.OnSaveDocument -= OnSaveDocumentDelegate;
            OnSaveDocumentDelegate = null;

            ApplicationEvents.OnTerminateDocument -= OnTerminateDocumentDelegate;
            OnTerminateDocumentDelegate = null;

            ApplicationEvents.OnTranslateDocument -= OnTranslateDocumentDelegate;
            OnTranslateDocumentDelegate = null;
        }

        #endregion

        private void Activate()
        {
            ApplicationEvents.OnActivateDocument += OnActivateDocumentDelegate;

            ApplicationEvents.OnActivateView += OnActivateViewDelegate;

            ApplicationEvents.OnActiveProjectChanged += OnActiveProjectChangedDelegate;

            ApplicationEvents.OnApplicationOptionChange += OnApplicationOptionChangeDelegate;

            ApplicationEvents.OnCloseDocument += OnCloseDocumentDelegate;

            ApplicationEvents.OnCloseView += OnCloseViewDelegate;

            ApplicationEvents.OnDeactivateDocument += OnDeactivateDocumentDelegate;

            ApplicationEvents.OnDeactivateView += OnDeactivateViewDelegate;

            ApplicationEvents.OnDisplayModeChange += OnDisplayModeChangeDelegate;

            ApplicationEvents.OnDocumentChange += OnDocumentChangeDelegate;

            ApplicationEvents.OnInitializeDocument += OnInitializeDocumentDelegate;

            ApplicationEvents.OnMigrateDocument += OnMigrateDocumentDelegate;

            ApplicationEvents.OnNewDocument += OnNewDocumentDelegate;

            ApplicationEvents.OnNewEditObject += OnNewEditObjectDelegate;

            ApplicationEvents.OnNewView += OnNewViewDelegate;

            ApplicationEvents.OnOpenDocument += OnOpenDocumentDelegate;

            ApplicationEvents.OnQuit += OnQuitDelegate;

            ApplicationEvents.OnReady += OnReadyDelegate;

            ApplicationEvents.OnSaveDocument += OnSaveDocumentDelegate;

            ApplicationEvents.OnTerminateDocument += OnTerminateDocumentDelegate;

            ApplicationEvents.OnTranslateDocument += OnTranslateDocumentDelegate;
        }
    }
}