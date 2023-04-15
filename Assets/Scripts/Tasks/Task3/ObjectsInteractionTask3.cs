using System;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
   
    private Lamp[] _bulbs;
    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact

    private void Awake()
    {
        _bulbs = FindObjectsOfType<Lamp>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            foreach (var bulb in _bulbs)
            {
                bulb.Interact();
            }
        }
    }
}