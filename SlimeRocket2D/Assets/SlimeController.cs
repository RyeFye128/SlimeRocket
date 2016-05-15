using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SlimeController : MonoBehaviour {

	public float speed = .05f;
	private SpriteRenderer sp;//lets me flip the sprite
	private Rigidbody2D slime;
	public float jumpPower = 100f;
	public int jumps = 5;
	public int health = 10;
	public Text scoreText;
	private int score = 0;

	// Use this for initialization
	void Start () {

		sp = GetComponent<SpriteRenderer> ();
		slime = GetComponent<Rigidbody2D> ();
		//scoreText = GetComponent<Text> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	


		if (Input.GetKey(KeyCode.LeftArrow)) {

			transform.position += Vector3.left * speed * Time.deltaTime;
			sp.flipX = false;
		}

		if (Input.GetKey(KeyCode.RightArrow)) {

			transform.position += Vector3.right * speed * Time.deltaTime;
			sp.flipX = true;//flip the sprite
		}

		if ((Input.GetKeyDown(KeyCode.Space) 
			|| (Input.touchCount >0  && Input.GetTouch(0).phase == TouchPhase.Began ))
			&& (jumps > 0)) {

			slime.AddForce (transform.up * jumpPower);
			jumps--; //decrement the jumps
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.collider.gameObject.layer == LayerMask.NameToLayer ("Ground")) {

			jumps = 5;
		}
		if (col.collider.gameObject.layer == LayerMask.NameToLayer("points")) {
			score++;
			scoreText.text = score.ToString();
		}
	}
}
