using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //�̱��� ����
    private static GameManager _instance;
    public static GameManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
            }
            return _instance;
        }
    }

    public bool isGameOver = false; //���� ������ �Ǹ� true

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
