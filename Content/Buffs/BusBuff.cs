using Terraria;
using Terraria.ModLoader;
using BusStopMount.Content.Mounts;

namespace BusStopMount.Content.Buffs
{
	public class BusBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.mount.SetMount(ModContent.MountType<BusStop>(), player);
			player.buffTime[buffIndex] = 10;
		}
	}
}