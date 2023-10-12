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
        Debug.Log("�����!");
        //���� ���� �ʾҴٸ� ü�� ���� ó�� ����
        if (!GameManager.instance.isGameOver)
        {
            // ȭ�� �Ͻ������� �Ӿ��� ȿ��
            UIManager.instance.Attacked();
            // �������ŭ ü�� ����
            playerHP -= damage;
            // HP�� ����
            UIManager.instance.UpdateHealthBar(damage);
            //���� ü���� 0 ���϶��, ���
            if (playerHP <= 0)
            {
                UIManager.instance.GameOver();
                Die();
            }
        }
    }


    // ��� ó��
    private void Die()
    {
        // ��� ���¸� ������ ����
        GameManager.instance.isGameOver = true;
        PlayerMove pm = GetComponent<PlayerMove>();
        pm.playerAnimator.SetTrigger("isDead");
    }
}