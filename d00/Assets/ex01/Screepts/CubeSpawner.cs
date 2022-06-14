using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cube0;
    public GameObject cube1;
    public GameObject cube2;
    private int i = 0;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (i >= 50)
        {
            switch (Random.Range(0, 3))
            {
                case 0:
                    Instantiate(cube0, new Vector3(-3, 6), Quaternion.identity);
                    break;
                case 1:
                    Instantiate(cube1, new Vector3(0, 6), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(cube2, new Vector3(3, 6), Quaternion.identity);
                    break;
            }
            i = 0;
        }
        i++;
    }
}
