using UnityEngine;
using System.Collections;

public class SideWallCollisions : MonoBehaviour {
	public bool isLeftWall;

	void OnTriggerEnter2D(Collider2D collider) {
		if(collider.name == "Ball") {
			GameManager.WallHit(isLeftWall);
		}
	}
}
