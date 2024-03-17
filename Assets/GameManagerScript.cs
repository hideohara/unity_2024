using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject enemy;

    public TextMeshProUGUI scoreText;
    public GameObject gameOverText;
    public GameObject enterText;
    public AudioSource hitAudioSource;
    public AudioSource gameOverAudioSource;
    public GameObject particle;

    private int gameTime = 0;
    private int gameScore = 0;
    private bool gameOverFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);
       
        Application.targetFrameRate = 60;

    }

    // Update is called once per frame
    void Update()
    {
        if (gameOverFlag == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("TitleScene");
            }

            return;
        }

        gameTime++;
        int max;
        max = 50 - gameTime / 100;
        //if (max < 20) max = 20;
        int r = Random.Range(0, max);
        if (r == 0)
        {
            float x = Random.Range(-3.0f, 3.0f);
            Instantiate(enemy, new Vector3(x, 0.0f, 15), Quaternion.identity);
        }

        scoreText.text = "SCORE " + gameScore;


    }

    public void Hit(Vector3 position)
    {
        gameScore += 1;
        hitAudioSource.Play();

        Instantiate(particle, position, Quaternion.identity);
    }

    public void SetGameOverFlag()
    {
        gameOverFlag = true;
        gameOverText.SetActive(true);
        enterText.SetActive(true);
        gameOverAudioSource.Play();
    }

    public bool GetGameOverFlag()
    {
        return gameOverFlag;
    }

}
