using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	public Text yourScore;
	int yourscore = 0;

	// Use this for initialization
	void Start () {
		yourscore = PlayerPrefs.GetInt ("currentScore", 0);
		yourScore.text = "Your score: " + yourscore;
	}
	
	public void playAgain() {
		SceneManager.LoadSceneAsync (GameManager.level + SceneLoader.currentLevel);
	}
}
