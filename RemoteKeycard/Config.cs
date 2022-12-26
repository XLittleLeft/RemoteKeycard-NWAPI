﻿using System.ComponentModel;

namespace RemoteKeycard
{
    public class Config
    {
        /// <inheritdoc/>
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Whether Amnesia affects the usage of keycards.
        /// </summary>
        [Description("Whether  Amnesia affects the usage of keycards.")]
        public bool AmnesiaMatters { get; set; } = true;

        /// <summary>
        /// Whether this plugin works on generators.
        /// </summary>
        [Description("Whether this plugin works on generators.")]
        public bool AffectGenerators { get; set; } = true;

        /// <summary>
        /// Whether this plugin works on Warhead's panel.
        /// </summary>
        [Description("Whether this plugin works on Warhead's panel.")]
        public bool AffectWarheadPanel { get; set; } = true;

        /// <summary>
        /// Whether this plugin works on SCP lockers.
        /// </summary>
        [Description("Whether this plugin works on SCP lockers.")]
        public bool AffectScpLockers { get; set; } = true;

        /// <summary>
        /// Whether this plugin works on doors.
        /// </summary>
        [Description("Whether this plugin works on doors.")]
        public bool AffectDoors { get; set; } = true;

    }
}