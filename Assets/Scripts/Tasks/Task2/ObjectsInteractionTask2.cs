using System;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    [SerializeField] 
    private GameObject _lamp;

    
    // TODO: В методе Awake создайте на сцене в точке LampRoot одну из наборов ламп (из папки Prefabs/Lamps)    
    private void Awake()
    {
        
        var position = new Vector3((float)0.08054832, (float)2.37, (float)0.175);
       // var lampRoot = Instantiate(_lamp, position,180);
       Instantiate(_lamp, position, Quaternion.Euler(position)) ;
    }
}