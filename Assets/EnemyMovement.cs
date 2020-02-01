using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    int isGoingRight = 1;


    // Update is called once per frame
    void Update()
    {
        //Vector3 diagonal = new Vector3(2, 2, 0);
        //diagonal.normalized

        Debug.DrawRay(this.transform.position, new Vector3(isGoingRight, -1, 0).normalized * 1.3f, Color.green);

        if (!Physics.Raycast(this.transform.position, new Vector3(isGoingRight, -1, 0).normalized, 1.3f))
        {
            if (isGoingRight < 0)
            {
                isGoingRight = 1;
            }
            else if (isGoingRight > 0)
            {
                isGoingRight = -1;
            }
        }

        Vector3 targetPos = this.transform.position;
        //targetPos.x += speed;
        targetPos += isGoingRight * Vector3.right * speed * Time.deltaTime;

        this.transform.position = targetPos;
    }
}
