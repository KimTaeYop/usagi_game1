using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject page_start;
    public GameObject page_begin1;
    public int point; //운
    public bool ei, sn, ft, jp;
    public int stat_a, stat_b, stat_c;

    // Start is called before the first frame update
    void Start()
    {
        page_start.SetActive(true);
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Choose_mbti();
        }
    }

    void Choose_mbti()
    {
        //(E,I)(S,N)(F,T)(J,P) - 능력치 stat_a,stat_b,stat_c
        for (int i = 0; i < 4; i++)
        {
            switch (i)
            {
                case 0:
                    if (ei == true)
                    {
                        stat_a += 1;
                    }
                    else
                    {
                        stat_b += 1;
                    }
                    break;
                case 1:
                    //넘어감
                    break;
                case 2:
                    if (ft == true)
                    {
                        stat_c -= 1;
                    }
                    else
                    {
                        stat_a -= 1;
                    }
                    break;
                case 3:
                    if (ei == true)
                    {
                        stat_a += 2;
                    }
                    else
                    {
                        stat_b += 2;
                    }
                    break;
                default:
                    break;
            }
        }
    }

    void Reset()
    {
        point = 10;
        stat_a = 0;
        stat_b = 0;
        stat_c = 0;
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

    public void Manage_point()
    {
        point++;
    }

    public void Off_begin1()
    {
        page_begin1.SetActive(false);
    }
}
