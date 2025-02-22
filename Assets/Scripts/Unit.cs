using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unit : MonoBehaviour
{
    public int hp;
    public int power;

    public int speed;

    public Slider hpSlider;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Attack(Unit target)
    {
        if (target.hp < 0)
        {
            target.hp = 0;
        }
        int randomValue = Random.Range(0, 10);
        if (randomValue < 3)
        {
            target.hp -= power * 2;
        }
        else
        {
            target.hp -= power;
        }


    }
}
