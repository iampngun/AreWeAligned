using HarmonyLib;
using UnityEngine;

namespace AreWeAligned
{
	[HarmonyPatch(typeof(PLWarpDriveScreen), "Update")]
	internal class PLWarpScreenPatch
	{
        public static void Postfix(PLWarpDriveScreen __instance, UILabel ___m_JumpButtonLabel, UILabel ___m_JumpButtonLabelTop)
        {
            if (__instance == null || PLStarmap.Instance == null || PLStarmap.Instance.CurrentShipPath == null || ___m_JumpButtonLabel == null || ___m_JumpButtonLabelTop == null)
            {
                return;
            }
            if (__instance.MyScreenHubBase.OptionalShipInfo.WarpChargeStage == EWarpChargeStage.E_WCS_READY)
            {
                if (PLStarmap.Instance.CurrentShipPath.Count > 1 
                    && __instance.MyScreenHubBase.OptionalShipInfo.WarpTargetID == 
                    PLStarmap.Instance.CurrentShipPath[1].ID) {

                    if (___m_JumpButtonLabel.text[0] != '◯')
                        ___m_JumpButtonLabel.text = "◯ " + ___m_JumpButtonLabel.text;
                }
                else 
                {
                    if (___m_JumpButtonLabel.text[0] == '◯')
                        ___m_JumpButtonLabel.text = ___m_JumpButtonLabel.text.Substring(2);
                }

                ___m_JumpButtonLabelTop.text = ___m_JumpButtonLabel.text;
            }
        }
    }
}
