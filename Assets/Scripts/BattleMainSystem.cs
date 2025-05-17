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

    public TextMeshProUGUI battleLogText;

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

        bool firstPlayerAttackFlag = false;
        if (player.speed >= enemy.speed)
        {
            firstAttackUnit = player;
            secondAttackUnit = enemy;
            firstPlayerAttackFlag = true;
        }
        else
        {
            firstAttackUnit = enemy;
            secondAttackUnit = player;
        }
        int damage;
        if (firstAttackUnit.hp > 0)
        {
            damage = firstAttackUnit.Attack(secondAttackUnit);
            if (firstPlayerAttackFlag == true)
            {
                battleLogText.text += "自分の攻撃!!\n";
                battleLogText.text += $"敵に{damage}のダメージ!!\n";
            }
            else
            {
                battleLogText.text += "敵の攻撃!!\n";
                battleLogText.text += $"自分に{damage}のダメージ!!\n";
            }
        }
        if (secondAttackUnit.hp > 0)
        {
            damage = secondAttackUnit.Attack(firstAttackUnit);
            if (firstPlayerAttackFlag == false)
            {
                battleLogText.text += "自分の攻撃!!\n";
                battleLogText.text += $"敵に{damage}のダメージ!!\n";
            }
            else
            {
                battleLogText.text += "敵の攻撃!!\n";
                battleLogText.text += $"自分に{damage}のダメージ!!\n";
            }
        }


        player.hpSlider.value = player.hp;
        enemy.hpSlider.value = enemy.hp;
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
