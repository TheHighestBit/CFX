using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures.SolderWave
{
    [CFX.Utilities.CreatedVersion("2.0")]
    public class SolderFeederControl
    {
        /// <summary>
        /// Gets or sets a value indicating whether solder level is above min.
        /// </summary>
        public bool SolderLevelMinOk { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether solder level is below max.
        /// </summary>
        public bool SolderLevelMaxOk { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether solder feed is active.
        /// </summary>
        public bool SolderFeedActive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether solder level test is active.
        /// </summary>
        public bool SolderLevelTestActive { get; set; }
    }
}
