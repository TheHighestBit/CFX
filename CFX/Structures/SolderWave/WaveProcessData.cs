using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CFX.Structures.SolderWave
{
    /// <summary>
    /// <para>** NOTE: ADDED in CFX 2.0 **</para>
    /// Provides information about the conditions within a wave soldering machine.
    /// </summary>
    [CFX.Utilities.CreatedVersion("2.0")]
    [JsonObject(ItemTypeNameHandling = TypeNameHandling.Auto)]
    public class WaveProcessData : ProcessData
    {
        /// <summary>
        /// List of conveyor data (as seen while the processed unit was processed)
        /// </summary>
        public List<Conveyor> Conveyors { get; set; }

        /// <summary>
        /// Measured length [mm] of the unit.
        /// </summary>
        public double UnitLength { get; set; }

        /// <summary>
        /// Setpoint of the length [mm] of the unit.
        /// </summary>
        public double UnitLengthSetpoint { get; set; }

        /// <summary>
        /// Minimum time separation between boards [s].
        /// </summary>
        public TimeSpan BoardSeparationTime { get; set; }

        /// <summary>
        /// Gap to previous board [s].
        /// </summary>
        public TimeSpan GapToPreviousBoard { get; set; }

        /// <summary>
        /// Number of boards in the machine.
        /// </summary>
        public int BoardsInMachine { get; set; }

        /// <summary>
        /// Indicates whether the conveyor is empty.
        /// </summary>
        public bool ConveyorEmpty { get; set; }

        /// <summary>
        /// Gets or sets the electrical cabinet temperature in °C.
        /// </summary>
        public double ElectricalCabinetTemperature { get; set; }

        /// <summary>
        /// Gets or sets the solder feeder control data.
        /// </summary>
        public SolderFeederControl FeederControl { get; set; }

        /// <summary>
        /// Number of boards in buffer.
        /// </summary>
        public int BoardsInBuffer { get; set; }

        /// <summary>
        /// Operation mode of the wave soldering machine.
        /// </summary>
        public String OperationMode { get; set; }

        public N2 N2 { get; set; }

        /// <summary>
        /// Gets or sets the unit process data.
        /// </summary>
        public WaveUnitProcessData UnitProcessData { get; set; }
    }
}