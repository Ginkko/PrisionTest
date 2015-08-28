using UnityEngine;
using System.Collections;

public class filterToggle : MonoBehaviour {
	private AlpacaSound.RetroPixel retroPixel;
	public GameObject fpsCharacter;

	// Use this for initialization
	void Start () {
		retroPixel = fpsCharacter.GetComponent<AlpacaSound.RetroPixel> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("f")) 
		{
			retroPixel.enabled = !retroPixel.enabled;
		}
	}
}
