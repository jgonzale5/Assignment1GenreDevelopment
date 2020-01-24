using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //public GameObject managerObject;
    //private ManagerScript manager;

    //private void Start()
    //{
    //    manager = managerObject.GetComponent<ManagerScript>();
    //}

    // Update is called once per frame
    void Update()
    {
        if (ManagerScript.Instance.playerLives <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
