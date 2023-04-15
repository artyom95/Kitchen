using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    [SerializeField] 
    private Waffle _waffle;
    [SerializeField]
    private Vector3 _position;
    
    

private Toaster _toaster;

    private void Awake()
    {
       
        _toaster = FindObjectOfType<Toaster>();
        
    }

    private void Start()
    {
        _toaster.TimerIsUp += CreateWaffle;
    }

    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 
    private void CreateWaffle()
    {
        Instantiate(_waffle, new Vector3((float)-0.75, (float)1.0, (float)1.10), Quaternion.Euler(-20,-160,0));
    }
}