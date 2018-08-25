using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public GUIText player1ScoreLabel, player2ScoreLabel;
	private static int player1Score, player2Score;

	public static void WallHit(bool leftWall) {
		if(leftWall) {
			player2Score++;
		} else {
			player1Score++;
		}
	}

	void OnGUI() {
		player1ScoreLabel.text = "<b>Player 1 Score:</b> " + player1Score;
		player2ScoreLabel.text = "<b>Player 2 Score:</b> " + player2Score;
	}
}
