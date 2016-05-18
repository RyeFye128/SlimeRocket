using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SlimeController : MonoBehaviour {

	public float speed = .05f;
	private Rigidbody2D slime;
	public float jumpPower = 100f;
	public int jumps = 5;
	public int health = 10;
	public Text scoreText;
	public int score = 0;
    public Text hpNum;
    private Animator anim;
    public bool leftPressed = false;
    public bool rightPressed = false;

    public Button left;
    public Button right;
    public Button space;

	// Use this for initialization
	void Start () {

		slime = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animator>();
        left = GetComponent <SlimeController>().left;
        right = GetComponent<SlimeController>().right;
        space = GetComponent<SlimeController>().space;
		//scoreText = GetComponent<Text> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
       
        if (score >= 20)//load level 2
        {
            SceneManager.LoadScene("level2");

        }

        if ((Input.GetKey(KeyCode.LeftArrow)) ||(left.GetComponent<moveLeft>().buttonPressed()))  {

			transform.position += Vector3.left * speed * Time.deltaTime;
			//sp.flipX = false;
            anim.SetBool("goingRight", false);

		}

        if ((Input.GetKey(KeyCode.RightArrow)) ||(right.GetComponent<moveRight>().buttonPressed())){

			transform.position += Vector3.right * speed * Time.deltaTime;
			//sp.flipX = true;//flip the sprite
            anim.SetBool("goingRight", true);
		}

        if ((Input.GetKeyDown(KeyCode.Space)) 
			&& (jumps > 0)) {

			slime.AddForce (transform.up * jumpPower);
			jumps--; //decrement the jumps
            anim.SetBool("in air", true);
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
        if (col.collider.gameObject.layer == LayerMask.NameToLayer("enemy")) {
            //if hit, lower the score. if less than 20, set to 0.
            if (score >= 3)
            {
                score -= 3;
            }
            else
            {
                score = 0;
            }

            health--;
            scoreText.text = score.ToString();//set the scoreboard
        }
		if (col.collider.gameObject.layer == LayerMask.NameToLayer ("Ground")) {

			jumps = 5;
            anim.SetBool("in air", false);
		}
		if (col.collider.gameObject.layer == LayerMask.NameToLayer("points")) {
			score++;
			scoreText.text = score.ToString();
		}

        hpNum.text = health.ToString();
	}
        
    public void onClickJump()
    {
        if (jumps > 0)
        {
            slime.AddForce (transform.up * jumpPower);
            jumps--; //decrement the jumps
            anim.SetBool("in air", true);
        }
    }
}
