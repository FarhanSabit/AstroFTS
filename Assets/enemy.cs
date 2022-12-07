using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
   // Start is called before the first frame update
    private Transform goal;
    //private NavMeshAgent agent;
    bool dead = false;
    int numberofAstroids;
    public GameObject player;
    public GameObject earth;
    public float speed;
    //public GameObject ;
    playerScript ps;
    void Start()
    {
        player = GameObject.Find("Player");
        ps = player.GetComponent<playerScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        var earth = GameObject.FindGameObjectWithTag("earth");
       
        Vector3 earthPosition= earth.transform.position;
        
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, earthPosition, speed*Time.deltaTime);

        
    }

public void AstroidDestroy()
    {
        Destroy(gameObject,0.0f);
        if(numberofAstroids <= 10)
        {
            GameObject astroid = Instantiate(Resources.Load("Cube")) as GameObject;
           

            float x = Random.Range(10f, 120f);
            float z = Random.Range(10f, 120f);
            float y = Random.Range(10f, 120f);
            astroid.transform.position = new Vector3(x, y, z);
        }

        ps.shoot();
    }
}
