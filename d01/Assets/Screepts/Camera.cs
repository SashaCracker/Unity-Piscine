using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private playerScript_ex00 player1;
    [SerializeField] private playerScript_ex00 player2;
    [SerializeField] private playerScript_ex00 player3;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 target = new Vector3(player1.transform.position.x, player1.transform.position.y, player1.transform.position.z - 10);
        Vector3 pos = Vector3.Lerp(this.transform.position, target, speed * Time.deltaTime);
        this.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        if (player1.activation == true)
        {
            Vector3 target = new Vector3(player1.transform.position.x, player1.transform.position.y, player1.transform.position.z - 10);
            Vector3 pos = Vector3.Lerp(this.transform.position, target, speed * Time.deltaTime);
            this.transform.position = pos;

        }
        if (player2.activation == true)
        {
            Vector3 target = new Vector3(player2.transform.position.x, player2.transform.position.y, player2.transform.position.z - 10);
            Vector3 pos = Vector3.Lerp(this.transform.position, target, speed * Time.deltaTime);
            this.transform.position = pos;
        }
        if (player3.activation == true)
        {
            Vector3 target = new Vector3(player3.transform.position.x, player3.transform.position.y, player3.transform.position.z - 10);
            Vector3 pos = Vector3.Lerp(this.transform.position, target, speed * Time.deltaTime);
            this.transform.position = pos;
        }
    }
}
