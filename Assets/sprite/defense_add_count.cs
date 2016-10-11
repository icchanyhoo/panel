using UnityEngine;
using System.Collections;

public class defense_add_count : MonoBehaviour {

	public static float add_count;

	//各ステータス格納
	public static float add_chara1;
	public static float add_chara2;
	public static float add_chara3;
	public static float add_chara4;
	public static float add_chara5;
	public static float add_chara6;
	public static float add_chara7;
	public static float add_chara8;
	public static float add_chara9;
	public static float add_chara10;
	public static float add_chara11;
	public static float add_chara12;
	public static float add_chara13;
	public static float add_chara14;
	public static float add_chara15;
	public static float add_chara16;

	void Start () {
		//合算値
		add_count = add_chara1 + add_chara2 + add_chara3 + add_chara4 + add_chara5 + add_chara6 + add_chara7 + add_chara8
			+ add_chara9 + add_chara10 + add_chara11 + add_chara12 + add_chara13 + add_chara14 +add_chara15 + add_chara16;
		Debug.Log ("defense_add_count : " + add_count);
	}	
}
