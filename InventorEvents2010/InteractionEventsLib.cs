using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
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
                if(interactionEvents == null)
                {
                    interactionEvents = this.inventorApp.CommandManager.CreateInteractionEvents();
                }
                return interactionEvents;
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
            this.InteractionEvents.OnActivate -= this.OnActivateDelegate;
            this.OnActivateDelegate = null;

            this.InteractionEvents.OnHelp -= this.OnHelpDelegate;
            this.OnHelpDelegate = null;

            this.InteractionEvents.OnResume -= this.OnResumeDelegate;
            this.OnResumeDelegate = null;

            this.InteractionEvents.OnSuspend -= this.OnSuspendDelegate;
            this.OnSuspendDelegate = null;

            this.InteractionEvents.OnTerminate -= this.OnTerminateDelegate;
            this.OnTerminateDelegate = null;
        }
    }
}
