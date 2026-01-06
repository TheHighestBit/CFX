using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures.SolderSelective
{
    /// <summary>
    /// <para>** NOTE: ADDED in CFX 2.0 **</para>
    /// Wave unit process data information.
    /// </summary>
    [CFX.Utilities.CreatedVersion("2.0")]
    public class SelectiveUnitProcessData
    {
        /// <summary>
        /// Gets or sets the recipe used in production of this unit.
        /// </summary>
        public Recipe Recipe { get; set; }

        /// <summary>
        /// Gets or sets the flux stages.
        /// </summary>
        public List<FluxAggregate> FluxAggregates { get; set; }

        /// <summary>
        /// Gets or sets the preheating stages.
        /// </summary>
        public List<PreheatingAggregate> PreheatingAggregates { get; set; }

        /// <summary>
        /// Gets or sets the soldering stages.
        /// </summary>
        public List<SolderingAggregate> SolderingAggregates { get; set; }
    }
}
