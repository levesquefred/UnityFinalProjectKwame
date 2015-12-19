using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour
{
    public float speed;
    public Rigidbody projectile;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody instantiateProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            instantiateProjectile.velocity = transform.TransformDirection(new Vector3(0.0f, 0.0f, speed));
        }
	}
}
