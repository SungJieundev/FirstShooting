using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //static, �޸𸮿� �ö󰬴ٰ� ������µ�, static�� �����ָ� �޸𸮿��� ������� ����
    public static UIManager Instance //�̱��� ���� get set
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
