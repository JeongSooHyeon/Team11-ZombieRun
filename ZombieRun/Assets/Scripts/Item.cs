using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int ItemNum; //GameManager.EItem ����

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameManager.instance.inventory[ItemNum] = true;   //�κ��丮�� �߰�
            gameObject.SetActive(false);                  //������Ʈ ��Ȱ��ȭ
            //todo: �ش� ������ ui Ȱ��ȭ
        }
    }
}
