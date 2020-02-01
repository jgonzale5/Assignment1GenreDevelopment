using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (ManagerScript.Instance.playerLives <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //manager.playerLives--;
            ManagerScript.Instance.playerLives--;
        }
    }
}
