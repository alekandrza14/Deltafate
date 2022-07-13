using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ainemed : MonoBehaviour
{
    public Animator anim;
    public float time;
    public void OnTriggerExit(Collider collision)
    {
        if (collision.tag =="Respawn")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0,0,Time.deltaTime*5));
            WaitForSeconds w = new WaitForSeconds(time);
            anim.Play("walke");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            
            anim.Play("henry");
        }
        transform.Rotate(new Vector3(0, Input.GetAxisRaw("Mouse X"), 0));
        
    }
}
