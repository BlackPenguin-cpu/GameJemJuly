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
                    //����� �� �ý����� ���ܾ� ����� ������ �մϴ�.
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
            //�� �α��� ��ü���� �ý����� ������ �г�Ƽ�� �ο��ҵ� �մϴ�.
        }
        else
        {

        }
    }
}