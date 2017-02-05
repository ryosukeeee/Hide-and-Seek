using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarCtrl : MonoBehaviour {
	Slider slider;
	// Use this for initialization
	void Start () {
		slider = GameObject.Find ("Slider").GetComponent<Slider> ();

	}
	
	// Update is called once per frame
	void Update () {
		slider.value = PlayerCtrl.Gauge;
	}
}
