using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures.SolderSelective
{
    /// <summary>
    /// <para>** NOTE: ADDED in CFX 2.0 **</para>
    /// Preheating section information.
    /// </summary>
    [CFX.Utilities.CreatedVersion("2.0")]
    public class SelectivePreheatingSection
    {
        public double PowerSetValue { get; set; }

        /// <summary>
        /// Gets or sets the power reading point.
        /// </summary>
        public double PowerReadingPoint { get; set; }

        /// <summary>
        /// Gets or sets the temperature reading value.
        /// </summary>
        public double TemperatureReadingValue { get; set; }

        /// <summary>
        /// Gets or sets the process time reading value.
        /// </summary>
        public TimeSpan ProcessTimeReadingValue { get; set; }
    }
}
