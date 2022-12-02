using System;
using PulsarModLoader;

namespace AreWeAligned
{
	// Token: 0x02000002 RID: 2
	public class Mod : PulsarMod
	{
		public override string Version
		{
			get
			{
				return "0.0.3";
			}
		}

		public override string Author
		{
			get
			{
				return "pngun & Rayman";
			}
		}

		public override string Name
		{
			get
			{
				return "AreWeAligned";
			}
		}

		public override string HarmonyIdentifier()
		{
			return "pngun.AreWeAligned";
		}

		public override string LongDescription
		{
			get
			{
				return "";
			}
		}

		public override string ShortDescription
		{
			get
			{
				return "Shows on Jump Computer if the Ship is Aligned";
			}
		}
	}
}
