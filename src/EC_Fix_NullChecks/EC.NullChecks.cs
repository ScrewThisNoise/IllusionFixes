﻿using BepInEx;
using Common;

namespace IllusionFixes
{
    [BepInProcess(Constants.GameProcessName)]
    [BepInPlugin(GUID, PluginName, Metadata.PluginsVersion)]
    public partial class NullChecks : BaseUnityPlugin
    {
        public const string GUID = "EC_Fix_NullChecks";
    }
}
