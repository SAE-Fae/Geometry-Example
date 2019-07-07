using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changevector : MonoBehaviour
{
    public float xChange = 0;
    public float yChange = 0;
    public float zChange = 0;
    public bool releaseTheChange = false;
    public float xForce = 0;
    public float yForce = 0;
    public float zForce = 0;
    private Rigidbody thisRigid;

    // Start is called before the first frame update
    void Start()
    {
        thisRigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!releaseTheChange)
        {
            gameObject.transform.position = new Vector3(xChange, yChange, zChange);
            thisRigid.velocity = Vector3.zero;
        }

        if (Input.GetKeyDown("space"))
        {
            thisRigid.AddForce(new Vector3(xForce, yForce, zForce));

        }

    }
}
