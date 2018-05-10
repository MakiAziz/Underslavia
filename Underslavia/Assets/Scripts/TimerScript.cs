using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

	Image TimerBar;
	public float maxTime = 5f;
	float timeLeft;
	public GameObject textZaSlider;


	// Use this for initialization
	void Start () {
		textZaSlider.SetActive (false);
		TimerBar = GetComponent<Image> ();
		timeLeft = maxTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (timeLeft > 0) {
			timeLeft -= Time.deltaTime;
			TimerBar.fillAmount = timeLeft / maxTime;
		} else {
			textZaSlider.SetActive (true);
			Time.timeScale = 0;
		}
	}
}
