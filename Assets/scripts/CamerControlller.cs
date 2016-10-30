using UnityEngine;
using System.Collections;

public class CamerControlller : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	}

	// late update guaranteed to run at end of frame so camera is not updated until player is done updating
	void LateUpdate() {
		transform.position = player.transform.position + offset;
	}
}
