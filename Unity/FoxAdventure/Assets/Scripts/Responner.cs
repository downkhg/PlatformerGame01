using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Responner : MonoBehaviour
{
    public GameObject prefabPlayer;
    public GameObject objPlayer;

    public float time;

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

    // Start is called before the first frame update
    void Start()
    {
        
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
