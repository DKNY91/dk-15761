using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour {
	public Camera mainCamera;
	public BoxCollider2D topWall, bottomWall, leftWall, rightWall;
	public Transform player1, player2;

	void Start() {
		float width = Screen.width;
		float doubleWidth = width * 2f;
		float height = Screen.height;
		float doubleHeight = height * 2f;

		topWall.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(doubleWidth, 0f, 0f)).x, 1f);
		topWall.offset = new Vector2(0f, mainCamera.ScreenToWorldPoint(new Vector3(0f, height, 0f)).y + 0.5f);
		
		bottomWall.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(doubleWidth, 0f, 0f)).x, 1f);
		bottomWall.offset = new Vector2(0f, mainCamera.ScreenToWorldPoint(Vector3.zero).y - 0.5f);
		
		leftWall.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, doubleHeight, 0f)).y);
		leftWall.offset = new Vector2(mainCamera.ScreenToWorldPoint(Vector3.zero).x - 0.5f, 0f);
		
		rightWall.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, doubleHeight, 0f)).y);
		rightWall.offset = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(width, 0f, 0f)).x + 0.5f, 0f);

		player1.position = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(75f, 0f, 0f)).x, 0f);
		player2.position = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(width - 75f, 0f, 0f)).x, 0f);
	}
}
