using UnityEngine;
using System.Collections;

public class PanelSlider : MonoBehaviour {
	public float distance; // スライドする長さ
	public float length; // 反応する距離

	Vector3 startPos; // 初期位置座標
	Transform player; // プレイヤー座標

	// Use this for initialization
	void Start () 
	{
		player = GameObject.Find("sride_in_out").transform; // Playerという名前のオブジェクトを取得
		startPos = transform.position; // 初期位置を代入
	}

	// Update is called once per frame
	void Update () 
	{
		Vector3 pos = transform.position; // 現在の座標

			distance += 0.2f;
			
		if(distance == 7.5f){
			Time.timeScale = 0;
		}

		// プレイヤーが一定の距離に近づいたら
		if (Vector3.Distance(player.position, startPos) <= length)
		{
			// 線形補間を使って徐々にスライドさせる
			pos.x = Mathf.Lerp(pos.x, startPos.x + distance, Time.deltaTime * 5f);

		}
		else
		{
			// 元の位置に戻る
			pos.x = Mathf.Lerp(pos.x, startPos.x, Time.deltaTime * 5f);
		}
		
		transform.position = pos; // 座標を指定

	}

}