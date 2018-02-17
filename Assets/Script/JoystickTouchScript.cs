using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityStandardAssets.CrossPlatformInput;

public class JoystickTouchScript : MonoBehaviour {

	public float speed;

	void Update () {
		float moveX = Input.GetAxisRaw ("Horizontal") * speed * Time.deltaTime;
		float moveY = Input.GetAxisRaw ("Vertical") * speed * Time.deltaTime;

		transform.Translate (moveX, moveY, 0.0f);
	}
}
