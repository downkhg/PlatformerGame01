using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Responner : MonoBehaviour
{
    public GameObject prefabPlayer; //복제될 원본 프리팹
    public GameObject objPlayer; //복제된 플레이어

    public float time = 1;

    public bool isTimmer;

    IEnumerator ProcessTimer()
    {
        Debug.Log("ProcessTimer() start");
        isTimmer = true;
        yield return new WaitForSeconds(time);

        objPlayer = Instantiate(prefabPlayer, transform.position, Quaternion.identity);

        isTimmer = true;
        Debug.Log("ProcessTimer() end");
    }

    // Update is called once per frame
    void Update()
    {
        if(objPlayer == null && isTimmer == false)
        {
            StartCoroutine(ProcessTimer());
        }
    }
}
