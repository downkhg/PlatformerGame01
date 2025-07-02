using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dynamic : MonoBehaviour
{
    public int score;
    public float speed = 1;
    public float jumpPower = 0;

    public bool isJump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
            transform.position += Vector3.right * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position += Vector3.left * speed * Time.deltaTime;

        if (isJump == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpPower);
                isJump = true;
            }
        }
    }

    private void OnDestroy()
    {
        //죽은위치에서 부활함
        //GameObject objPlayer = Instantiate(this.gameObject);
        //objPlayer.SetActive(true);
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 200, 20),"Score:"+score);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJump = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"OnCollisionEnter2D:{collision.gameObject.name}");
        ////아이템이 추가될때마다 경우의 수가 늘어나고, 코드를 변경해야한다.
        //if (collision.gameObject.name == "cherry")
        //{
        //    score++;
        //    Destroy(collision.gameObject);
        //    //Destroy(this.gameObject);
        //}

        //if (collision.gameObject.name == "gem")
        //{
        //    score+=100;
        //    Destroy(collision.gameObject);
        //    //Destroy(this.gameObject);
        //}
    }
}
