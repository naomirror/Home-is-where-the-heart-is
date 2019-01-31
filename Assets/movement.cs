using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	// Use this for initialization
	public GameObject home;
	public GameObject heart;
	public GameObject heartbox;
	public GameObject red;
	public GameObject orange;
	public GameObject yellow;
	public GameObject green;
	public GameObject blue;
	public GameObject purple;
	public GameObject pizza;
	public GameObject cat;
	public GameObject love;
	public GameObject nswitch;
	public GameObject bed;

	SpriteRenderer sr;
	int count;
	void Start () {
		heart.SetActive (false);
		heartbox.SetActive (false);
		red.SetActive (false);
		orange.SetActive (false);
		green.SetActive (false);
		blue.SetActive (false);
		purple.SetActive (false);
		sr = home.GetComponent<SpriteRenderer> ();
		count = 0;
	}
	float speed = 0.2f;	
	// Update is called once per frame
	void Update () {
		red.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y + 3, this.transform.position.z);
		orange.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y + 2, this.transform.position.z);
		yellow.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y + 1, this.transform.position.z);
		green.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z);
		blue.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y -1, this.transform.position.z);
		purple.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y -2, this.transform.position.z);
		if (Input.GetKey("up")) {
			transform.Translate(0.0f,speed,0.0f);
		}
		if (Input.GetKey("down")) {
		    transform.Translate(0.0f,-speed,0.0f);
			}
		if (Input.GetKey("left")) {
			transform.Translate(-speed,0.0f,0.0f);
			}
		if (Input.GetKey("right")) {
			transform.Translate(speed,0.0f,0.0f);
			}
		if (Input.GetKey ("w") && speed <= 0.4f) {
			speed += 0.01f;
		}
		if (Input.GetKey ("s") && speed >= 0.0f) {
			speed -= 0.01f;
		}
		if (count == 5) {
			home.SetActive (false);
			heart.SetActive (true);
			heartbox.SetActive (true);
			bed.transform.position = new Vector3 (-4.3f,3.4f,0.0f);
			nswitch.transform.position = new Vector3 (-3.6f,6.1f,0.0f);
			pizza.transform.position = new Vector3 (1.4f,3.1f,0.0f);
			love.transform.position = new Vector3 (0.6f,-2.6f,0.0f);
			cat.transform.position = new Vector3 (5.3f,4.6f,0.0f);
		}
	}
	void OnCollisionEnter2D(Collision2D col){
		//Debug.Log ("triggered");
		if (col.gameObject.name == "pizza" && col.gameObject.transform.position != new Vector3 (6.2f, -10.9f, 0.0f)) {
			col.gameObject.transform.position = new Vector3 (6.2f, -10.9f, 0.0f);
			red.SetActive (true);
			count += 1;
		}
		if (col.gameObject.name == "cat" && col.gameObject.transform.position != new Vector3 (10.9f, -9.5f, 0.0f)) {
			col.gameObject.transform.position = new Vector3 (10.9f, -9.5f, 0.0f);
			Destroy (col.gameObject.GetComponent<catMovement> ());
			orange.SetActive (true);
			count +=1;
		}
		if (col.gameObject.name == "bed" && col.gameObject.transform.position != new Vector3 (-9.4f, -8.8f, 0.0f)) {
			col.gameObject.transform.position = new Vector3 (-9.4f, -8.8f, 0.0f);
			green.SetActive (true);
			count +=1;
		}
		if (col.gameObject.name == "switch" && col.gameObject.transform.position != new Vector3 (-8.3f, -6.9f, 0.0f)) {
			col.gameObject.transform.position = new Vector3 (-8.3f, -6.9f, 0.0f);
			blue.SetActive (true);
			count += 1;
		}
		if (col.gameObject.name == "love" && col.gameObject.transform.position != new Vector3 (0.4f, -9.5f, 0.0f)) {
			col.gameObject.transform.position = new Vector3 (0.4f, -9.5f, 0.0f);
			purple.SetActive (true);
			count += 1;
		}
	}

}
