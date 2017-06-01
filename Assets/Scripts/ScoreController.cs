using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreController : MonoBehaviour {

    public Text scoreText;
    public GameObject gameOverWidget;

    float score;
    Rigidbody ballRigidbody;
    bool bIsInAir;

	// Use this for initialization
	void Start () {
        score = 0;
        ballRigidbody = GetComponent<Rigidbody>();

        bIsInAir = true;
        UpdateScoreText();

        gameOverWidget.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (bIsInAir)
        {
            score += Time.deltaTime * 10f;
            
        }
        UpdateScoreText();
    }

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            bIsInAir = false;
        }
        else if (hit.gameObject.CompareTag("Floor"))
        {
            TriggerGameOver();
        }
    }

    void OnCollisionExit(Collision hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            bIsInAir = true;
        }
    }

    void UpdateScoreText()
    {
        int scoreInt = Mathf.FloorToInt(score);
        scoreText.text = scoreInt.ToString();
    }

    void TriggerGameOver()
    {
        Time.timeScale = 0f;
        gameOverWidget.SetActive(true);
    }
}

