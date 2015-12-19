using UnityEngine;
using System.Collections;

public class AiDestroyed : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere(Clone)")
        {
            Destroy(gameObject);
            Debug.Log("hit");
        }
    }
}
