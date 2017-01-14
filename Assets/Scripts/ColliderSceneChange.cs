using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ColliderSceneChange : MonoBehaviour {
	public string Scene;
	void OnTriggerEnter(Collider other){
		if (other.tag == "visible") {
			SceneManager.LoadScene (Scene);

		}
	}

}
