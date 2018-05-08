using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	// Use this for initialization
	void Start () {
		text.text = "Hello world";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			text.text = "Otvaraš oči, trepćeš, vid ti je zamućen još." +
			"Polako dolaziš sebi. Nalaziš se u liftu.Alarm te budi. Glava te boli. " +
			"Napipavaš jak udarac. Ničega se ne sjećaš." +
			"Iz lampi iskre frcaju, pomoćna svjetla su se upalila." +
			"Stvari su popadale po podu, iz bačvi se izlilo nešto. Ljepljivo gusto i smrdi..." +
			"Znaš da moraš izaći. Stišćeš mahnito po gumbima. Ništa. " +
			"Vrata pokušavaš otvoriti. Polako. Nemaš snage za to. Treba ti neka poluga. " +
			"Okrećeš se oko sebe u potrazi za njom. Po lijevom dijelu poda je nešto izliveno, " +
			"bačva prevrnuta. Desno od tebe par bačvi, kutija , te kutija za alat.\n\n" +
			"Pritisni B za pogledati Bačvu, K za pogledati kutiju ,A za kutiju za alat.";
		}
	}
}
