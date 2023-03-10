namespace Acknex.Interfaces
{
    /// <summary>
    /// Represents a Unity object container which holds an AcknexObject
    /// </summary>
    public interface IAcknexObjectContainer
    {
        /// <summary>
        /// Gets/Sets the AcknexObject this container holds.
        /// </summary>
        IAcknexObject AcknexObject { get; set; }
        /// <summary>
        /// Updates the Unity object representation when any property changes.
        /// </summary>
        void UpdateObject();
        /// <summary>
        /// Enables the Unity object representation.
        /// </summary>
        void Enable();
        /// <summary>
        /// Disables the Unity object representation.
        /// </summary>
        void Disable();
    }
}