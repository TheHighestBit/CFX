using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures.SolderSelective
{
    /// <summary>
    /// <para>** NOTE: ADDED in CFX 2.0 **</para>
    /// Flux aggregate representation. 
    /// </summary>
    [CFX.Utilities.CreatedVersion("2.0")]
    public class FluxAggregate : Aggregate
    {
        /// <summary>
        /// Gets or sets SelectiveFluxHeads.
        /// </summary>
        public List<SelectiveFluxHead> FluxHeads { get; set; }
    }
}
