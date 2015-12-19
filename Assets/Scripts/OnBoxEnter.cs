using UnityEngine;
using System.Collections;

public class OnBoxEnter : MonoBehaviour
{
    public Rigidbody enemyAi;
    public GameObject boxCollider;
    public Transform spawner;
    public Transform spawner2;
    public Transform spawner3;
    private bool inBox;
  
    void OnTriggerEnter(Collider enter)
    {
        Debug.Log("you're in!");
    }

    void OnTriggerExit(Collider exit)
    {
        if (exit.gameObject.tag == "Player")
        {
            Rigidbody instantiateEnemyAi = Instantiate(enemyAi, spawner.position, spawner.rotation) as Rigidbody;
            Rigidbody instantiateEnemyAi2 = Instantiate(enemyAi, spawner2.position, spawner2.rotation) as Rigidbody;
            Rigidbody instantiateEnemyAi3 = Instantiate(enemyAi, spawner3.position, spawner3.rotation) as Rigidbody;
        }
        //inBox = !inBox;
        //boxCollider.gameObject.SetActive(false);
        Debug.Log("left box");
    }
}
