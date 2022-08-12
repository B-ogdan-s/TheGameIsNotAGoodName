using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PauseMenuUI : MonoBehaviour
{
    private Canvas _canvas;

    private void Start()
    {
        _canvas = GetComponent<Canvas>();
        _canvas.enabled = false;
    }
    public void OpenPause()
    {
        _canvas.enabled = true;
    }
    public void ClosePause()
    {
        _canvas.enabled = false;
    }
}
