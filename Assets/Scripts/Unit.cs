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

    public int Attack(Unit target)
    {
        int randomValue = Random.Range(0, 10);
        int damage;
        if (randomValue < 3)
        {
            damage = power * 2;
        }
        else
        {
            damage = power;
        }
        target.hp -= damage;
        if (target.hp < 0)
        {
            target.hp = 0;
        }
        return damage;
    }
}
