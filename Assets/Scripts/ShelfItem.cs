using UnityEngine;

/// <summary>
/// Класс предмета, падающего на полку
/// </summary>
public class ShelfItem : MonoBehaviour
{
    private Rigidbody _rigidbody;
    
    private void Awake()
    {
        // Получаем компонент объекта Rigidbody (Rigidbody делает объект физичным).
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Если Rigidbody не используется в течение некоторого времени -
        // оно засыпает (на него перестают действовать физические силы) для экономии ресурсов.
        // Вызов WakeUp() гарантирует, что компонент будет активен и готов к использованию в каждом кадре.
        _rigidbody.WakeUp();
    }
}