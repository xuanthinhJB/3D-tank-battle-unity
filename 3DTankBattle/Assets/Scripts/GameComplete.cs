using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour {
	public Text score;
	private int yourScore;

	void Start () {
		yourScore = PlayerPrefs.GetInt ("currentScore", 0);
		score.text = "" + yourScore;
	}
	
	public void loadLevel() {
		++SceneLoader.currentLevel;
		PlayerPrefs.SetInt ("levelData", SceneLoader.currentLevel);
		SceneManager.LoadSceneAsync (GameManager.level + SceneLoader.currentLevel);
	}
}
