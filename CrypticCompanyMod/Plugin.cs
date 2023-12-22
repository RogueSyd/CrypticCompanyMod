using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrypticCompanyMod
{   
    [BepInPlugin(modGUID, modName, modVersion)]
    public class CrypticCompanyModBase : BaseUnityPlugin
    {
        private const string modGUID = "com.crypticcompany.mod";
        private const string modName = "CrypticCompanyMod";
        private const string modVersion = "1.0.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static CrypticCompanyModBase Instance;

        internal ManualLogSource mls;
        void Awake()
        {
            if ( Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("CrypticCompanyMod loaded!");

            harmony.PatchAll(typeof(CrypticCompanyModBase));


            //Console.WriteLine("CrypticCompanyMod loaded!");
        }
    }
}
