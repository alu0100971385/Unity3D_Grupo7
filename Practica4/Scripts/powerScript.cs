using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerScript : MonoBehaviour
{
    public int collisionCount;
    public Text texto;

    delegate void PowerDelegate();
    PowerDelegate powerDelegate;

    void Start()
    {
        collisionCount = 0;

    }

    void powerStay()
    {
        Debug.Log(collisionCount);
    }

    void powerUp()
    {
        collisionCount++;
        texto.text = collisionCount.ToString();
        Debug.Log(collisionCount);
    }

    void powerDown()
    {
        collisionCount--;

        if (collisionCount < 0)
            collisionCount = 0;

        texto.text = collisionCount.ToString();
        Debug.Log(collisionCount);
    }

    void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Coin")
        {

            powerDelegate = powerUp;

        }

        else
        if (collision.gameObject.tag == "Mummy")
        {

            powerDelegate = powerDown;

        }
        else
        {
            powerDelegate = powerStay;
        }

        powerDelegate();
    }
}

