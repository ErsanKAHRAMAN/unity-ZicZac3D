using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGround : MonoBehaviour
{
    public GameObject lastGround;
    

   


    void Start()
    {
        for (int i = 0; i < 20; i++)
        {

            createGround();
            
        }


    }




    public void createGround()
    {

        Vector3 direction;
        if(Random.Range(0,2) == 0)
        {
            direction = Vector3.left;
        }
        else
        {
            direction = Vector3.forward;
        }

      lastGround =  Instantiate(lastGround, lastGround.transform.position + direction, lastGround.transform.rotation);   //ilk kýsým hangi obje spawnlanýcak, ikinci kýsým obje spawnlýcaðýmýz konumu gösteriyoruz, ücüncü kýsým olarakta rotasyonu gösteririz.
         
    }
}
