using UnityEngine;
using System.Collections;

public class Wall_Stone_Destuctible : MonoBehaviour {

	public GameObject remains; 
	private bool explode = false;

	void FixedUpdate()
	{
		if (explode)
		{
			Object newWall = Instantiate(remains, transform.position, transform.rotation);
			((GameObject) newWall).transform.SetParent(transform.parent);
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Projectile")
		{
			explode = true;
		}
	}
}
