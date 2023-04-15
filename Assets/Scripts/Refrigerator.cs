using UnityEngine;

public class Refrigerator : MonoBehaviour
{
    private Animator _animator;
    private bool _isOpen;

    private void Awake()
    {
        // Получаем компонент аниматор
        _animator = GetComponent<Animator>();
    }

    public void Interact()
    {
        // Меняем флаг на противоположное значение
        _isOpen = !_isOpen;
        
        // Передаем значение флага в аниматор
        // (в зависимости от него будет проиграна анимация открытия или закрытия двери холодильника)
        _animator.SetBool("isOpen", _isOpen);
    }
}
