using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;
	private int count;
	private Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText();
		winText.text = "";
	}
	void Update() {} //applied before any frame is rendered


	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(movement * speed);
	} // applied before any physics update

	void OnTriggerEnter(Collider other) {
		print(other.tag);
		if (other.gameObject.CompareTag("Pickup")) {
			other.gameObject.SetActive(false);
			count += 1;
			SetCountText();
			if (count >= 7) {
				winText.text = "You won!!!";
			}
		}
	}

	void SetCountText() {
		countText.text = "Count:" + count.ToString();
	}
}
