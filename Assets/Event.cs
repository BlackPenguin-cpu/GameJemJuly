using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int Day;
    public int windchance=33;
    float time;
    int PriateDay;
    bool mainisland;
    bool ship;
    // Start is called before the first frame update
    void Start()
    {
        PriateDay = 10 + (Random.Range(1, 6) - 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 600)
        {
            Day++;
            time = 0;
            if (ship)
            {
                if (Random.Range(1, 100)>windchance)
                {
                    //여기는 배 시스템이 생겨야 만들수 있을듯 합니다.
                }
            }
            if (Day >= PriateDay)
            {
                PriateEvent();
                PriateDay = (Day + 10) + (Random.Range(1, 6) - 3);
            }
        }
        if (mainisland)
            time += Time.deltaTime;
    }
    void PriateEvent()
    {
        if (ship)
        {
            //이 부근은 전체적인 시스템이 만들어야 패널티를 부여할듯 합니다.
        }
        else
        {

        }
    }
}
