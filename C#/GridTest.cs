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
				BattleShipsGame testGame = new BattleShipsGame ();
				Player Player = new Player (testGame);

				AttackResult result = Player.PlayerGrid.HitTile (7, 7);
				Assert.AreEqual ("missed", result.Text, "should return miss becuase there is no ship at that cordinates");
			}

		[Test ()]
		public void TestHitShip ()
		{
			BattleShipsGame testGame = new BattleShipsGame ();
			Player Player = new Player (testGame);

			Player.PlayerGrid.MoveShip (2, 2, ShipName.Submarine, Direction.UpDown);

			AttackResult result = Player.PlayerGrid.HitTile (2, 2);
			Assert.AreEqual ("hit something!", result.Text, "should hit the ship because the subarmine is in the cordinates");
		}

		[Test]
		public void TestHitTileDestroyShip ()
		{
			BattleShipsGame testGame2 = new BattleShipsGame ();
			Player testPlayer2 = new Player (testGame2);

			testPlayer2.PlayerGrid.MoveShip (0, 0, ShipName.Submarine, Direction.UpDown);

			AttackResult actual = testPlayer2.PlayerGrid.HitTile (0, 0);
			AttackResult actual2 = testPlayer2.PlayerGrid.HitTile (1, 0);
			Assert.AreEqual ("hit something!", actual.Text, "should hit the ship the destroyer at 0 , 0");
			Assert.AreEqual ("destroyed the enemy's", actual2.Text, "should hit the ship the submarine at 0 , 1 and destroy it");

		}
		//Test when attacking in the same cordinate twice
		[Test]
		public void AttacktwiceInSameCell ()
		{
			BattleShipsGame testGame3 = new BattleShipsGame ();
			Player testPlayer3 = new Player (testGame3);

			testPlayer3.PlayerGrid.MoveShip (0, 0, ShipName.Submarine, Direction.UpDown);

			AttackResult actual = testPlayer3.PlayerGrid.HitTile (0, 0);
			AttackResult actual2 = testPlayer3.PlayerGrid.HitTile (0, 0);
			Assert.AreEqual ("hit something!", actual.Text, "should hit the ship the destroyer at 0 , 0");
			Assert.AreEqual ("have already attacked [0,0]!", actual2.Text, "Retuen have already attack cordinate 0,0");

		}
		//Test throw Exception when ship is out of board
		[Test]
		public void TestShipOutsideOfBoard ()
		{
			BattleShipsGame testGame4 = new BattleShipsGame ();
			Player testPlayer4 = new Player (testGame4);
			Assert.Throws(typeof(System.ApplicationException),
				delegate() { testPlayer4.PlayerGrid.MoveShip (7, 7, ShipName.AircraftCarrier, Direction.UpDown); });

		}
	}
}

