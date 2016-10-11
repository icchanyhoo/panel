using UnityEngine;
using System.Collections;

public class attack_type_yellow : MonoBehaviour {

	public static float my_damegePoint;

	//各ステータス格納
	public static float add_chara4;
	public static float add_chara8;
	public static float add_chara12;
	public static float add_chara16;

	void Start(){
		//合算値
		my_damegePoint = add_chara4 + add_chara8 + add_chara12 + add_chara16;
		Debug.Log ("add_af_yellow : " + my_damegePoint);
	}
}
