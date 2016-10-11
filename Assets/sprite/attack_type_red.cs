using UnityEngine;
using System.Collections;

public class attack_type_red : MonoBehaviour {
	
	public static float my_damegePoint;

	//各ステータス格納
	public static float add_chara1;
	public static float add_chara5;
	public static float add_chara9;
	public static float add_chara13;

	void Start(){
		//合算値
		my_damegePoint = add_chara1 + add_chara5 + add_chara9 + add_chara13;
		Debug.Log ("add_af_red : " + my_damegePoint);
	}
	
//	void Update () {
//		if(charaBox1.type == 1){
//			my_damegePoint = charaBox1.attack;
//		}else if(charaBox2.type == 1){
//			my_damegePoint = charaBox2.attack;
//		}else if(charaBox3.type == 1){
//			my_damegePoint = charaBox3.attack;
//		}else if(charaBox4.type == 1){
//			my_damegePoint = charaBox4.attack;
//		}
//	}
}
