using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class earthScript : MonoBehaviour
{
  //public TextMeshProUGUI textMeshProUGUI;
   
  void OnTriggerEnter (Collider other) {

    if(other.gameObject.tag=="Enemy") {

       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      
      //textMeshProUGUI.text = "GAME OVER";
      Debug.Log("hi");

     }
   }
}
