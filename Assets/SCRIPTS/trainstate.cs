using UnityEngine;
using System.Collections;

public abstract class state
{
	public abstract void changeToMyState(train t);
}

public class backwardstate : state
{
	public override void changeToMyState(train t)
	{
		t.move = new backward ();
	}
}

public class forwardstate : state
{
	public override void changeToMyState(train t)
	{
		t.move = new forward ();
	}
}

public class stopstate : state
{
	public override void changeToMyState(train t)
	{
		t.move = new stop ();
	}
}
	

public class trainstate : MonoBehaviour {

	state mystate;

	state holderforforwardstate = new forwardstate();
	state holderforbackwardstate = new backwardstate();
	state holderforstopstate = new stopstate();

	public train t;
	public int ph = 0;
	public int hold = 0;

	// Update is called once per frame
	void Update () {
		Debug.Log ("num is: " + hold);

		//for keycode inputs
			/*
			if(Input.GetKeyDown(KeyCode.F))
			{
				//mystate = holderforforwardstate;
				//mystate.changeToMyState(t);
				holderforforwardstate.changeToMyState(t);

			}
			if (Input.GetKeyDown(KeyCode.B))
			{
				mystate = holderforbackwardstate;
				mystate.changeToMyState(t);

			}
			if (Input.GetKeyDown(KeyCode.S))
			{
				mystate = holderforstopstate;
				mystate.changeToMyState(t);

			}
			*/

		//for  button inputs
		switch (ph) 
		{
			case 0:
				mystate = holderforstopstate;
				mystate.changeToMyState(t);
				break;
			case 1:
				mystate = holderforforwardstate;
				mystate.changeToMyState(t);
				break;
			case 2:
				mystate = holderforbackwardstate;
				mystate.changeToMyState(t);
				break;
		}
	}
}
