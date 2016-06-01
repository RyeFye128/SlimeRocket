using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {

    public int id;
    public void loadScene(int id)
    {
        switch (id)
        {
            case 1:
                //load the game
                SceneManager.LoadScene(1);
                Debug.Log("Pressed");
                break;
        }
    }
}
