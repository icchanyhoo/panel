using UnityEngine;
using System.Collections;

public class attack_type_bull : MonoBehaviour {
	
	public static float my_damegePoint;

	//各ステータス格納
	public static float add_chara2;
	public static float add_chara6;
	public static float add_chara10;
	public static float add_chara14;
	
	void Start(){
		//合算値
		my_damegePoint = add_chara2 + add_chara6 + add_chara10 + add_chara14;
		Debug.Log ("add_af_bull : " + my_damegePoint);
	}
}
