using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{

    [SerializeField] private RectTransform[] options;
    private RectTransform rect;
    private int currentPosition;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            ChangePosition(-1);
    }

    private void Awake()
    {
        rect = GetComponent<RectTransform>();
    }


    private void ChangePosition(int change)
    {
        currentPosition += change;
        if (currentPosition < 0)
            currentPosition = options.Length - 1;
        else if (currentPosition > options.Length - 1) 
            currentPosition = 0;    

        rect.position = new Vector3(rect.position.x, options[currentPosition].position.y,0);
    }
}
