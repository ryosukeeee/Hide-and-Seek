using UnityEngine;
using System.Collections;

public class MaterialChange : MonoBehaviour {

	public Material[] material;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerCtrl.materialChange == true) {
			this.GetComponent<Renderer> ().material = material [1];
		} else {
			this.GetComponent<Renderer> ().material = material [0];
		}
	
	}
}
