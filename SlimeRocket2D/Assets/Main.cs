using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
    public int levelNum = 1;
    private GameObject[] bats;
    public GameObject batPrefab;

 
	// Use this for initialization
	void Start () {
       

       
        switch (levelNum)
        {
            case 1://level one
                GameObject bat1 = (GameObject)Instantiate(batPrefab);
                bat1.transform.position = new Vector3(0, 2, 0);
                bat1.GetComponent<batController>().speed = 5.0f;
                break;
      







        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
