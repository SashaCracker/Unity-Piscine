using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private playerScript_ex00 player1;
    [SerializeField] private playerScript_ex00 player2;
    [SerializeField] private playerScript_ex00 player3;

    // Start is called before the first frame update
    void Start()
    {
        player1.activation = true;
        player2.activation = false;
        player3.activation = false;

    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            player1.activation = true;
            player2.activation = false;
            player3.activation = false;

        }
        if (Input.GetKeyDown("2"))
        {
            player1.activation = false;
            player2.activation = true;
            player3.activation = false;
        }
        if (Input.GetKeyDown("3"))
        {
            player1.activation = false;
            player2.activation = false;
            player3.activation = true;
        }
        if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.Backspace))
        {
            Application.LoadLevel("ex00");
        }
    }
}
