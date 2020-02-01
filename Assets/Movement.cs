using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 2.0f;

    public KeyCode jumpKey = KeyCode.Space;
    public float jumpForce = 5;
    public bool jumpinAllowed;
    private Rigidbody reggiebody;

    public float cooldown = 0.25f;
    float cooldownCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        reggiebody = GetComponent<Rigidbody>();
        jumpinAllowed = true;
    }

    // Update is called once per frame
    void Update()
    {
        float xMov = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        this.transform.position = new Vector3(this.transform.position.x + xMov, this.transform.position.y, this.transform.position.z);

        float fireVal = Input.GetAxis("Fire1");

        Debug.DrawRay(this.transform.position, -Vector3.up * 1.4f, Color.red);
        
        cooldownCount += Time.deltaTime;

        if (Physics.Raycast(this.transform.position, -Vector3.up, 1.4f))
        {
            jumpinAllowed = true;
        }
        else
        {
            jumpinAllowed = false;

            cooldownCount = 0;
        }

        if (Input.GetKeyDown(jumpKey) && jumpinAllowed && cooldownCount >= cooldown)
        {
            reggiebody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpinAllowed = false;
        }
    }
}
