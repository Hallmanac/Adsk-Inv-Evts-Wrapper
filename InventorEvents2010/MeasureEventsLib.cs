using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class MeasureEventsLib : IMeasureEventsLib
    {
        private Inventor.Application invApp;

        public MeasureEventsSink_OnMeasureEventHandler OnMeasureDelegate
        { get; set; }
        public MeasureEventsSink_OnSelectParameterEventHandler OnSelectParameterDelegate
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

        private MeasureEvents measureEvents;
        public MeasureEvents MeasureEvents
        {
            get 
            {
                if(this.measureEvents == null)
                {
                    this.measureEvents = this.LocalInteractionEvents.MeasureEvents;
                }
                return this.measureEvents; 
            }
        }

        public MeasureEventsLib(Inventor.Application inventorApp,
            InteractionEvents interactionEvents)
        {
            this.invApp = inventorApp;
            
            if (interactionEvents != null)
            {
                this.localInteractionEvents = interactionEvents;
                this.measureEvents = interactionEvents.MeasureEvents;                   
            }
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.measureEvents.OnMeasure -= this.OnMeasureDelegate;
            this.OnMeasureDelegate = null;

            this.measureEvents.OnSelectParameter -= this.OnSelectParameterDelegate;
            this.OnSelectParameterDelegate = null;
        }
    }
}
