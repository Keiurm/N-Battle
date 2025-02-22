using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleMainSystem : MonoBehaviour
{
    public Unit player;
    public Unit enemy;

    public Button button;

    public GameObject Label;

    public TextMeshProUGUI battleResultText;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(Battle);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Battle()
    {
        Unit firstAttackUnit;
        Unit secondAttackUnit;

        if (player.speed >= enemy.speed)
        {
            firstAttackUnit = player;
            secondAttackUnit = enemy;
        }
        else
        {
            firstAttackUnit = enemy;
            secondAttackUnit = player;
        }

        if (firstAttackUnit.hp > 0)
        {
            firstAttackUnit.Attack(secondAttackUnit);
        }
        if (secondAttackUnit.hp > 0)
        {
            secondAttackUnit.Attack(firstAttackUnit);
        }


        player.hpSlider.value = player.hp;
        enemy.hpSlider.value = enemy.hp;
        Debug.Log(player.hp);
        if (player.hp <= 0)
        {
            Label.SetActive(true);
            battleResultText.text = "あなたの負け";
        }
        else if (enemy.hp <= 0)
        {
            Label.SetActive(true);
            battleResultText.text = "あなたの勝ち";
        }
    }


}
