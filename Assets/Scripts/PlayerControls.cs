using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {
	public KeyCode up, down;
	public float speed = 10f;

	void Update() {
		int mult = 0;
		if(Input.GetKey(up)) {
			mult += 1;
		}
		if(Input.GetKey(down)) {
			mult -= 1;
		}
		GetComponent<Rigidbody2D>().velocity = new Vector2(0, mult * speed);
	}
}
