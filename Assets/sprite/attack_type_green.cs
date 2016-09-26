using UnityEngine;
using System.Collections;

public class attack_type_green : MonoBehaviour {

	public static float my_damegePoint;

	// Update is called once per frame
	void Update () {
		if(charaBox1.type == 3){
			my_damegePoint = charaBox1.attack;
		}else if(charaBox2.type == 3){
			my_damegePoint = charaBox2.attack;
		}else if(charaBox3.type == 3){
			my_damegePoint = charaBox3.attack;
		}else if(charaBox4.type == 3){
			my_damegePoint = charaBox4.attack;
		}
	}
}
