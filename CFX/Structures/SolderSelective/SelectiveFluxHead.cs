using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures.SolderSelective
{
    /// <summary>
    /// <para>** NOTE: ADDED in CFX 2.0 **</para>
    /// Flux head information.
    /// </summary>
    [CFX.Utilities.CreatedVersion("2.0")]
    public class SelectiveFluxHead
    {
        /// <summary>
        /// 1 based sequence (1, 2, 3, ...)
        /// </summary>
        public int Sequence { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="FluxHead"/> is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the process time reading value.
        /// </summary>
        public TimeSpan ProcessTimeReadingValue { get; set; }

        /// <summary>
        /// Gets or sets the flux tank pressure set value in mbar.
        /// </summary>
        public int FluxTankPressureSetValue { get; set; }

        /// <summary>
        /// Gets or sets the flux tank pressure reading point in mbar.
        /// </summary>
        public int FluxTankPressureReadingPoint { get; set; }
    }
}
