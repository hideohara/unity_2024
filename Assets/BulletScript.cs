using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BulletScript : MonoBehaviour
{
    private GameObject gameManager; // GameObjectそのものが入る変数
    private GameManagerScript gameManagerScript; // Scriptが入る変数

    // Start is called before the first frame update
    void Start()
    {
        // ゲームマネージャーのスクリプトを探す
        gameManager = GameObject.Find("GameManager"); // オブジェクトの名前から探す
        gameManagerScript = gameManager.GetComponent<GameManagerScript>(); // Scriptを取得する
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, 0.2f);

        if (transform.position.z > 30)
        {
            Destroy(this.gameObject);
        }


    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //Debug.Log("Hit"); // ログを表示する
            Destroy(this.gameObject);
            Destroy(other.gameObject);

            gameManagerScript.AddScore();

        }
    }
}
