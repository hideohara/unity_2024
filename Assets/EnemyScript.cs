using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private float xSpeed=0;

    private GameObject player; // Unityちゃんそのものが入る変数
    private PlayerScript playerScript; // UnityChanScriptが入る変数


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        playerScript = player.GetComponent<PlayerScript>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する

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
        if (playerScript.GetGameOverFlag() == true)
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
