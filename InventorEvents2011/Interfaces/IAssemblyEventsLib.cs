using System;
using Inventor;

namespace InventorEvents2011.Interfaces
{
    public interface IAssemblyEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.AssemblyEvents object
        /// </summary>
        AssemblyEvents AssemblyEvents { get; }

        #region Event Handler Delegates
        AssemblyEventsSink_OnAssemblyChangedEventHandler OnAssemblyChangedDelegate { get; set; }
        AssemblyEventsSink_OnAssemblyChangeEventHandler OnAssemblyChangeDelegate { get; set; }
        AssemblyEventsSink_OnAssemblySolveEventHandler OnAssemblySolveDelegate { get; set; }
        AssemblyEventsSink_OnDeleteEventHandler OnDeleteDelegate { get; set; }
        AssemblyEventsSink_OnNewConstraintEventHandler OnNewConstraint { get; set; }
        AssemblyEventsSink_OnNewOccurrenceEventHandler OnNewOccurrenceDelegate { get; set; }
        AssemblyEventsSink_OnOccurrenceChangeEventHandler OnOccurrenceChangeDelegate { get; set; }
        #endregion

        /// <summary>
        /// Removes all event handler delegates from their respectives events and nullifies them
        /// </summary>
        void Deactivate();
    }
}
