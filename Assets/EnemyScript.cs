using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private float xSpeed=0;
    // Start is called before the first frame update
    void Start()
    {
        int r = Random.Range(0, 2);
        if (r==0)
        {
            xSpeed = 0.05f;
            transform.rotation = Quaternion.Euler(0, 180-20, 0);
        }
        else
        {
            xSpeed = -0.05f;
            transform.rotation = Quaternion.Euler(0, 180+20, 0);
        }

//        transform.rotation = Quaternion.Euler(0, 180, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManagerScript.gameOverFlag == true)
        {
            return;
        }

        transform.position += new Vector3(xSpeed, 0, -0.1f);

        if (transform.position.x>4)
        {
            xSpeed = -0.05f;
            transform.rotation = Quaternion.Euler(0, 180 + 20, 0);
        }
        if (transform.position.x < -4)
        {
            xSpeed = 0.05f;
            transform.rotation = Quaternion.Euler(0, 180 - 20, 0);
        }

        if (transform.position.z < -2)
        {
            Destroy(this.gameObject);
        }
    }
}
