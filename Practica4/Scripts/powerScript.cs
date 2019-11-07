using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerScript : MonoBehaviour
{
  public int collisionCount;
  public Text texto;

    void Start()
    {
        collisionCount = 0;

    }

    void OnCollisionEnter(Collision collision)
    {


        if(collision.gameObject.tag == "Coin" )
        {
 
            collisionCount++;
            texto.text = collisionCount.ToString();
            Debug.Log(collisionCount);

        }

        
        if(collision.gameObject.tag == "Mummy" )
        {
 
            collisionCount--;

            if(collisionCount<0)
                collisionCount = 0;

            texto.text = collisionCount.ToString();
            Debug.Log(collisionCount);

        }
    }
}
