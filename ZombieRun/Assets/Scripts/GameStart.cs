using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{

    // ���� ���� ��ư Ŭ��, ���� Scene �ε�
    public void LoadMain()
    {
        SceneManager.LoadScene("Main");
    }
}
