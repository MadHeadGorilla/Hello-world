using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;
    
    // Start is called before the first frame update
    void Start()
    {
        StartGame();

    }
    void StartGame ()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Добро пожаловать в мир магии чисел");
        Debug.Log("Выбери число");
        Debug.Log("Ты можешь выбрать не больше: " + max);
        Debug.Log("Ты можешь выбрать не менее: " + min);
        Debug.Log("Скажи пожалуйста твоё число меньше или больше чем" + guess);
        Debug.Log("Нажми вверх = больше, вниз = меньше, нажми Enter = правильно");
        Debug.Log("Изучение возможностей GitHub")

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();   
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Поздравляю ты стал медовой плюшечкой, ням ням ням");
            StartGame();
        }
    
        void NextGuess()
        {
            guess = (max + min) / 2;
            Debug.Log("Твое число выше или ниже чем " + guess);
        }
    }

}
