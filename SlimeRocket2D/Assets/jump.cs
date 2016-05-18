using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class jump : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    private bool isPressed = false;


    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {


    }
    public bool buttonPressed()
    {
        return isPressed;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}
