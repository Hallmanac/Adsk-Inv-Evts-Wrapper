using Inventor;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class KeyboardEventsLib : IKeyboardEventsLib
    {
        private readonly Application invApp;
        private KeyboardEvents keyboardEvents;
        private InteractionEvents localInteractionEvents;

        public KeyboardEventsLib(Application inventorApp,
                                 InteractionEvents interactionEvents = null)
        {
            invApp = inventorApp;

            if (interactionEvents == null) return;
            localInteractionEvents = interactionEvents;
            keyboardEvents = interactionEvents.KeyboardEvents;
            Activate();
        }

        #region IKeyboardEventsLib Members

        public KeyboardEventsSink_OnKeyDownEventHandler OnKeyDownDelegate { get; set; }
        public KeyboardEventsSink_OnKeyPressEventHandler OnKeyPressDelegate { get; set; }
        public KeyboardEventsSink_OnKeyUpEventHandler OnKeyUpDelegate { get; set; }

        public InteractionEvents LocalInteractionEvents
        {
            set { localInteractionEvents = value; }

            get
            {
                return localInteractionEvents ??
                       (localInteractionEvents = invApp.CommandManager.CreateInteractionEvents());
            }
        }

        public KeyboardEvents KeyboardEvents
        {
            get { return keyboardEvents ?? (keyboardEvents = LocalInteractionEvents.KeyboardEvents); }
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            keyboardEvents.OnKeyDown -= OnKeyDownDelegate;
            OnKeyDownDelegate = null;

            keyboardEvents.OnKeyPress -= OnKeyPressDelegate;
            OnKeyPressDelegate = null;

            keyboardEvents.OnKeyUp -= OnKeyUpDelegate;
            OnKeyUpDelegate = null;
        }

        #endregion

        private void Activate()
        {
            KeyboardEvents.OnKeyDown += OnKeyDownDelegate;
            KeyboardEvents.OnKeyPress += OnKeyPressDelegate;
            KeyboardEvents.OnKeyUp += OnKeyUpDelegate;
        }
    }
}