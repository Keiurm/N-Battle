using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BeforeBattleMainSystem : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(MoveBattleScene);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void MoveBattleScene()
    {
        SceneManager.LoadScene("BattleScene");
    }
}
