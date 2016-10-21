using UnityEngine;
using System.Collections;

public class stopbutton : MonoBehaviour {

	public trainstate instance;

	void OnMouseDown() 
	{
		if (instance.hold == 2 || instance.hold == 3)
			instance.ph = 1;
		else if (instance.hold == 4 || instance.hold == 5)
			instance.ph = 2;
		else
			instance.ph = 0;	
	}
}
