using UnityEngine;
using System.Collections;

public class TextOnScreen : MonoBehaviour
{

    public GUIText TotemDestroyed;
    public GUIText WinScreen;
    public int totemScore;
    public GameObject Totem1;
    public GameObject Totem2;
    public GameObject Totem3;

    public string text { get; private set; }

    void Start()
    {
        totemScore = 0;
    }

    void Update()
    {
        UpdateScore();

        if (Totem1 == null)
        {
            totemScore = 1;
        }

        if(Totem2 == null)
        {
            totemScore = 2;
        }

        if(Totem3 == null)
        {
            totemScore = 3;
        }

        if (totemScore == 3)
        {
            WinScreen.text = "You Win!!";
            Debug.Log("you win");
        }
    }

    void UpdateScore()
    {
        TotemDestroyed.text = "Totem's Destroyed: " + totemScore;
    }
}

