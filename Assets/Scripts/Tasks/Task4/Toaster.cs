using System;
using UnityEngine;

public class Toaster : MonoBehaviour
{
    // TODO: Создайте событие TimerIsUp и вызывайте его, когда таймер вышел
    public  Action TimerIsUp;
    public float Timer { get; private set; } = 10; // Таймер готовности вафли
    private bool _isTimerUp; 

    private void Update()
    {
        // Если таймер вышел - выходим из метода
        if (_isTimerUp)
        {
           
            return;
        }
        
        // Если таймер не вышел
        if (Timer > 0)
        {
            // Отнимаем время, прошедшее за кадр
            Timer -= Time.deltaTime;
        }
        else
        {
            // Таймер вышел
            _isTimerUp = true;
            TimerIsUp.Invoke();
           
           
        }
    }
}