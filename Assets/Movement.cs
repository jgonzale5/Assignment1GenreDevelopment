using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMov = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        this.transform.position = new Vector3(this.transform.position.x + xMov, this.transform.position.y, this.transform.position.z);
    }
}
