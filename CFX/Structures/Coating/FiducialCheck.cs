using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures.Coating
{
    public class FiducialCheck
    {

        /// <summary>
        /// The result of the fiducial check. True if within tolerance, false otherwise.
        /// </summary>
        public bool Result { get; set; }

        /// <summary>
        /// The X offset of the corrected fiducial, in millimeters.
        /// </summary>
        public double XOffset
        {
            get;
            set;
        }
        /// <summary>
        /// The Y offset of the corrected fiducial, in millimeters
        /// </summary>
        public double YOffset
        {
            get;
            set;
        }
    }
}
