using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerScript : MonoBehaviour
{
    // Start is called before the first frame update
    //public TextMeshProUGUI textMeshProUGUI;
    //private int score;
    CharacterController characterController;
    public Transform cameraTransform;
    public int speed = 8;
    //bool move = false;
    Rigidbody move;

    //GameObject gun;
    void Start()
    {
        characterController = gameObject.GetComponent<CharacterController>();
        //gun = gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject;

        //Score
        //score = 0;
        //textMeshProUGUI.text = "Score : " + score;
        move = GetComponent<Rigidbody>();
    }

    public void shoot()
    {
        Debug.Log("Started to Shoot");
        StartCoroutine("Shoot");
        //score += 1;
    }

    IEnumerator Shoot()
    {
       // gun.GetComponent<Animation>().Play();
        yield return new WaitForSeconds(1f);
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.eulerAngles.z > 90.0f && transform.eulerAngles.z < 270.0f)
        {
            move.velocity = -cameraTransform.forward * speed;
        }
        else
        {
            move.velocity = cameraTransform.forward * speed;
        }
        // if (move)
        // {
        //     Vector3 Orientation = cameraTransform.TransformDirection(Vector3.forward);
        //     characterController.SimpleMove(Orientation * speed);

        // }

        //Score
        //textMeshProUGUI.text = "Score : " + score;

    }
}
