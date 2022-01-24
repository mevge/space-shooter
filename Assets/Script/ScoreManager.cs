using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static ScoreManager instance;
	public Text ScoreBoard;
	public Text highScore;
	int score = 0;
	

	void Start () {
		instance = this;
		highScore.text = PlayerPrefs.GetInt("Highscore").ToString();
	}
	
	public void AddPoint(int MeteorValue) {
		score += MeteorValue;
		ScoreBoard.text = score.ToString();

	}
	
	void Update () {
		if(score > PlayerPrefs.GetInt("Highscore")) {
			PlayerPrefs.SetInt("Highscore", score);
		}
	}
}
