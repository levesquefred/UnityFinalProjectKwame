using UnityEngine;
using System.Collections;

public class Ai : MonoBehaviour
{
    public Transform Player;
    public float aiSpeed;
    public float minDistance;
    public GUIText Restart;

   void Start()
    {
        //Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(Player);
        ArtificialIntelligence();
	}

    void ArtificialIntelligence()
    {
        if (Vector3.Distance(transform.position, Player.position) >= minDistance)
        {
            transform.position += transform.forward * aiSpeed * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            Restart.text = "The Enemy got you! Too bad!";
        }
    }
}
