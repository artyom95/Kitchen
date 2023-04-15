using System;
using TMPro;
using UnityEngine;

/// <summary>
/// Класс, отвечающий за отображение таймера на UI
/// </summary>
public class TimerView : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _timerLabel;
    [SerializeField] 
    private Toaster _toaster;

    private void Update()
    {
        var currentTimer = _toaster.Timer;
        _timerLabel.text = String.Format("{0:0}", currentTimer);
    }
}