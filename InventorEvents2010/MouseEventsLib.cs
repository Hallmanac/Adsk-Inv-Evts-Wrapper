using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class MouseEventsLib : IMouseEventsLib
    {
        private Inventor.Application invApp;

        public MouseEventsSink_OnMouseClickEventHandler OnMouseClickDelegate
        { get; set; }
        public MouseEventsSink_OnMouseDoubleClickEventHandler OnMouseDoubleClickDelegate
        { get; set; }
        public MouseEventsSink_OnMouseDownEventHandler OnMouseDownDelegate
        { get; set; }
        public MouseEventsSink_OnMouseLeaveEventHandler OnMouseLeaveDelegate
        { get; set; }
        public MouseEventsSink_OnMouseMoveEventHandler OnMouseMoveDelegate
        { get; set; }
        public MouseEventsSink_OnMouseUpEventHandler OnMouseUpDelegate
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

        private MouseEvents mouseEvents;
        public MouseEvents MouseEvents
        {
            get 
            {
                if(this.mouseEvents == null)
                {
                    this.mouseEvents = this.LocalInteractionEvents.MouseEvents;
                }
                return this.mouseEvents; 
            }
        }

        //Constructor
        public MouseEventsLib(Inventor.Application inventorApp,
            InteractionEvents interactionEvents = null)
        {
            this.invApp = inventorApp;
            
            if (interactionEvents != null)
            {
                this.localInteractionEvents = interactionEvents;
                this.mouseEvents = interactionEvents.MouseEvents;                   
            }
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.mouseEvents.OnMouseClick -= this.OnMouseClickDelegate;
            this.OnMouseClickDelegate = null;

            this.mouseEvents.OnMouseDoubleClick -= this.OnMouseDoubleClickDelegate;
            this.OnMouseDoubleClickDelegate = null;

            this.mouseEvents.OnMouseDown -= this.OnMouseDownDelegate;
            this.OnMouseDownDelegate = null;

            this.mouseEvents.OnMouseLeave -= this.OnMouseLeaveDelegate;
            this.OnMouseLeaveDelegate = null;

            this.mouseEvents.OnMouseMove -= this.OnMouseMoveDelegate;
            this.OnMouseMoveDelegate = null;

            this.mouseEvents.OnMouseUp -= this.OnMouseUpDelegate;
            this.OnMouseUpDelegate = null;
        }
    }
}
