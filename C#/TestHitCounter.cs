using NUnit.Framework;
using System;

namespace MyGame
{
	[TestFixture ()]
	public class TestHitCounter
	{
		[Test ()]
		public void TestMiss ()
		{
			BattleShipsGame testGame = new BattleShipsGame ();
			Player Player = new Player (testGame);

			Player.PlayerGrid.MoveShip (0,0, ShipName.Tug, Direction.UpDown);

			AttackResult result = Player.PlayerGrid.HitTile (1, 1);
			Assert.AreEqual ("missed", result.Text, "Should miss the Tug by one square");
		}

		[Test ()]
		public void TestHitCount ()
		{
	
		}
	}
}

