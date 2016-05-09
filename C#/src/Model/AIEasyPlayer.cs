using System;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using SwinGameSDK;
/// <summary>
/// AI easy player is a player that will shoot randomally around the map, hoping to hit anything. Unlike the two other difficulties,
/// this will not target a ship after it has hit it.
/// </summary>
public class AIEasyPlayer: AIPlayer
{
	public AIEasyPlayer (BattleShipsGame controller) : base(controller)
	{
	}
	private void SearchCoords(ref int row, ref int column)
	{
		row = _Random.Next(0, EnemyGrid.Height);
		column = _Random.Next(0, EnemyGrid.Width);
	}

	protected override void GenerateCoords(ref int row, ref int column)
	{
		do {
			SearchCoords(ref row, ref column);
		} while ((row < 0 || column < 0 || row >= EnemyGrid.Height || column >= EnemyGrid.Width || EnemyGrid[row, column] != TileView.Sea));
	}
	protected override void ProcessShot(int row, int col, AttackResult result)
	{

	}
}


