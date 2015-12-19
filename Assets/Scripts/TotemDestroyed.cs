using UnityEngine;
using System.Collections;

public class TotemDestroyed : MonoBehaviour
{
    private bool particles;
    public GameObject PartSys;
       

    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.name == "Sphere(Clone)")
        {
            Destroy(gameObject);
            particles = !particles;
            PartSys.gameObject.SetActive(false);
            Debug.Log("hit");
        }
    }
}
