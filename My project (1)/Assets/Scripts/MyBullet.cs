using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBullet : MonoBehaviour
{
    public GameObject Player;

        void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 25, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Player.GetComponent<MyPlayer>().ammoNumber = +5;
            
            Destroy(gameObject);
        }
    }
}
