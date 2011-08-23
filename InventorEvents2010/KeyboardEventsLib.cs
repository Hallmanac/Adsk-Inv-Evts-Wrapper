using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class KeyboardEventsLib : IKeyboardEventsLib
    {
        private Inventor.Application invApp;
        
        public KeyboardEventsSink_OnKeyDownEventHandler OnKeyDownDelegate
        { get; set; }
        public KeyboardEventsSink_OnKeyPressEventHandler OnKeyPressDelegate
        { get; set; }
        public KeyboardEventsSink_OnKeyUpEventHandler OnKeyUpDelegate
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

        private KeyboardEvents keyboardEvents;
        public KeyboardEvents KeyboardEvents
        {
            get 
            {
                if(this.keyboardEvents == null)
                {
                    this.keyboardEvents = this.LocalInteractionEvents.KeyboardEvents;
                }
                return this.keyboardEvents; 
            }
        }

        public KeyboardEventsLib(Inventor.Application inventorApp, 
            InteractionEvents interactionEvents = null)
        {
            this.invApp = inventorApp;

            if (interactionEvents != null)
            {
                this.localInteractionEvents = interactionEvents;
                this.keyboardEvents = interactionEvents.KeyboardEvents;                  
            }
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.keyboardEvents.OnKeyDown -= this.OnKeyDownDelegate;
            this.OnKeyDownDelegate = null;

            this.keyboardEvents.OnKeyPress -= this.OnKeyPressDelegate;
            this.OnKeyPressDelegate = null;

            this.keyboardEvents.OnKeyUp -= this.OnKeyUpDelegate;
            this.OnKeyUpDelegate = null;
        }
    }
}
