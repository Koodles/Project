using NUnit.Framework;
using System;

namespace Application
{
	[TestFixture ()]
	public class AITest
	{
		/// <summary>
		/// This tests if the easy AI can hit ships by placing a ship down and attacking it. This tests that all of the important 
		/// architecture in the easy AI exists.
		/// </summary>
		[Test ()]
		public void TestEasyAICanAttackShips ()
		{
			BattleShipsGame testgame = new BattleShipsGame ();
			AIEasyPlayer AI_test = new AIEasyPlayer (testgame);
			Player testplayer = new Player (testgame); 
			AI_test.PlayerGrid.MoveShip (0, 0, ShipName.Submarine, Direction.UpDown);
			AttackResult result = AI_test.PlayerGrid.HitTile (0, 0);
			Assert.AreEqual ("hit something!", result.Text, "should hit the ship because the subarmine is in the cordinates");


		}
	}
}

