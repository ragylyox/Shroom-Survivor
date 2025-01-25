using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent myAgent; // ����� ��� �����������
    private float distance; // ³������ �� ���
    public Transform target; // ֳ��, ���������, �������
    public Animator myAnimator; // ������� ��� ������

    private float attackCooldown = 1.5f; // ��� �� �������
    private float lastAttackTime; // ��� �������� �����

    // Update ����������� ����� ����
    void Update()
    {
        // ���������� ������ �� ���
        distance = Vector3.Distance(target.position, transform.position);

        if (distance > 150)
        {
            // ���� ������� ������, ����� ���������� � ���� "Idle"
            myAgent.enabled = false;
            myAnimator.Play("Idle");
        }
        else if (distance <= 150 && distance > 2)
        {
            // ���� ����� � ��� ��������, ������������ �� ������
            myAgent.enabled = true;
            myAgent.SetDestination(target.position);
            myAnimator.Play("Run");
        }
        else if (distance <= 2)
        {
            // ���� ����� ����� �� �������, �� �����
            myAgent.enabled = false;

            // ���������� ������ ����
            if (Time.time - lastAttackTime > attackCooldown)
            {
                PerformRandomAttack(); // ��������� ��������� �����
                lastAttackTime = Time.time; // ��������� ��� �������� �����
            }
        }
    }

    private void PerformRandomAttack()
    {
        // �������� ��������� �����: 0 ��� 1
        int randomAttack = Random.Range(0, 2);

        if (randomAttack == 0)
        {
            myAnimator.Play("Attack1"); // ����� ������� �����
        }
        else
        {
            myAnimator.Play("Attack2"); // ����� ������� �����
        }
    }
}