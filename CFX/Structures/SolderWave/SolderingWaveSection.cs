using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures.SolderWave
{
    /// <summary>
    /// <para>** NOTE: ADDED in CFX 2.0 **</para>
    /// Preheating section information.
    /// </summary>
    [CFX.Utilities.CreatedVersion("2.0")]
    public class SolderWaveSection
    {
        /// <summary>
        /// Gets or sets the power set value, representing the configured power level. 0-100%
        /// </summary>
        public double PowerSetValue { get; set; }

        /// <summary>
        /// Gets or sets the power reading point.
        /// </summary>
        public double PowerReadingPoint { get; set; }

        /// <summary>
        /// Length of this section in centimeters.
        /// </summary>
        public double SectionLength { get; set; }

        /// <summary>
        /// Section sequence (1, 2, 3, ...)
        /// </summary>
        public int Sequence { get; set; }
    }
}
