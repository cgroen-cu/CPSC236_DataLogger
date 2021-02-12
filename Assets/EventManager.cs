using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    public Text textHeader;

    GameManagerScript GameManagerClass = new GameManagerScript();

    public void MessageConsole()
    {
        //Debug.Log("You clicked me!");
        textHeader.text = "You Clicked me!";
        GameManagerClass.WriteButtonInput();
    }
}
