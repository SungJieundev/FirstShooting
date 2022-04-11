using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private Image fadeImage = null;

    void Start()
    {
       fadeImage.DOFade(1f, 1f).SetDelay(1f);
    }

    
    void Update()
    {
        
    }
}
