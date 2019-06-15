//using UnityEngine;
//using System.Collections;
//using System;
//namespace CompleteProject
//{
//public class Instantiation : MonoBehaviour
//{
//    public Vector3 Spawnpoint;
//        public GameObject enemyspawn = GameObject.FindGameObjectWithTag("Enemy");

//    void Start()
//    {
//        Spawnpoint = transform.position;      //measure coordinates of location
//        enemyspawn.transform.position = new Vector3(Spawnpoint.x,Spawnpoint.y,Spawnpoint.z);
           
//    }
//    void Update()
//    {
//      if (Enemy.Enemyisdead == true)
//            {
//                enemyspawn.SetActive(true);
//                print("enemy is reset");
//                //GameObject.Instantiate(gameObject, new Vector3(Spawnpoint.x, Spawnpoint.y, Spawnpoint.z), Quaternion.identity);
//                //enemyspawn.transform.position = new Vector3(Spawnpoint.x, Spawnpoint.y, Spawnpoint.z);
                
//            }  
//    }

//}
//}