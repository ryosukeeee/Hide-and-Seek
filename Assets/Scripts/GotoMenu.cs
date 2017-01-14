using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GotoMenu : MonoBehaviour {
	int Count;
	// Use this for initialization
	void Start () {
		Count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Count++;
		if (Count == 200) {
			SceneManager.LoadScene ("Menu");
			
		}
	}
}
