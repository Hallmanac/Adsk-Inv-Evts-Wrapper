using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class ChangeDefinitionEventsLib : IChangeDefinitionEventsLib
    {
        public ChangeDefinitionSink_OnReplayEventHandler OnReplayDelegate
        { get; set; }

        public ChangeDefinition ChangeDefinition { get; private set; }

        public ChangeDefinitionEventsLib(ChangeDefinition changeDefinition)
        {
            this.ChangeDefinition = changeDefinition;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.ChangeDefinition.OnReplay -= this.OnReplayDelegate;
            this.OnReplayDelegate = null;
        }
    }
}
