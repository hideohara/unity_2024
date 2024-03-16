using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        int r = Random.Range(0, 100);
        if (r == 0)
        {
            float x = Random.Range(-3.0f, 3.0f);
            Instantiate(obj, new Vector3(x, 0.0f, 15), Quaternion.identity);
        }
    }
}
