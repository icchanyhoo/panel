using UnityEngine;
using System.Collections;

public class attack_type_green : MonoBehaviour {

	public static float my_damegePoint;

	//各ステータス格納
	public static float add_chara3;
	public static float add_chara7;
	public static float add_chara11;
	public static float add_chara15;

	void Start(){
		//合算値
		my_damegePoint = add_chara3 + add_chara7 +add_chara11 + add_chara15;
		Debug.Log ("add_af_green : " + my_damegePoint);
	}
}
