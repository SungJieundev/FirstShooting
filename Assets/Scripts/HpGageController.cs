using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpGageController : MonoBehaviour
{
    public Image hpGage;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy")) //player 가 Enemy와 충돌하면 DecreaseHp
        {
            
            {
                
                DecreaseHp();
            }
        }
    }


    public void DecreaseHp()
    {   
        hpGage.fillAmount -= 0.2f;

    }
}
