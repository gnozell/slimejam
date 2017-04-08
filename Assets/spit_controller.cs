using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spit_controller : MonoBehaviour {
	float minimum;
	float maximum;

	public GameObject spittip;
	LineRenderer lRender;

	// Use this for initialization
	void Start () {
		lRender = GetComponent<LineRenderer> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 oldPosition = lRender.GetPosition (lRender.numPositions-1);
		lRender.SetPosition (lRender.numPositions-1, oldPosition + new Vector3(0,-1*Time.deltaTime,0));


		spittip.transform.position = lRender.GetPosition (lRender.numPositions -1);
	}
}
