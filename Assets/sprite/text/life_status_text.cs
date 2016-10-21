using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class life_status_text : MonoBehaviour {
	
	public Text life_status;
	public static int select_chara_num;
	
	void Start () {
		//文字列に反映
		life_status = GetComponent<Text> ();
	}
	
	void Update () {
		//選択したattackステータスを表示
		switch(select_chara_num) {
		case 1 :
			life_status.text = "life : " + chara1.defense;
			break;
		case 2 :
			life_status.text = "life : " + chara2.defense;
			break;
		case 3 :
			life_status.text = "life : " + chara3.defense;
			break;
		case 4 :
			life_status.text = "life : " + chara4.defense;
			break;
		case 5 :
			life_status.text = "life : " + chara5.defense;
			break;
		case 6 :
			life_status.text = "life : " + chara6.defense;
			break;
		case 7 :
			life_status.text = "life : " + chara7.defense;
			break;
		case 8 :
			life_status.text = "life : " + chara8.defense;
			break;
		case 9 :
			life_status.text = "life : " + chara9.defense;
			break;
		case 10 :
			life_status.text = "life : " + chara10.defense;
			break;
		case 11 :
			life_status.text = "life : " + chara11.defense;
			break;
		case 12 :
			life_status.text = "life : " + chara12.defense;
			break;
		case 13 :
			life_status.text = "life : " + chara13.defense;
			break;
		case 14 :
			life_status.text = "life : " + chara14.defense;
			break;
		case 15 :
			life_status.text = "life : " + chara15.defense;
			break;
		case 16 :
			life_status.text = "life : " + chara16.defense;
			break;
		default :
			life_status.text = "life : " + 0;
			break;
		}
		//選択解除
		if(select_chara_num == 0) {
			life_status.text = "life : " + 0;
		}
	}
}
