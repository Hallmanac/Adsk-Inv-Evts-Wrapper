using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class InteractionEventsLib : IInteractionEventsLib
    {
        private Inventor.Application inventorApp;

        public InteractionEventsSink_OnActivateEventHandler OnActivateDelegate
        { get; set; }
        public InteractionEventsSink_OnHelpEventHandler OnHelpDelegate
        { get; set; }
        public InteractionEventsSink_OnResumeEventHandler OnResumeDelegate
        { get; set; }
        public InteractionEventsSink_OnSuspendEventHandler OnSuspendDelegate
        { get; set; }
        public InteractionEventsSink_OnTerminateEventHandler OnTerminateDelegate
        { get; set; }

        private InteractionEvents interactionEvents;
        public InteractionEvents InteractionEvents
        {
            set { interactionEvents = value; }
            get
            {
                if(this.interactionEvents == null)
                {
                    this.interactionEvents =
                        this.inventorApp.CommandManager.CreateInteractionEvents();
                }
                return this.interactionEvents;
            }
        }

        public InteractionEventsLib(Inventor.Application inventorApp)
        {
            this.inventorApp = inventorApp;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.interactionEvents.OnActivate -= this.OnActivateDelegate;
            this.OnActivateDelegate = null;

            this.interactionEvents.OnHelp -= this.OnHelpDelegate;
            this.OnHelpDelegate = null;

            this.interactionEvents.OnResume -= this.OnResumeDelegate;
            this.OnResumeDelegate = null;

            this.interactionEvents.OnSuspend -= this.OnSuspendDelegate;
            this.OnSuspendDelegate = null;

            this.interactionEvents.OnTerminate -= this.OnTerminateDelegate;
            this.OnTerminateDelegate = null;
        }
    }
}
