using BusStopMount.Content.Mounts;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BusStopMount.Content.Items
{
	public class BusSign : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 30;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing; 
			Item.value = Item.sellPrice(silver: 90);
			Item.rare = ItemRarityID.Green;
			Item.noMelee = true; 
			Item.mountType = ModContent.MountType<BusStop>();
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.HallowedBar, 5)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}