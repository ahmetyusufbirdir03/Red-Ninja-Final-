using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sea : MonoBehaviour
{   
    [SerializeField] public int water_id = 0;


    void OnTriggerEnter2D(Collider2D other){
        PlayerController player = other.GetComponent<PlayerController>();
        if(other.tag == "Player")
        {
            PlayerPrefs.SetInt("Life", PlayerPrefs.GetInt("Life") - 1);
            switch (this.water_id){
                case 0:
                    player.transform.position = new Vector3(-13,1,0);
                    break;
                case 1:
                    player.transform.position = new Vector3(40,3,0);
                    break;
                case 2:
                    player.transform.position = new Vector3(40,3,0);
                    break;
                case 3:
                    player.transform.position = new Vector3(40,3,0);
                    break;
                case 4:
                    player.transform.position = new Vector3(96,-14,0);
                    break;
                case 5:
                    player.transform.position = new Vector3(113,13,0);
                    break;
                case 6:
                    player.transform.position = new Vector3(14,0,0);
                    break;
                default:
                    break; 
            }
             
        }
    }
}
