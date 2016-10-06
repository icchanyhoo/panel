using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ene_turn : MonoBehaviour {

//	public GameObject ene_MainCamera;
	public GameObject srider_in_outBox;
	public static float damege;

	//ターン数
	public void ene(){
		main.turn = 1;
//		panelScript.turn_seec = 2;
		damege = main.damegePoint;
//		Debug.Log ("ene_turn");
//		ene_MainCamera.SendMessage ("Update");
		srider_in_outBox.SendMessage ("srider");

	}

}
