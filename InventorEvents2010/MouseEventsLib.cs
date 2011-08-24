using Inventor;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class MouseEventsLib : IMouseEventsLib
    {
        private readonly Application invApp;
        private InteractionEvents localInteractionEvents;
        private MouseEvents mouseEvents;

        public MouseEventsLib(Application inventorApp,
                              InteractionEvents interactionEvents = null)
        {
            invApp = inventorApp;

            if (interactionEvents == null) return;
            localInteractionEvents = interactionEvents;
            mouseEvents = interactionEvents.MouseEvents;
            Activate();
        }

        #region IMouseEventsLib Members

        public MouseEventsSink_OnMouseClickEventHandler OnMouseClickDelegate { get; set; }
        public MouseEventsSink_OnMouseDoubleClickEventHandler OnMouseDoubleClickDelegate { get; set; }
        public MouseEventsSink_OnMouseDownEventHandler OnMouseDownDelegate { get; set; }
        public MouseEventsSink_OnMouseLeaveEventHandler OnMouseLeaveDelegate { get; set; }
        public MouseEventsSink_OnMouseMoveEventHandler OnMouseMoveDelegate { get; set; }
        public MouseEventsSink_OnMouseUpEventHandler OnMouseUpDelegate { get; set; }

        public InteractionEvents LocalInteractionEvents
        {
            set { localInteractionEvents = value; }

            get
            {
                return localInteractionEvents ??
                       (localInteractionEvents = invApp.CommandManager.CreateInteractionEvents());
            }
        }

        public MouseEvents MouseEvents
        {
            get { return mouseEvents ?? (mouseEvents = LocalInteractionEvents.MouseEvents); }
        }

        //Constructor

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            mouseEvents.OnMouseClick -= OnMouseClickDelegate;
            OnMouseClickDelegate = null;

            mouseEvents.OnMouseDoubleClick -= OnMouseDoubleClickDelegate;
            OnMouseDoubleClickDelegate = null;

            mouseEvents.OnMouseDown -= OnMouseDownDelegate;
            OnMouseDownDelegate = null;

            mouseEvents.OnMouseLeave -= OnMouseLeaveDelegate;
            OnMouseLeaveDelegate = null;

            mouseEvents.OnMouseMove -= OnMouseMoveDelegate;
            OnMouseMoveDelegate = null;

            mouseEvents.OnMouseUp -= OnMouseUpDelegate;
            OnMouseUpDelegate = null;
        }

        #endregion

        private void Activate()
        {
            mouseEvents.OnMouseClick += OnMouseClickDelegate;

            mouseEvents.OnMouseDoubleClick += OnMouseDoubleClickDelegate;

            mouseEvents.OnMouseDown += OnMouseDownDelegate;

            mouseEvents.OnMouseLeave += OnMouseLeaveDelegate;

            mouseEvents.OnMouseMove += OnMouseMoveDelegate;

            mouseEvents.OnMouseUp += OnMouseUpDelegate;
        }
    }
}