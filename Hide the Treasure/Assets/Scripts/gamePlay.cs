using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamePlay : MonoBehaviour
{
	public float timeRemaining;
	public bool timerIsRunning = false;
	public int countShapesUsed = 0;         // Cardinality of set P (refer to report)
	public float areaCoveredSoFar = 0.0f;   // lambda
	public float score = 0.0f;
	public SpriteRenderer sprRendFloor;
	public float SF; 						// Size of floor
	public Text timeText; 
	public Text levelText;  
	public Text scoreText; 
	
	void Awake()
	{
		// In case not referenced in the editor
		timeText = GameObject.FindGameObjectWithTag("timer").GetComponent<Text>();
		levelText = GameObject.FindGameObjectWithTag("level").GetComponent<Text>();
		scoreText = GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
		
		sprRendFloor = GameObject.FindGameObjectWithTag("Floor").GetComponent<SpriteRenderer>();
	}
	
    void Start()
    {
        timerIsRunning = true;
		SF = 1.0f * sprRendFloor.bounds.size.x * sprRendFloor.bounds.size.y;
		Debug.Log("Initial Area of floor(SF):" + SF + "px^2");
		timeRemaining = 1500 - SF; // as specified in report!
		Debug.Log("Initial computed time:" + timeRemaining + "seconds");
    }
	
	void computeScore()
	{
		score = 1000*areaCoveredSoFar*Mathf.Exp(-countShapesUsed);
		scoreText.text = score.ToString();
	}
	
	void DisplayTime(float timeToDisplay)
	{
		float minutes = Mathf.FloorToInt(timeToDisplay / 60);  
		float seconds = Mathf.FloorToInt(timeToDisplay % 60);
		timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
	}

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
				DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }
}
