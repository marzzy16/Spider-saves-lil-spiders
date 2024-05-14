using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]private GameObject gameoverScreen;

    private void Awake()
    {
        gameoverScreen.SetActive(false);
    }
    public void GameOver()
    {
        gameoverScreen.SetActive(true);
    }
}