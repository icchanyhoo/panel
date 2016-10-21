using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class attack_status_text : MonoBehaviour {

	public Text attack_status;
	public static int select_chara_num;

	void Start () {
		//文字列に反映
		attack_status = GetComponent<Text> ();
	}

	void Update () {
		//選択したattackステータスを表示
		switch(select_chara_num) {
		case 1 :
			attack_status.text = "attack : " + chara1.attack;
			break;
		case 2 :
			attack_status.text = "attack : " + chara2.attack;
			break;
		case 3 :
			attack_status.text = "attack : " + chara3.attack;
			break;
		case 4 :
			attack_status.text = "attack : " + chara4.attack;
			break;
		case 5 :
			attack_status.text = "attack : " + chara5.attack;
			break;
		case 6 :
			attack_status.text = "attack : " + chara6.attack;
			break;
		case 7 :
			attack_status.text = "attack : " + chara7.attack;
			break;
		case 8 :
			attack_status.text = "attack : " + chara8.attack;
			break;
		case 9 :
			attack_status.text = "attack : " + chara9.attack;
			break;
		case 10 :
			attack_status.text = "attack : " + chara10.attack;
			break;
		case 11 :
			attack_status.text = "attack : " + chara11.attack;
			break;
		case 12 :
			attack_status.text = "attack : " + chara12.attack;
			break;
		case 13 :
			attack_status.text = "attack : " + chara13.attack;
			break;
		case 14 :
			attack_status.text = "attack : " + chara14.attack;
			break;
		case 15 :
			attack_status.text = "attack : " + chara15.attack;
			break;
		case 16 :
			attack_status.text = "attack : " + chara16.attack;
			break;
		default :
			attack_status.text = "attack : " + 0;
			break;
		}
		//選択解除
		if(select_chara_num == 0) {
			attack_status.text = "attack : " + 0;
		}
	}
}
