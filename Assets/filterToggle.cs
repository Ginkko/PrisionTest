using UnityEngine;
using System.Collections;

public class filterToggle : MonoBehaviour {
	private AlpacaSound.RetroPixel retroPixel;
	public GameObject fpsCharacter;

	public int filterMultiplier;
//	public float pulseSpeed;
//	public float pulseRange;

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

		if (Input.GetKeyDown ("]"))
		{
			retroPixel.verticalResolution += 9 * filterMultiplier;
			retroPixel.horizontalResolution += 16 * filterMultiplier;
			Debug.Log("Current Resolution: " + retroPixel.horizontalResolution + " X " + retroPixel.verticalResolution);
		}

		if (Input.GetKeyDown ("[")) {
			retroPixel.verticalResolution -= 9 * filterMultiplier;
			retroPixel.horizontalResolution -= 16 * filterMultiplier;
			Debug.Log("Current Resolution: " + retroPixel.horizontalResolution + " X " + retroPixel.verticalResolution);
		}

//		Experimental Sin wave retroPixel filter

//		float vertValueF = (Mathf.Sin (9f * pulseSpeed * Time.time) * Time.deltaTime) * pulseRange;
//		int vertValue = Mathf.RoundToInt (vertValueF);
//
//
//
//		float horiValueF = (Mathf.Sin (16f * pulseSpeed * Time.time) * Time.deltaTime) * pulseRange;
//		int horiValue = (int)vertValueF;
//
//		Debug.Log (vertValueF + " " + vertValue);
//
//		retroPixel.verticalResolution += vertValue;
//		retroPixel.horizontalResolution += horiValue;



	}
}
