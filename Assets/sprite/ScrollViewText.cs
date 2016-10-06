using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScrollViewText : MonoBehaviour {
	public GameObject PanelScriptBox;

	void Scroll () {
		
		if( FlagManager.Instance.flags[0] == true) 
		{
			// Flag 0 が立った
			GetComponent<Text>().text = "あなたのターン";
			GetComponent<Animator> ().SetTrigger ("scrollText_anime");
			main.turn = 0;
			Invoke ("seec_frist",2.8f);
		}
		
		if (FlagManager.Instance.flags [1] == true) {
			// Flag 1 が立った
			PanelScriptBox.GetComponent<main>().enabled = false;
			GetComponent<Text>().text = "エネミーターン";
			GetComponent<Animator> ().SetTrigger ("scrollText_anime");
			main.turn = 1;
			Invoke("seec_myturn",3.0f);
		}
		
		if (FlagManager.Instance.flags [2] == true) {
			// Flag 2 が立った
			PanelScriptBox.GetComponent<main>().enabled = false;
			GetComponent<Text>().text = "あなたのターン";
			GetComponent<Animator> ().SetTrigger ("scrollText_anime");
			main.turn = 0;
			Invoke("seec_eneturn",2.0f);
		}
		
	}
	
	void seec_frist(){
		FlagManager.Instance.flags[0] = false;
		GetComponent<Animator> ().Play ("scrollText_anime");
		PanelScriptBox.SendMessage ("Drop");
	}
	
	void seec_myturn(){
		PanelScriptBox.GetComponent<main>().enabled = true;

		Debug.Log ("ene_enabled : true");

		FlagManager.Instance.flags[1] = false;
		GetComponent<Animator> ().Play ("scrollText_anime");
		PanelScriptBox.SendMessage ("Update");
	}
	
	void seec_eneturn(){
		PanelScriptBox.GetComponent<main>().enabled = true;

		Debug.Log ("my_enabled : true");

		FlagManager.Instance.flags[2] = false;
		GetComponent<Animator> ().Play ("scrollText_anime");
		PanelScriptBox.SendMessage ("Update");
	}
}
