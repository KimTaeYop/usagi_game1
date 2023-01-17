using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject page_start;
    public GameObject page_begin1;

    // Start is called before the first frame update
    void Start()
    {
        page_start.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void On_start()
    {
        page_start.SetActive(true);
        page_begin1.SetActive(false);
    }
    public void Off_start()
    {
        page_start.SetActive(false);
    }

    public void On_begin1()
    {
        page_start.SetActive(false);
        page_begin1.SetActive(true);
    }
    public void Off_begin1()
    {
        page_begin1.SetActive(false);
    }
}
