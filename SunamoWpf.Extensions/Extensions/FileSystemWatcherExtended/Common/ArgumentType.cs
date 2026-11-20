namespace SunamoWpf.Extensions.FileSystemWatcherExtended.Common;

    /// This enum is used to indicate which argument type is valid in the WatcherEventArgs 
    /// object.
    /// </summary>
    public enum ArgumentType
    {
        /// <summary>
        /// A file system event.
        /// </summary>
        FileSystem,
        /// <summary>
        /// A rename event.
        /// </summary>
        Renamed,
        /// <summary>
        /// An error.
        /// </summary>
        Error,
        /// <summary>
        /// A standard event.
        /// </summary>
        StandardEvent,
        /// <summary>
        /// A path availability change.
        /// </summary>
        PathAvailability
    }