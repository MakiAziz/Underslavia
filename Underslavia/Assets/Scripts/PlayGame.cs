using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour {



	public void Play_Game (){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
