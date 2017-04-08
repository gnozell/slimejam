using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class z_object : MonoBehaviour {

	Vector3 _startPosition;
	public Sprite z1;
	public Sprite z2;
	public Sprite z3;
	public GameObject myself;

	SpriteRenderer spRender;

	float timer = 0.0f;
	float minimum;
	float maximum;
	// Use this for initialization
	void Start () {
		_startPosition = transform.position;
		minimum = transform.position.y;
		maximum = transform.position.y + 3f;
		spRender = GetComponent<SpriteRenderer> ();
		spRender.sprite = z1;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(transform.position);
		Debug.Log ("max:" + maximum.ToString() + " min:" + minimum.ToString());

		//update sprite if at (1/3) hight and if at (2/3) height
		if (transform.position.y > minimum + ((maximum - minimum)/3)*2) {
			spRender.sprite = z3;
		} else if (transform.position.y > minimum + ((maximum - minimum)/3) ) {
			spRender.sprite = z2;
		}

		// kill myself if i ever reach the maximum
		if (transform.position.y >= maximum){
			
			Instantiate (myself, new Vector3(0,0,0), Quaternion.identity);
			Destroy (gameObject);
		}

		// update the position of the Z
		transform.position = _startPosition + new Vector3(Mathf.Sin(Time.time), Mathf.Lerp(minimum, maximum, timer), 0.0f);
		timer += 0.5f * Time.deltaTime;
	}
}
