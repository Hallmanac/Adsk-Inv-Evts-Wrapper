using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class UserInputEventsLib : IUserInputEventsLib
    {
        private Inventor.Application inventorApp;

        public UserInputEventsSink_OnActivateCommandEventHandler OnActivateCommandDelegate
        { get; set; }
        public UserInputEventsSink_OnContextMenuEventHandler OnContextMenuDelegate
        { get; set; }
        public UserInputEventsSink_OnDoubleClickEventHandler OnDoubleClickDelegate
        { get; set; }
        public UserInputEventsSink_OnDragEventHandler OnDragDelegate
        { get; set; }
        public UserInputEventsSink_OnStartCommandEventHandler OnStartCommandDelegate
        { get; set; }/*Use with 2010*/
        public UserInputEventsSink_OnStopCommandEventHandler OnStopCommandDelegate
        { get; set; }/*Use with 2010*/
        public UserInputEventsSink_OnTerminateCommandEventHandler OnTerminateCommandDelegate
        { get; set; }
        public UserInputEventsSink_OnPreSelectEventHandler OnPreSelectDelegate
        { get; set; }/*Use with 2011*/
        public UserInputEventsSink_OnSelectEventHandler OnSelectDelegate
        { get; set; }/*Use with 2011*/
        public UserInputEventsSink_OnStopPreSelectEventHandler OnStopPreSelectDelegate
        { get; set; }/*Use with 2011*/
        public UserInputEventsSink_OnUnSelectEventHandler OnUnSelectDelegate
        { get; set; }/*Use with 2011*/

        public UserInputEvents UserInputEvents { get; private set; }

        public UserInputEventsLib(Inventor.Application inventorApp)
        {
            this.inventorApp = inventorApp;
            this.UserInputEvents = inventorApp.CommandManager.UserInputEvents;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.UserInputEvents.OnActivateCommand -= this.OnActivateCommandDelegate;
            this.OnActivateCommandDelegate = null;

            this.UserInputEvents.OnContextMenu -= this.OnContextMenuDelegate;
            this.OnContextMenuDelegate = null;

            this.UserInputEvents.OnDoubleClick -= this.OnDoubleClickDelegate;
            this.OnDoubleClickDelegate = null;

            this.UserInputEvents.OnDrag -= this.OnDragDelegate;
            this.OnDragDelegate = null;

            this.UserInputEvents.OnPreSelect -= this.OnPreSelectDelegate;
            this.OnPreSelectDelegate = null;

            this.UserInputEvents.OnSelect -= this.OnSelectDelegate;
            this.OnSelectDelegate = null;

            this.UserInputEvents.OnStartCommand -= this.OnStartCommandDelegate;
            this.OnStartCommandDelegate = null;

            this.UserInputEvents.OnStopCommand -= this.OnStopCommandDelegate;
            this.OnStopCommandDelegate = null;

            this.UserInputEvents.OnStopPreSelect -= this.OnStopPreSelectDelegate;
            this.OnStopPreSelectDelegate = null;

            this.UserInputEvents.OnTerminateCommand -= this.OnTerminateCommandDelegate;
            this.OnTerminateCommandDelegate = null;

            this.UserInputEvents.OnUnSelect -= this.OnUnSelectDelegate;
            this.OnUnSelectDelegate = null;
        }
    }
}
