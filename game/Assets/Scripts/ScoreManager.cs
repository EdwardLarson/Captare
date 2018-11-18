using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text scoreText;
	public Text highScoreText;

	public float scoreCount;
	public float highScoreCount;

	public float pointsPerSecond;
	public bool scoreIncreasing;

	// Use this for initialization
	void Start () {
		// Get high score of user
		// highScoreText.text = "High Score: " + highScoreCount;
	}
	
	// Update is called once per frame
	void Update () {

		scoreCount += pointsPerSecond * Time.deltaTime;

		if(scoreCount > highScoreCount)
		{
			highScoreCount = scoreCount;
			// Set high score for user
		}

		scoreText.text = "Score: " + Mathf.Round(scoreCount);
		highScoreText.text = "High Score: " +  Mathf.Round(highScoreCount);

	}

	public void AddScore(int pointsToAdd)
	{
		scoreCount += pointsToAdd;
	}
}
