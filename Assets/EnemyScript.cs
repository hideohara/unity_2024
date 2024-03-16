using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private float xSpeed=0;

    private GameObject gameManager; // オブジェクトが入る変数
    private GameManagerScript gameManagerScript; // Scriptが入る変数

    // Start is called before the first frame update
    void Start()
    {
        // ゲームマネージャーのスクリプトを探す
        gameManager = GameObject.Find("GameManager"); // オブジェクトの名前から探す
        gameManagerScript = gameManager.GetComponent<GameManagerScript>(); // Scriptを取得する

        // 乱数で左右へ
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
    }

    // Update is called once per frame
    void Update()
    {
        // ゲームオーバー
        if (gameManagerScript.GetGameOverFlag() == true)
        {
            return;
        }

        // 移動
        transform.position += new Vector3(xSpeed, 0, -0.1f);

        // 左右で反転
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

        // 手前で消滅
        if (transform.position.z < -2)
        {
            Destroy(this.gameObject);
        }
    }
}
