using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	const int maxLevel = 3;
	const int maxNumberOfEnemy = 4;
	const int numberOfEnemyEachLevel = 4;
	public static string level = "GameLevel1";
	public GameObject[] enemy;
	private GameObject[] respawn;

	public Text textCurrentLevel;
	public Text textCurrentScore;
	private static int maxEnemy;
	private static int currentScore;

	// Use this for initialization
	void Start () {
		textCurrentLevel.text = "Level 1";
		respawn = GameObject.FindGameObjectsWithTag ("Respawn");
		int i = 0;
		for (i = 0; i < respawn.Length; i++) {
			Instantiate (enemy [Random.Range (0, enemy.Length)], respawn [i].transform.position, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (maxEnemy <= 0) {
			if (SceneLoader.currentLevel >= maxLevel) {
				SceneManager.LoadSceneAsync ("GameFinish");
			} else {
				SceneManager.LoadSceneAsync ("GameComplete");	
			}
		}
	}

	public void addEnemy (){
		if (maxEnemy >= respawn.Length) {
			Instantiate (enemy [Random.Range (0, enemy.Length)], respawn [Random.Range (0, enemy.Length)].transform.position, Quaternion.identity);
		}
	}

	public void destroyEnemy () {
		maxEnemy--;
		currentScore++;
		PlayerPrefs.SetInt ("currentScore", currentScore);
	}

	public static void gameOver() {
		if (maxEnemy == maxNumberOfEnemy + 10 * (SceneLoader.currentLevel - 1)) {
			PlayerPrefs.SetInt ("currentScore", 0);
		}
		maxEnemy = maxNumberOfEnemy + 10 * (SceneLoader.currentLevel - 1);
		SceneManager.LoadSceneAsync ("GameOver");
	}
}
