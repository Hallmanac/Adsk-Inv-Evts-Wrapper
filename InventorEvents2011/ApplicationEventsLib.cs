using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class ApplicationEventsLib : IApplicationEventsLib
    {
        private Inventor.Application inventorApp;

        public ApplicationEventsSink_OnActivateDocumentEventHandler OnActivateDocumentDelegate
        { get; set; }
        public ApplicationEventsSink_OnActivateViewEventHandler OnActivateViewDelegate
        { get; set; }
        public ApplicationEventsSink_OnActiveProjectChangedEventHandler
            OnActiveProjectChangedDelegate { get; set; }
        public ApplicationEventsSink_OnApplicationOptionChangeEventHandler
            OnApplicationOptionChangeDelegate { get; set; }
        public ApplicationEventsSink_OnCloseDocumentEventHandler OnCloseDocumentDelegate
        { get; set; }
        public ApplicationEventsSink_OnCloseViewEventHandler OnCloseViewDelegate
        { get; set; }
        public ApplicationEventsSink_OnDeactivateDocumentEventHandler OnDeactivateDocumentDelegate
        { get; set; }
        public ApplicationEventsSink_OnDeactivateViewEventHandler OnDeactivateViewDelegate
        { get; set; }
        public ApplicationEventsSink_OnDisplayModeChangeEventHandler OnDisplayModeChangeDelegate
        { get; set; }
        public ApplicationEventsSink_OnDocumentChangeEventHandler OnDocumentChangeDelegate
        { get; set; }
        public ApplicationEventsSink_OnInitializeDocumentEventHandler OnInitializeDocumentDelegate
        { get; set; }
        public ApplicationEventsSink_OnMigrateDocumentEventHandler OnMigrateDocumentDelegate
        { get; set; }
        public ApplicationEventsSink_OnNewDocumentEventHandler OnNewDocumentDelegate
        { get; set; }
        public ApplicationEventsSink_OnNewEditObjectEventHandler OnNewEditObjectDelegate
        { get; set; }
        public ApplicationEventsSink_OnNewViewEventHandler OnNewViewDelegate
        { get; set; }
        public ApplicationEventsSink_OnOpenDocumentEventHandler OnOpenDocumentDelegate
        { get; set; }
        public ApplicationEventsSink_OnQuitEventHandler OnQuitDelegate
        { get; set; }
        public ApplicationEventsSink_OnReadyEventHandler OnReadyDelegate
        { get; set; }
        public ApplicationEventsSink_OnSaveDocumentEventHandler OnSaveDocumentDelegate
        { get; set; }
        public ApplicationEventsSink_OnTerminateDocumentEventHandler OnTerminateDocumentDelegate
        { get; set; }
        public ApplicationEventsSink_OnTranslateDocumentEventHandler OnTranslateDocumentDelegate
        { get; set; }

        public ApplicationEvents ApplicationEvents { get; private set; }

        public ApplicationEventsLib(Inventor.Application inventorApp)
        {
            this.inventorApp = inventorApp;
            this.ApplicationEvents = this.inventorApp.ApplicationEvents;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.ApplicationEvents.OnActivateDocument -= this.OnActivateDocumentDelegate;
            this.OnActivateDocumentDelegate = null;

            this.ApplicationEvents.OnActivateView -= this.OnActivateViewDelegate;
            this.OnActivateViewDelegate = null;

            this.ApplicationEvents.OnActiveProjectChanged -= this.OnActiveProjectChangedDelegate;
            this.OnActiveProjectChangedDelegate = null;

            this.ApplicationEvents.OnApplicationOptionChange -=
                this.OnApplicationOptionChangeDelegate;
            this.OnApplicationOptionChangeDelegate = null;

            this.ApplicationEvents.OnCloseDocument -= this.OnCloseDocumentDelegate;
            this.OnCloseDocumentDelegate = null;

            this.ApplicationEvents.OnCloseView -= this.OnCloseViewDelegate;
            this.OnCloseViewDelegate = null;

            this.ApplicationEvents.OnDeactivateDocument -= this.OnDeactivateDocumentDelegate;
            this.OnDeactivateDocumentDelegate = null;

            this.ApplicationEvents.OnDeactivateView -= this.OnDeactivateViewDelegate;
            this.OnDeactivateViewDelegate = null;

            this.ApplicationEvents.OnDisplayModeChange -= this.OnDisplayModeChangeDelegate;
            this.OnDisplayModeChangeDelegate = null;

            this.ApplicationEvents.OnDocumentChange -= this.OnDocumentChangeDelegate;
            this.OnDocumentChangeDelegate = null;

            this.ApplicationEvents.OnInitializeDocument -= this.OnInitializeDocumentDelegate;
            this.OnInitializeDocumentDelegate = null;

            this.ApplicationEvents.OnMigrateDocument -= this.OnMigrateDocumentDelegate;
            this.OnMigrateDocumentDelegate = null;

            this.ApplicationEvents.OnNewDocument -= this.OnNewDocumentDelegate;
            this.OnNewDocumentDelegate = null;

            this.ApplicationEvents.OnNewEditObject -= this.OnNewEditObjectDelegate;
            this.OnNewEditObjectDelegate = null;

            this.ApplicationEvents.OnNewView -= this.OnNewViewDelegate;
            this.OnNewViewDelegate = null;

            this.ApplicationEvents.OnOpenDocument -= this.OnOpenDocumentDelegate;
            this.OnOpenDocumentDelegate = null;

            this.ApplicationEvents.OnQuit -= this.OnQuitDelegate;
            this.OnQuitDelegate = null;

            this.ApplicationEvents.OnReady -= this.OnReadyDelegate;
            this.OnReadyDelegate = null;

            this.ApplicationEvents.OnSaveDocument -= this.OnSaveDocumentDelegate;
            this.OnSaveDocumentDelegate = null;

            this.ApplicationEvents.OnTerminateDocument -= this.OnTerminateDocumentDelegate;
            this.OnTerminateDocumentDelegate = null;

            this.ApplicationEvents.OnTranslateDocument -= this.OnTranslateDocumentDelegate;
            this.OnTranslateDocumentDelegate = null;
        }
    }
}
