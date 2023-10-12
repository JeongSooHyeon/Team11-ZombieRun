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
    public GameObject CameraSet;

    public enum EItem{
        Key1,       //0
        Key2,       //1
        ExitKey,    //2
        Ring        //3
    }
    public bool[] inventory = new bool[4];


    private void Start()
    {
        for(int i=0; i< inventory.Length; i++)
        {
            inventory[i] = false;
        }
    }

    void Update()
    {
        if (isGameOver)
        {
            CameraSet.SetActive(true);
        }
    }
}
