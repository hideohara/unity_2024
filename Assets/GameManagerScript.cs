using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public GameObject enemy;
    private int gameTime = 0;
    static public int gameScore = 0;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        gameTime++;
        int max;
        max = 100 - gameTime / 100;
        if (max < 20) max = 20;
        int r = Random.Range(0, max);
        if (r == 0)
        {
            float x = Random.Range(-3.0f, 3.0f);
            Instantiate(enemy, new Vector3(x, 0.0f, 15), Quaternion.identity);
        }

        scoreText.text = "SCORE " + gameScore;
    }

    //public void AddScore()
    //{
    //    gameScore++;
    //}
}
