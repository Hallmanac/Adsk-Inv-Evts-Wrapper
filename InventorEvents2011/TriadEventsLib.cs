using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class TriadEventsLib : ITriadEventsLib
    {
        private Inventor.Application invApp;

        public TriadEventsSink_OnActivateEventHandler OnActivateDelegate
        { get; set; }
        public TriadEventsSink_OnEndMoveEventHandler OnEndMoveDelegate
        { get; set; }
        public TriadEventsSink_OnEndSequenceEventHandler OnEndSequenceDelegate
        { get; set; }
        public TriadEventsSink_OnMoveEventHandler OnMoveDelegate
        { get; set; }
        public TriadEventsSink_OnMoveTriadOnlyToggleEventHandler OnMoveTriadOnlyToggleDelegate
        { get; set; }
        public TriadEventsSink_OnSegmentSelectionChangeEventHandler
            OnSegmentSelectionChangeDelegate { get; set; }
        public TriadEventsSink_OnStartMoveEventHandler OnStartMoveDelegate
        { get; set; }
        public TriadEventsSink_OnStartSequenceEventHandler OnStartSequenceDelegate
        { get; set; }
        public TriadEventsSink_OnTerminateEventHandler OnTerminateDelegate
        { get; set; }

        private InteractionEvents localInteractionEvents;
        public InteractionEvents LocalInteractionEvents
        {
            set { this.localInteractionEvents = value; }

            get
            {
                if(this.localInteractionEvents == null)
                {
                    this.localInteractionEvents =
                        this.invApp.CommandManager.CreateInteractionEvents();
                }
                return this.localInteractionEvents;
            }
        }

        private TriadEvents triadEvents;
        public TriadEvents TriadEvents
        {
            get
            {
                if(this.triadEvents == null)
                {
                    this.triadEvents = this.LocalInteractionEvents.TriadEvents;
                }
                return this.triadEvents;
            }
        }

        public TriadEventsLib(Inventor.Application inventorApp,
            InteractionEvents interactionEvents = null)
        {
            this.invApp = inventorApp;

            if(interactionEvents != null)
            {
                this.localInteractionEvents = interactionEvents;
                this.triadEvents = interactionEvents.TriadEvents;
            }
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.triadEvents.OnActivate -= this.OnActivateDelegate;
            this.OnActivateDelegate = null;

            this.triadEvents.OnEndMove -= this.OnEndMoveDelegate;
            this.OnEndMoveDelegate = null;

            this.triadEvents.OnEndSequence -= this.OnEndSequenceDelegate;
            this.OnEndSequenceDelegate = null;

            this.triadEvents.OnMove -= this.OnMoveDelegate;
            this.OnMoveDelegate = null;

            this.triadEvents.OnMoveTriadOnlyToggle -= this.OnMoveTriadOnlyToggleDelegate;
            this.OnMoveTriadOnlyToggleDelegate = null;

            this.triadEvents.OnSegmentSelectionChange -= this.OnSegmentSelectionChangeDelegate;
            this.OnSegmentSelectionChangeDelegate = null;

            this.triadEvents.OnStartMove -= this.OnStartMoveDelegate;
            this.OnStartMoveDelegate = null;

            this.triadEvents.OnStartSequence -= this.OnStartSequenceDelegate;
            this.OnStartSequenceDelegate = null;

            this.triadEvents.OnTerminate -= this.OnTerminateDelegate;
            this.OnTerminateDelegate = null;
        }
    }
}
