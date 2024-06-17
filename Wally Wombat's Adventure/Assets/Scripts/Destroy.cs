using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject CUB;


    void Start()
    {
        uiObject.SetActive(false);
    }
	void OnTriggerEnter2D (Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
        }
        else if (player.gameObject.tag == "Enemies")
        {
            
        }
	}
   void OnTriggerExit2D (Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
        uiObject.SetActive(false);
        Destroy(CUB);
        }
	}
    
}