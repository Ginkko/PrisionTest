using UnityEngine;
using System.Collections;

public class levetate : MonoBehaviour {
	public float hoverSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 updatePosition = transform.position;
		updatePosition.y += Mathf.Sin (Time.time * hoverSpeed) * Time.deltaTime;
		transform.position = updatePosition;
	}
}
