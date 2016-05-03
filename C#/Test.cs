using System;
using NUnit.Framework;
namespace MyGame
{   
	[TestFixture ()]
	public class Test
	{
		[Test ()]
			public void TestNoShip ()
			{
				BattleShipsGame Game = new BattleShipsGame ();
				Player Player = new Player (Game);

				AttackResult result = Player.PlayerGrid.HitTile (1, 1);
				Assert.AreEqual ("missed", result.Text, "should return miss becuase there is no ship at that cordinates");
			}

		[Test ()]
		public void TestHitShip ()
		{
			BattleShipsGame Game = new BattleShipsGame ();
			Player Player = new Player (Game);

			Player.PlayerGrid.MoveShip (1, 1, ShipName.Submarine, Direction.UpDown);

			AttackResult result = Player.PlayerGrid.HitTile (1, 1);
			Assert.AreEqual ("hit something!", result.Text, "should hit the shit because the subarmine is in the cordinates");
		}

	}
}

