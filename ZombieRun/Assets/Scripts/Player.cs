using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerHP = 10f; // ���� ü�� 
    public float health { get; protected set; }

    void Start()
    {
        // ü���� ����ü������ �ʱ�ȭ
        health = playerHP;
    }

    // ������� �Դ� ���
    public void OnDamage(float damage)
    {
        //���� ���� �ʾҴٸ� ü�� ���� ó�� ����
        if (!GameManager.instance.isGameOver)
        {
            // �������ŭ ü�� ����
            playerHP -= damage;
            //���� ü���� 0 ���϶��, ���
            if (playerHP <= 0)
            {
                Die();
            }
        }
    }


    // ��� ó��
    private void Die()
    {
        // ��� ���¸� ������ ����
        GameManager.instance.isGameOver = true;
    }
}