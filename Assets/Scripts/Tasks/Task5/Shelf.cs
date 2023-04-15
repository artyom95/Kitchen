using System;
using UnityEngine;

public class Shelf : MonoBehaviour
{
    // TODO: Вызовите событие ItemSpawned в необходимом месте
    
    public Action ItemSpawned;
    public int ItemsCount { get; private set; }

    [SerializeField]
    private GameObject[] _items; // Объекты, падающие на полку
    [SerializeField]
    private Transform _itemsRoot; // Родительский объект для падающих объектов
    [SerializeField]
    private float _spawnInterval; // Интервал между спавном падающих объектов
    
    [SerializeField]
    private Animator _animator;
    private float _timer;
    
    private void Awake()
    {
        InstantiateShelfItem();
    }

   

    private void Update()
    {
       
        // Увеличиваем таймер каждый кадр
        _timer += Time.deltaTime;

        // Если прошло достаточно времени, создаем новый объект и сбрасываем таймер
        if (_timer >= _spawnInterval)
        {
            InstantiateShelfItem();
            
            _timer = 0f;
        }
    }

    private void InstantiateShelfItem()
    {
        // Если все объекты уже созданы - выходим из метода
        if (ItemsCount >= _items.Length)
        {
            ItemSpawned.Invoke();
            return;
        }
       
        Instantiate(_items[ItemsCount++], _itemsRoot);
    }
    
    public void Fall()
    {
        // Включаем анимацию падения полки
        _animator.enabled = true;
    }
}