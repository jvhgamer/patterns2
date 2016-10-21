using UnityEngine;
using System.Collections;

public class backbutton : MonoBehaviour {

	public trainstate instance;

	void OnMouseDown() 
	{
		if (instance.hold == 3 || instance.hold == 5)
			instance.ph = 0;
		else if (instance.hold == 1 || instance.hold == 4)
			instance.ph = 1;
		else
			instance.ph = 2;	
	}
}
