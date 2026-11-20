namespace SunamoWpf.Extensions.FileSystemWatcherExtended;

    /// <summary>
    /// Represents the path availablitiy event args type.
    /// </summary>
    public class PathAvailablitiyEventArgs : EventArgs
    {
        bool pathIsAvailable = false;
        /// <summary>
        /// The path is available.
        /// </summary>
        public bool PathIsAvailable
        {
            get
            {
                return pathIsAvailable;
            }
            set
            {
                pathIsAvailable = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the path availablitiy event args class.
        /// </summary>
        /// <param name="available">The available.</param>
        public PathAvailablitiyEventArgs(bool available)
        {
            this.PathIsAvailable = available;
        }
    }
//}