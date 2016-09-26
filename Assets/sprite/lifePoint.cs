using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class lifePoint : MonoBehaviour {

	public static float my_life;
	public static float ene_life;
	Slider _slider;
	Slider ene_slider;
	// Use this for initialization
	void Start () {

		my_life = (charaBox1.defense + charaBox2.defense + charaBox3.defense + charaBox4.defense);
		ene_life = eneBox.ene_defense;

		Debug.Log ("my_life" + my_life);
		Debug.Log ("ene_life" + ene_life);

		_slider = GameObject.Find("my_lifebar").GetComponent<Slider>();
		ene_slider = GameObject.Find("ene_lifebar").GetComponent<Slider>();
		_slider.maxValue = my_life;
		ene_slider.maxValue = ene_life;
	}
	
	// Update is called once per frame
	void Update () {

		_slider.value = my_life;
		ene_slider.value = ene_life;
		if(my_life < 0){

			Debug.Log("gameOver");

			Application.LoadLevel(0);

		}

		if(ene_life < 0){
			
			Debug.Log("win");

			Application.LoadLevel(0);
			
		}
	
	}
}
