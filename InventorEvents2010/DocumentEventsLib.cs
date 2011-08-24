using Inventor;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class DocumentEventsLib : IDocumentEventsLib
    {
        private Application inventorApp;

        public DocumentEventsLib(Application inventorApp, Document document)
        {
            this.inventorApp = inventorApp;
            DocumentEvents = document.DocumentEvents;
            Activate();
        }

        #region IDocumentEventsLib Members

        public DocumentEventsSink_OnActivateEventHandler OnActivateDelegate { get; set; }
        public DocumentEventsSink_OnChangeEventHandler OnChangDelegate { get; set; }
        public DocumentEventsSink_OnChangeSelectSetEventHandler OnChangeSelectSetDelegate { get; set; }
        public DocumentEventsSink_OnCloseEventHandler OnCloseDelegate { get; set; }
        public DocumentEventsSink_OnDeactivateEventHandler OnDeactivateDelegate { get; set; }
        public DocumentEventsSink_OnDeleteEventHandler OnDeleteDelegate { get; set; }
        public DocumentEventsSink_OnSaveEventHandler OnSaveDelegate { get; set; }

        public DocumentEvents DocumentEvents { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            DocumentEvents.OnActivate -= OnActivateDelegate;
            OnActivateDelegate = null;

            DocumentEvents.OnChange -= OnChangDelegate;
            OnChangDelegate = null;

            DocumentEvents.OnChangeSelectSet -= OnChangeSelectSetDelegate;
            OnChangeSelectSetDelegate = null;

            DocumentEvents.OnClose -= OnCloseDelegate;
            OnCloseDelegate = null;

            DocumentEvents.OnDeactivate -= OnDeactivateDelegate;
            OnDeactivateDelegate = null;

            DocumentEvents.OnDelete -= OnDeleteDelegate;
            OnDeleteDelegate = null;

            DocumentEvents.OnSave -= OnSaveDelegate;
            OnSaveDelegate = null;
        }

        #endregion

        private void Activate()
        {
            DocumentEvents.OnActivate += OnActivateDelegate;

            DocumentEvents.OnChange += OnChangDelegate;

            DocumentEvents.OnChangeSelectSet += OnChangeSelectSetDelegate;

            DocumentEvents.OnClose += OnCloseDelegate;

            DocumentEvents.OnDeactivate += OnDeactivateDelegate;

            DocumentEvents.OnDelete += OnDeleteDelegate;

            DocumentEvents.OnSave += OnSaveDelegate;
        }
    }
}