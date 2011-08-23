using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class DocumentEventsLib : IDocumentEventsLib
    {
        private Inventor.Application inventorApp;

        public DocumentEventsSink_OnActivateEventHandler OnActivateDelegate
        { get; set; }
        public DocumentEventsSink_OnChangeEventHandler OnChangDelegate
        { get; set; }
        public DocumentEventsSink_OnChangeSelectSetEventHandler OnChangeSelectSetDelegate
        { get; set; }
        public DocumentEventsSink_OnCloseEventHandler OnCloseDelegate
        { get; set; }
        public DocumentEventsSink_OnDeactivateEventHandler OnDeactivateDelegate
        { get; set; }
        public DocumentEventsSink_OnDeleteEventHandler OnDeleteDelegate
        { get; set; }
        public DocumentEventsSink_OnSaveEventHandler OnSaveDelegate
        { get; set; }

        public DocumentEvents DocumentEvents { get; private set; }

        public DocumentEventsLib(Inventor.Application inventorApp, Document document)
        {
            this.inventorApp = inventorApp;
            this.DocumentEvents = document.DocumentEvents;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.DocumentEvents.OnActivate -= this.OnActivateDelegate;
            this.OnActivateDelegate = null;

            this.DocumentEvents.OnChange -= this.OnChangDelegate;
            this.OnChangDelegate = null;

            this.DocumentEvents.OnChangeSelectSet -= this.OnChangeSelectSetDelegate;
            this.OnChangeSelectSetDelegate = null;

            this.DocumentEvents.OnClose -= this.OnCloseDelegate;
            this.OnCloseDelegate = null;

            this.DocumentEvents.OnDeactivate -= this.OnDeactivateDelegate;
            this.OnDeactivateDelegate = null;

            this.DocumentEvents.OnDelete -= this.OnDeleteDelegate;
            this.OnDeleteDelegate = null;

            this.DocumentEvents.OnSave -= this.OnSaveDelegate;
            this.OnSaveDelegate = null;
        }
    }
}
