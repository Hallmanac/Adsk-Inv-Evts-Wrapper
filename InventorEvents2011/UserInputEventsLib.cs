using Inventor;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
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
        public UserInputEventsSink_OnStartCommandEventHandler OnStartCommandDelegate { get; set; }
        /*Use with 2010*/
        public UserInputEventsSink_OnStopCommandEventHandler OnStopCommandDelegate { get; set; }
        /*Use with 2010*/
        public UserInputEventsSink_OnTerminateCommandEventHandler OnTerminateCommandDelegate { get; set; }
        public UserInputEventsSink_OnPreSelectEventHandler OnPreSelectDelegate { get; set; } /*Use with 2011*/
        public UserInputEventsSink_OnSelectEventHandler OnSelectDelegate { get; set; } /*Use with 2011*/
        public UserInputEventsSink_OnStopPreSelectEventHandler OnStopPreSelectDelegate { get; set; } /*Use with 2011*/
        public UserInputEventsSink_OnUnSelectEventHandler OnUnSelectDelegate { get; set; } /*Use with 2011*/

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

            UserInputEvents.OnPreSelect -= OnPreSelectDelegate;
            OnPreSelectDelegate = null;

            UserInputEvents.OnSelect -= OnSelectDelegate;
            OnSelectDelegate = null;

            UserInputEvents.OnStartCommand -= OnStartCommandDelegate;
            OnStartCommandDelegate = null;

            UserInputEvents.OnStopCommand -= OnStopCommandDelegate;
            OnStopCommandDelegate = null;

            UserInputEvents.OnStopPreSelect -= OnStopPreSelectDelegate;
            OnStopPreSelectDelegate = null;

            UserInputEvents.OnTerminateCommand -= OnTerminateCommandDelegate;
            OnTerminateCommandDelegate = null;

            UserInputEvents.OnUnSelect -= OnUnSelectDelegate;
            OnUnSelectDelegate = null;
        }

        #endregion

        private void Activate()
        {
            UserInputEvents.OnActivateCommand += OnActivateCommandDelegate;

            UserInputEvents.OnContextMenu += OnContextMenuDelegate;

            UserInputEvents.OnDoubleClick += OnDoubleClickDelegate;

            UserInputEvents.OnDrag += OnDragDelegate;

            UserInputEvents.OnPreSelect += OnPreSelectDelegate;

            UserInputEvents.OnSelect += OnSelectDelegate;

            UserInputEvents.OnStartCommand += OnStartCommandDelegate;

            UserInputEvents.OnStopCommand += OnStopCommandDelegate;

            UserInputEvents.OnStopPreSelect += OnStopPreSelectDelegate;

            UserInputEvents.OnTerminateCommand += OnTerminateCommandDelegate;

            UserInputEvents.OnUnSelect += OnUnSelectDelegate;
        }
    }
}