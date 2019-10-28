﻿using Common;
using HarmonyLib;
using System;

namespace IllusionFixes
{
    public partial class SettingsVerifier
    {
        internal static partial class Hooks
        {
            /// <summary>
            /// Run the code for reading setup.xml when inside studio. Done in a Manager.Config.Start hook because the xmlRead method needs stuff to be initialized first.
            /// </summary>
            [HarmonyPostfix, HarmonyPatch(typeof(Manager.Config), "Start")]
            internal static void ManagerConfigStart()
            {
                if (bl_AllOptionsPro.LoadAndApply)
                {
                    var xmlr = typeof(InitScene).GetMethod("xmlRead", AccessTools.all);
                    if (xmlr == null) throw new ArgumentException("Could not find InitScene.xmlRead");
                    var initScene = _instance.gameObject.AddComponent<InitScene>();
                    xmlr.Invoke(initScene, null);
                    DestroyImmediate(initScene);
                }
            }
        }
    }
}
