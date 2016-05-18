using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class countJumps : MonoBehaviour {

    public GameObject player;
    public Text jumpNum;
	// Use this for initialization
	void Start () {
        jumpNum.text = "asdasda";
	}
	
	// Update is called once per frame
	void Update () {
	
       jumpNum.text =  (player.GetComponent<SlimeController>().jumps).ToString();
        jumpNum.text = "Jump ( " + jumpNum.text + " )";
        //GetComponent<Text>().text = "";
	}
}
