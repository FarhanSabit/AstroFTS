using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreScript : MonoBehaviour
{
    playerScript pps;
    public GameObject player;
    public TextMeshProUGUI scoreGUI;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        pps = player.GetComponent<playerScript>();
        //scoreGUI.text = "Score : " + score;
        scoreGUI.text = "Score : " + pps.shoot();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
