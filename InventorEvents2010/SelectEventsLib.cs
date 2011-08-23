using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class SelectEventsLib : ISelectEventsLib
    {
        private Inventor.Application invApp;

        public SelectEventsSink_OnPreSelectEventHandler OnPreSelectDelegate
        { get; set; }
        public SelectEventsSink_OnPreSelectMouseMoveEventHandler OnPreSelectMouseMoveDelegate
        { get; set; }
        public SelectEventsSink_OnSelectEventHandler OnSelectDelegate
        { get; set; }
        public SelectEventsSink_OnStopPreSelectEventHandler OnStopPreSelectDelegate
        { get; set; }
        public SelectEventsSink_OnUnSelectEventHandler OnUnSelectDelegate
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

        private SelectEvents selectEvents;
        public SelectEvents SelectEvents
        {
            get 
            {
                if(this.selectEvents == null)
                {
                    this.selectEvents = this.LocalInteractionEvents.SelectEvents;
                }
                return this.selectEvents; 
            }
        }

        public SelectEventsLib(Inventor.Application inventorApp, 
            InteractionEvents interactionEvents = null)
        {
            this.invApp = inventorApp;
            
            if (interactionEvents != null)
            {
                this.localInteractionEvents = interactionEvents;
                this.selectEvents = interactionEvents.SelectEvents;                   
            }
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.selectEvents.OnPreSelect -= this.OnPreSelectDelegate;
            this.OnPreSelectDelegate = null;

            this.selectEvents.OnPreSelectMouseMove -= this.OnPreSelectMouseMoveDelegate;
            this.OnPreSelectMouseMoveDelegate = null;

            this.selectEvents.OnSelect -= this.OnSelectDelegate;
            this.OnSelectDelegate = null;

            this.selectEvents.OnStopPreSelect -= this.OnStopPreSelectDelegate;
            this.OnStopPreSelectDelegate = null;

            this.selectEvents.OnUnSelect -= this.OnUnSelectDelegate;
            this.OnUnSelectDelegate = null;
        }
    }
}
