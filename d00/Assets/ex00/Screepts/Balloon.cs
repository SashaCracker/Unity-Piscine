using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int breath_time;
    public int stop;
    protected bool game_over;
    protected int i = 0;
    protected int breath;


    // Start is called before the first frame update
    void Start()
    {
        breath = breath_time;
    }

    // Update is called once per frame
    void Update()
    {
        if (game_over)
            return;
        if (transform.localScale.x < 5.0f && transform.localScale.x > 0.1f)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (breath != 0)
                {
                    breath--;
                    transform.localScale += new Vector3(0.5f, 0.5f);
                }
                if (breath == 0)
                {
                    ++i;
                    if (i == stop)
                    {
                        breath = breath_time;
                        i = 0;
                    }
                }   
            }
            transform.localScale -= new Vector3(0.01f, 0.01f);
        }
        if (transform.localScale.x >= 5.0f && !game_over)
        {
            game_over = true;
            Debug.Log("Balloon POPPED after " + Mathf.RoundToInt(Time.timeSinceLevelLoad) + "s");
            Debug.Log("Game OVER!");
            Destroy(gameObject);
        }
        if (transform.localScale.x <= 0.1f && !game_over)
        {
            game_over = true;
            Debug.Log("Balloon is DEFLATED after " + Mathf.RoundToInt(Time.timeSinceLevelLoad) + "s");
            Debug.Log("Game OVER!");
            Destroy(gameObject);
        }
    }
}
