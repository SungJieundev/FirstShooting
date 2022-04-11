using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //static, 메모리에 올라갔다가 사라지는데, static을 적어주면 메모리에서 사라지지 않음
    public static UIManager Instance //싱글톤 패턴 get set
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<UIManager>();
            }
            return instance;
        }

    }

    public static UIManager instance;
    public int score = 0;

    public void Plusscore()
    {
        score++;
    }
}
