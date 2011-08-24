using Inventor;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class UserInputEventsLib : IUserInputEventsLib
    {
        public UserInputEventsLib(Application inventorApp)
        {
            UserInputEvents = inventorApp.CommandManager.UserInputEvents;
            Activate();
        }

        #region IUserInputEventsLib Members

        public UserInputEventsSink_OnActivateCommandEventHandler OnActivateCommandDelegate { get; set; }
        public UserInputEventsSink_OnContextMenuEventHandler OnContextMenuDelegate { get; set; }
        public UserInputEventsSink_OnDoubleClickEventHandler OnDoubleClickDelegate { get; set; }
        public UserInputEventsSink_OnDragEventHandler OnDragDelegate { get; set; }
        public UserInputEventsSink_OnStartCommandEventHandler OnStartCommandDelegate { get; set; } /*Use with 2010*/
        public UserInputEventsSink_OnStopCommandEventHandler OnStopCommandDelegate { get; set; } /*Use with 2010*/
        public UserInputEventsSink_OnTerminateCommandEventHandler OnTerminateCommandDelegate { get; set; }
        //public UserInputEventsSink_OnPreSelectEventHandler OnPreSelectDelegate;/*Use with 2011*/
        //public UserInputEventsSink_OnSelectEventHandler OnSelectDelegate;/*Use with 2011*/
        //public UserInputEventsSink_OnStopPreSelectEventHandler OnStopPreSelectDelegate;/*Use with 2011*/
        //public UserInputEventsSink_OnUnSelectEventHandler OnUnSelectDelegate;/*Use with 2011*/

        public UserInputEvents UserInputEvents { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            UserInputEvents.OnActivateCommand -= OnActivateCommandDelegate;
            OnActivateCommandDelegate = null;

            UserInputEvents.OnContextMenu -= OnContextMenuDelegate;
            OnContextMenuDelegate = null;

            UserInputEvents.OnDoubleClick -= OnDoubleClickDelegate;
            OnDoubleClickDelegate = null;

            UserInputEvents.OnDrag -= OnDragDelegate;
            OnDragDelegate = null;

            UserInputEvents.OnStartCommand -= OnStartCommandDelegate;
            OnStartCommandDelegate = null;

            UserInputEvents.OnStopCommand -= OnStopCommandDelegate;
            OnStopCommandDelegate = null;

            UserInputEvents.OnTerminateCommand -= OnTerminateCommandDelegate;
            OnTerminateCommandDelegate = null;
        }

        #endregion

        private void Activate()
        {
            UserInputEvents.OnActivateCommand += OnActivateCommandDelegate;

            UserInputEvents.OnContextMenu += OnContextMenuDelegate;

            UserInputEvents.OnDoubleClick += OnDoubleClickDelegate;

            UserInputEvents.OnDrag += OnDragDelegate;

            UserInputEvents.OnStartCommand += OnStartCommandDelegate;

            UserInputEvents.OnStopCommand += OnStopCommandDelegate;

            UserInputEvents.OnTerminateCommand += OnTerminateCommandDelegate;
        }
    }
}