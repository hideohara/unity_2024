using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject obj;
    private int gameTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        gameTime++;
        int max;
        max = 100 - gameTime / 10;
        if (max < 50) max = 50;
        int r = Random.Range(0, max);
        if (r == 0)
        {
            float x = Random.Range(-3.0f, 3.0f);
            Instantiate(obj, new Vector3(x, 0.0f, 15), Quaternion.identity);
        }
    }
}
