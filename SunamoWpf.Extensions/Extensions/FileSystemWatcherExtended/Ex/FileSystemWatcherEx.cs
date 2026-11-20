namespace SunamoWpf.Extensions.FileSystemWatcherExtended.Ex;

    /// <summary>
    /// Represents the file system watcher ex type.
    /// </summary>
    public class FileSystemWatcherEx : FileSystemWatcher
    {
        // set a reasonable maximum interval time
        /// <summary>
        /// The max interval.
        /// </summary>
        public readonly int MaxInterval = 60000;

        /// <summary>
        /// The event path availability.
        /// </summary>
        public event PathAvailabilityHandler EventPathAvailability = delegate { };

        private bool IsNetworkAvailable = true;
        private int Interval = 100;
        /// <summary>
        /// The thread.
        /// </summary>
        public Thread thread = null;
        /// <summary>
        /// The name.
        /// </summary>
        public string Name = "FileSystemWatcherEx";
        /// <summary>
        /// The run.
        /// </summary>
        public bool Run = false;

        #region Constructors
        // -------------------------------------------------------------------------------
        /// <summary>
        /// Initializes a new instance of the file system watcher ex class.
        /// </summary>
        public FileSystemWatcherEx()
            : base()
        {
            CreateThread();
        }

        // -------------------------------------------------------------------------------
        /// <summary>
        /// Initializes a new instance of the file system watcher ex class.
        /// </summary>
        /// <param name="path">The path.</param>
        public FileSystemWatcherEx(string path)
            : base(path)
        {
            CreateThread();
        }

        // -------------------------------------------------------------------------------
        /// <summary>
        /// Initializes a new instance of the file system watcher ex class.
        /// </summary>
        /// <param name="interval">The interval.</param>
        public FileSystemWatcherEx(int interval)
            : base()
        {
            this.Interval = interval;
            CreateThread();
        }

        // -------------------------------------------------------------------------------
        /// <summary>
        /// Initializes a new instance of the file system watcher ex class.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="interval">The interval.</param>
        public FileSystemWatcherEx(string path, int interval)
            : base(path)
        {
            this.Interval = interval;
            CreateThread();
        }

        // -------------------------------------------------------------------------------
        /// <summary>
        /// Initializes a new instance of the file system watcher ex class.
        /// </summary>
        /// <param name="interval">The interval.</param>
        /// <param name="name">The name.</param>
        public FileSystemWatcherEx(int interval, string name)
            : base()
        {
            this.Interval = interval;
            this.Name = name;
            CreateThread();
        }

        // -------------------------------------------------------------------------------
        /// <summary>
        /// Initializes a new instance of the file system watcher ex class.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="name">The name.</param>
        public FileSystemWatcherEx(string path, int interval, string name)
            : base(path)
        {
            this.Interval = interval;
            this.Name = name;
            CreateThread();
        }
        #endregion Constructors

        #region Helper Methods
        // -------------------------------------------------------------------------------
        /// <summary>
        /// Creates the thread if the interval is greater than 0 milliseconds 
        /// </summary>
        private void CreateThread()
        {
            // Normalize  the interval
            this.Interval = Math.Max(0, Math.Min(this.Interval, this.MaxInterval));
            if (this.Interval > 0)
            {
                this.thread = new Thread(new ThreadStart(MonitorFolderAvailability));
                this.thread.Name = this.Name;
                this.thread.IsBackground = true;
            }
        }

        // -------------------------------------------------------------------------------
        /// <summary>
        /// Attempts to start the monitoring thread
        /// </summary>
        public void StartFolderMonitor()
        {
            this.Run = true;
            if (this.thread != null)
            {
                if (!thread.IsAlive)
                {
                    this.thread.Start();
                }
            }
        }

        // -------------------------------------------------------------------------------
        /// <summary>
        /// Attempts to start the monitoring thread
        /// </summary>
        public void StopFolderMonitor()
        {
            this.Run = false;
        }
        #endregion Helper Methods

        // -------------------------------------------------------------------------------
        /// <summary>
        /// The thread method. It sits and spins making sure the folder exists
        /// </summary>
        public void MonitorFolderAvailability()
        {
            while (this.Run)
            {
                if (this.IsNetworkAvailable)
                {
                    if (!Directory.Exists(base.Path))
                    {
                        this.IsNetworkAvailable = false;
                        RaiseEventNetworkPathAvailablity();
                    }
                }
                else
                {
                    if (Directory.Exists(base.Path))
                    {
                        this.IsNetworkAvailable = true;
                        RaiseEventNetworkPathAvailablity();
                    }
                }
                Thread.Sleep(this.Interval);
            }
        }

        // -------------------------------------------------------------------------------
        private void RaiseEventNetworkPathAvailablity()
        {
            EventPathAvailability(this, new PathAvailablitiyEventArgs(this.IsNetworkAvailable));
        }
    }