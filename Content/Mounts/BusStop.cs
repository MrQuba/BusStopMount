using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace BusStopMount.Content.Mounts
{
	public class BusStop : ModMount
	{

		public override void SetStaticDefaults()
		{
			MountData.jumpHeight = 25;
			MountData.acceleration = 0.25f;
			MountData.jumpSpeed = 4f;
			MountData.blockExtraJumps = false; 
			MountData.constantJump = true;
			MountData.heightBoost = 20;
			MountData.fallDamage = 0f;
			MountData.runSpeed = 16f;
			MountData.dashSpeed = 8f;
			MountData.flightTimeMax = 0;

			MountData.fatigueMax = 0;
			MountData.buff = ModContent.BuffType<Buffs.BusBuff>();

			MountData.totalFrames = 1;
			MountData.playerYOffsets = Enumerable.Repeat(20, MountData.totalFrames).ToArray();
			MountData.xOffset = 13;
			MountData.yOffset = -12;
			MountData.playerHeadOffset = 22;
			MountData.bodyFrame = 3;
			// Standing
			MountData.standingFrameCount = 1;
			MountData.standingFrameDelay = 12;
			MountData.standingFrameStart = 0;
			// Running
			MountData.runningFrameCount = 1;
			MountData.runningFrameDelay = 12;
			MountData.runningFrameStart = 0;
			// Flying
			MountData.flyingFrameCount = 0;
			MountData.flyingFrameDelay = 0;
			MountData.flyingFrameStart = 0;
			// In-air
			MountData.inAirFrameCount = 1;
			MountData.inAirFrameDelay = 12;
			MountData.inAirFrameStart = 0;
			// Idle
			MountData.idleFrameCount = 1;
			MountData.idleFrameDelay = 12;
			MountData.idleFrameStart = 0;
			MountData.idleFrameLoop = true;
			// Swim
			MountData.swimFrameCount = MountData.inAirFrameCount;
			MountData.swimFrameDelay = MountData.inAirFrameDelay;
			MountData.swimFrameStart = MountData.inAirFrameStart;

			if (!Main.dedServ)
			{
				MountData.textureWidth = MountData.backTexture.Width() + 20;
				MountData.textureHeight = MountData.backTexture.Height();
			}
		}

	}
}