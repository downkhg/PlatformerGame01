using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    public bool isJump;
    public float speed = 1;
    public float jumpPower = 0;

    public float time;

    public bool isTimmer;

    IEnumerator ProcessTimer()
    {
        Debug.Log("ProcessTimer() start");
        isTimmer = true;
        yield return new WaitForSeconds(time);
        Jump();
        isTimmer = true;
        Debug.Log("ProcessTimer() end");
    }

    // Start is called before the first frame update
    void Start()
    {

       

    }

    // Update is called once per frame
    void Update()
    {
        if(isJump)
            transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJump = false;
        StartCoroutine(ProcessTimer());
    }

    void Jump()
    {
        if (isJump == false) 
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpPower);
            isJump = true;
        }
    }
}
