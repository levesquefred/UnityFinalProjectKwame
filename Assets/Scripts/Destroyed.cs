using UnityEngine;
using System.Collections;

public class Destroyed : MonoBehaviour
{

  
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Floor")
        {
            Destroy(gameObject);
            Debug.Log("hit");
        }

        //if (col.gameObject.tag == "Ai")
        //{
        //    Destroy(gameObject);
        //}
    }
}

