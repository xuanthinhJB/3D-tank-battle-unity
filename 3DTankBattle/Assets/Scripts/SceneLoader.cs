using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
	public Text textLoading;
	private bool isLoadGamePlay = false;
	private bool isLoadScene = false;
	public static int currentLevel = 1;

	// Use this for initialization
	void Start () {
		currentLevel = PlayerPrefs.GetInt ("levelData", 1);
	}
	
	// Update is called once per frame
	void Update () {
		if (isLoadScene && !isLoadScene) {
			isLoadScene = true;
			textLoading.text = "Loading....";
			SceneManager.LoadSceneAsync ("GameLevel" + currentLevel);
		}
	}

	public void loadGameScene() {
		isLoadGamePlay = true;
	}
}
