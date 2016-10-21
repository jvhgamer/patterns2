using UnityEngine;
using System.Collections;

public abstract class movement
{
	public abstract void move(ref float x);
}

public class backward : movement
{
	public override void move(ref float x)
	{
		x = -.1f;
	}
}

public class forward : movement 
{
	public override void move(ref float x)
	{
		x = .1f;
	}
}

public class stop : movement
{
	public override void move(ref float x)
	{
		x = 0.0f;
	}
}


public class train : MonoBehaviour {
	// Use this for initialization
	public Rigidbody rb;
	private float thrust = 0.0f;

	public movement move = new stop();

	void Start() 
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate() 
	{
		//default in the stop state on program load
		move.move (ref thrust);
		rb.AddForce(transform.forward * thrust * 100);
	}
}
