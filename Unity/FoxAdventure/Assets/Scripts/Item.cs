using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�����۽�ũ��Ʈ�� ����ϸ� ������Ʈ�� �þ����,
//������ �ٸ��������� ���� �ø����ִ�.
public class Item : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"OnCollisionEnter2D:{collision.gameObject.name}");
        if (collision.gameObject.name == "player")
        {
            //collision.GetComponent<Dynamic>().score++;
            collision.GetComponent<Dynamic>().score+=score;
            //Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
