using UnityEngine;
using System.Collections;

public class boxController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.gameObject.layer == LayerMask.NameToLayer("player"))
        {
            //generate a random x coordinate within the bounds -4.5 to 6.0
            float temp = Random.Range(-4.5f, 6.0f);
            transform.position = new Vector3(temp, 4, 0);
        }
    }
}
