﻿using BepInEx;
using Common;

namespace IllusionFixes
{
    [BepInProcess(Constants.GameProcessName)]
    [BepInProcess(Constants.StudioProcessName)]
    [BepInPlugin(GUID, PluginName, Metadata.PluginsVersion)]
    public partial class ManifestCorrector : BaseUnityPlugin
    {
        public const string GUID = "AI_Fix_ManifestCorrector";
    }
}