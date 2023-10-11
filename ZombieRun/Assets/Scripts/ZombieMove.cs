using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieMove : MonoBehaviour
{
    private GameObject target;
    private NavMeshAgent pathFinder;
    private Animator zombieAnimator;

    void Start()
    {

        //�׽�Ʈ ���� �ڷ�ƾ�� ���⼭ ������׽��ϴ�.
        ////���� ��1���� ���� ȹ�� �� Ȱ��ȭ�ǵ��� ���� ����
        target = GameObject.FindWithTag("Player");
        pathFinder = GetComponent<NavMeshAgent>();
        zombieAnimator = GetComponent<Animator>();
        StartCoroutine(UpdatePath());
    }

    private void OnEnable()
    {
/*        target = GameObject.FindWithTag("Player");
        pathFinder = GetComponent<NavMeshAgent>();
        zombieAnimator = GetComponent<Animator>();
        StartCoroutine(UpdatePath());*/
    }

    private IEnumerator UpdatePath()
    {
        zombieAnimator.SetBool("isWalk", true);
        while (!GameManager.instance.isGameOver)
        {
            pathFinder.isStopped = false;
            pathFinder.SetDestination(target.transform.position);
            
            yield return new WaitForSeconds(0.25f);
        }

        pathFinder.isStopped = true;
        zombieAnimator.SetBool("isWalk", false);
    }
}
