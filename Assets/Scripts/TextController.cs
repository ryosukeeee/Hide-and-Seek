using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
	public string[] scenarios;
	public Text uiText;
	int currentLine ;
	GameObject backimage;
	public static bool reloadJudge;

	// Use this for initialization
	void Start () {
		TextUpdate ();
		backimage = GameObject.Find("BackImage");
		//currentLine = 0;
		PlayerCtrl.IsDead = true;



	
	}

	// Update is called once per frame
	void Update () {
		if(reloadJudge == true){
			backimage.SetActive (false);
			PlayerCtrl.IsDead = false;
		}

		if (currentLine < scenarios.Length && Input.GetKeyDown ("return")) {
			TextUpdate ();
			//PlayerCtrl.IsDead = true;

		} else if (scenarios.Length <= currentLine) {
			PlayerCtrl.IsDead = false;
			backimage.SetActive (false);
		}
	}

	void TextUpdate(){
		uiText.text = scenarios [currentLine];
		currentLine++;

		
	}
}
