using UnityEngine;
using System.Collections;

public class batController : MonoBehaviour {

    // Use this for initialization
    public float speed;
    private int direction = 1; //-1 = left, 1 = right
    private Rigidbody2D bat;
   


    void Start () {
        bat = GetComponent<Rigidbody2D>();

     

    }

    // Update is called once per frame
    void Update () {

        transform.position += direction * (Vector3.left * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.gameObject.layer == LayerMask.NameToLayer("Sides")) {
            Debug.Log("Collided");
            if (direction == -1)
            {
                direction = 1;
                bat.GetComponent<SpriteRenderer>().flipX = false;
            }
            else 
            {
                direction = -1;
                bat.GetComponent<SpriteRenderer>().flipX = true;
            }

        }
    }

    void setSpeed(float sp)
    {
        speed = sp;
    }

}