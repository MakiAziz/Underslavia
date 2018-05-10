using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States {lift, bacva, kutija, kutija_za_alat, vrata, svjetlo, izlaz};
	private States myStates;

	// Use this for initialization
	void Start () {
		myStates = States.lift;
	}
	
	// Update is called once per frame
	void Update () {
		print (myStates);
		if (myStates == States.lift) {state_lift ();} 
		else if (myStates == States.bacva) {state_bacva ();} 
		else if (myStates == States.kutija) {state_kutija ();} 
		else if (myStates == States.kutija_za_alat) {state_kutija_za_alat ();} 
		else if (myStates == States.svjetlo) {state_svjetlo ();} 
		else if (myStates == States.vrata) {state_vrata ();} 
		else if (myStates == States.izlaz) {state_izlaz ();}
	}

		void state_lift () {
			text.text = "Otvaraš oči, trepćeš, vid ti je zamućen još." +
						"Polako dolaziš sebi. Nalaziš se u liftu.Alarm te budi. Glava te boli. " +
						"Napipavaš jak udarac. Ničega se ne sjećaš." +
						"Iz lampi iskre frcaju, pomoćna svjetla su se upalila." +
						"Stvari su popadale po podu, iz bačvi se izlilo nešto. Ljepljivo gusto i smrdi..." +
						"Znaš da moraš izaći. Stišćeš mahnito po gumbima. Ništa. " +
						"Vrata pokušavaš otvoriti. Polako. Nemaš snage za to. Treba ti neka poluga. " +
						"Okrećeš se oko sebe u potrazi za njom. Po lijevom dijelu poda je nešto izliveno, " +
						"bačva prevrnuta. Desno od tebe par bačvi, kutija , te kutija za alat.\n\n" +
						"Pritisni B za pogledati Bačvu, K za pogledati kutiju ," +
						"A za kutiju za alat , V za vrata ,S za svjetlo";
		if (Input.GetKeyDown (KeyCode.B)) {myStates = States.bacva;}
		else if (Input.GetKeyDown (KeyCode.K)) {myStates = States.kutija;}
		else if (Input.GetKeyDown (KeyCode.A)) {myStates = States.kutija_za_alat;}
		else if (Input.GetKeyDown (KeyCode.V)) {myStates = States.vrata;}
		else if (Input.GetKeyDown (KeyCode.S)) {myStates = States.svjetlo;}
		}
	

	void state_bacva (){
		text.text = "Vidiš bačvu.\n\n" +
					"Pritisni L za povratak u lift";
		if (Input.GetKeyDown (KeyCode.L)) {myStates = States.lift;}
	}

	void state_kutija (){
		text.text = "Vidiš kutiju. \n\n" +
			"Pritisni L za povratak u lift";
		if (Input.GetKeyDown (KeyCode.L)) {myStates = States.lift;}
	}

	void state_kutija_za_alat (){
		text.text = "Vidiš kutiju za alat. \n\n" +
			"Pritisni L za povratak u lift";
		if (Input.GetKeyDown (KeyCode.L)) {myStates = States.lift;}

}

		void state_svjetlo (){
		text.text = "Vidiš svjetlo na stropu. \n\n" +
		"Pritisni L za povratak u lift";
		if (Input.GetKeyDown (KeyCode.L)) {myStates = States.lift;}
	}

		void state_vrata () {
				text.text = "Vidiš vrata ispred sebe. \n\n" +
							"Pritisni L za povratak u lift ili I za izlaz";
				if (Input.GetKeyDown (KeyCode.L)) {myStates = States.lift;}
				else if (Input.GetKeyDown (KeyCode.I)) {myStates = States.izlaz;}
			}

		void state_izlaz (){
					text.text = "Napokon si na slobodi!\n\n" + 
								"Pritisni P za igrati ispočetka";
		if (Input.GetKeyDown (KeyCode.P)) {myStates = States.lift;}
			}
	}
	
