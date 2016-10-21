using UnityEngine;
using System.Collections;

public class randbutton : MonoBehaviour {

	public trainstate instance;

	void OnMouseDown() 
	{
		instance.hold = Random.Range (0, 6);
		//instance.hold = 5.0f;
		//instance.ph = 1;	
	}
}
