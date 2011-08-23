using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class BrowserPanesEventsLib : IBrowserPanesEventsLib
    {
        private Inventor.Application inventorApp;

        public BrowserPanesSink_OnBrowserNodeActivateEventHandler OnBrowserNodeActivateDelegate
        { get; set; }
        public BrowserPanesSink_OnBrowserNodeDeleteEntryEventHandler
            OnBrowserNodeDeleteEntryDelegate { get; set; }
        public BrowserPanesSink_OnBrowserNodeGetDisplayObjectsEventHandler
            OnBrowserNodeGetDisplayObjectsDelegate { get; set; }
        public BrowserPanesSink_OnBrowserNodeLabelEditEventHandler OnBrowserNodeLabelEditDelegate
        { get; set; }

        public BrowserPanesEvents BrowserPanesEvents { get; private set; }

        public BrowserPanesEventsLib(Inventor.Application inventorApp, Document document)
        {
            this.inventorApp = inventorApp;
            this.BrowserPanesEvents = document.BrowserPanes.BrowserPanesEvents;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.BrowserPanesEvents.OnBrowserNodeActivate -= this.OnBrowserNodeActivateDelegate;
            this.OnBrowserNodeActivateDelegate = null;

            this.BrowserPanesEvents.OnBrowserNodeDeleteEntry -=
                this.OnBrowserNodeDeleteEntryDelegate;
            this.OnBrowserNodeDeleteEntryDelegate = null;

            this.BrowserPanesEvents.OnBrowserNodeGetDisplayObjects -=
                this.OnBrowserNodeGetDisplayObjectsDelegate;
            this.OnBrowserNodeGetDisplayObjectsDelegate = null;

            this.BrowserPanesEvents.OnBrowserNodeLabelEdit -= this.OnBrowserNodeLabelEditDelegate;
            this.OnBrowserNodeLabelEditDelegate = null;
        }
    }
}
