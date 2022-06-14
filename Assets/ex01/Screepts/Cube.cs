using UnityEngine;

public class Cube : MonoBehaviour
{ 
    public float fallSpeed = 1f;
    public KeyCode button;
    //private float start;
    private float end;

    // Start is called before the first frame update
    void Start()
    {
        fallSpeed = Random.Range(0.09f, 0.12f);
        //start = transform.position.y;
        end = -3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < end)
        {
            Destroy(gameObject);
        }
        this.transform.Translate(0f, -fallSpeed, 0f);
        if (Input.GetKeyDown(button))
        {
            Debug.Log("Precision: " + (end - transform.position.y));
            Destroy(gameObject);
        }
    }
}
