using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlbody : MonoBehaviour
{
    
    public unScript script1;
    float tic; int tir; float time = 1;
    Vector3 velv; Vector3 velh;
    private void OnCollisionStay(Collision other)
    {
    
        if (other.collider)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0,20,0),ForceMode.Impulse);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (!gameObject.GetComponent<Rigidbody>())
        {


            gameObject.AddComponent<Rigidbody>().useGravity = true;
            gameObject.GetComponent<Rigidbody>().freezeRotation = true;
            gameObject.GetComponent<Rigidbody>().drag = 1;
            gameObject.GetComponent<Rigidbody>().mass = 4;

        }
        if (script1.outs2.Count != 0)
        {


            time = float.Parse(script1.outs2[0]);
        }
    }

        // Update is called once per frame
    void Update()
    {
        velv = transform.forward * Input.GetAxis("Vertical") * time * Time.deltaTime;
        velh = transform.right * Input.GetAxis("Horizontal") * time * Time.deltaTime;
        gameObject.GetComponent<Rigidbody>().MovePosition(transform.position+velv + velh);

    }
}
