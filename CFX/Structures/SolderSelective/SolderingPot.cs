using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures.SolderSelective
{
    /// <summary>
    /// Soldering pot information. 
    /// </summary>
    [CFX.Utilities.CreatedVersion("2.0")]
    public class SolderingPot
    {
        /// <summary>
        /// Determines whether the stage (module) was during the processing active or not.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// 1 based sequence (1, 2, 3, ...)
        /// </summary>
        public int Sequence { get; set; }

        /// <summary>
        /// Gets or sets the process time reading value.
        /// </summary>
        public TimeSpan ProcessTimeReadingValue { get; set; }

        /// <summary>
        /// Name of the soldering nozzle. Eg. "8/12" - 8 inner mm, 12 outer mm.
        /// </summary>
        public String NozzleName { get; set; }

        /// <summary>
        /// Gets or sets the gradient value used to define the wave effect intensity.
        /// </summary>
        public int WaveGradient { get; set; }

        /// <summary>
        /// Gets or sets the dynamic offset applied to the wave calculation.
        /// </summary>
        public int WaveOffsetDynamic { get; set; }

        /// <summary>
        /// Gets or sets the measured wave deviation in mm.
        /// </summary>
        public double WaveDeviation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether oxygen measurement is active.
        /// </summary>
        public bool O2MeasurementActive { get; set; }

        /// <summary>
        /// Gets or sets the residual O2 reading value ppm.
        /// </summary>
        public int O2ReadingValue { get; set; }

        /// <summary>
        /// Gets or sets the n2 reading value in l/min.
        /// </summary>
        public double N2ReadingValue { get; set; }

        /// <summary>
        /// Gets or sets the n2 setpoint in l/min.
        /// </summary>
        public double N2Setpoint { get; set; }

        /// <summary>
        /// Gets or sets solder pot heating information.
        /// </summary>
        public SolderPotHeating Heating { get; set; }
    }
}
