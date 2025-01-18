using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent myAgent; // Агент для пересування
    private float distance; // Відстань до цілі
    public Transform target; // Ціль, наприклад, гравець
    public Animator myAnimator; // Аніматор для ворога

    private float attackCooldown = 1.5f; // Час між атаками
    private float lastAttackTime; // Час останньої атаки

    // Update викликається кожен кадр
    void Update()
    {
        // Розрахунок відстані до цілі
        distance = Vector3.Distance(target.position, transform.position);

        if (distance > 150)
        {
            // Якщо гравець далеко, ворог залишається у стані "Idle"
            myAgent.enabled = false;
            myAnimator.Play("Idle");
        }
        else if (distance <= 150 && distance > 2)
        {
            // Якщо ворог у зоні видимості, пересувається до гравця
            myAgent.enabled = true;
            myAgent.SetDestination(target.position);
            myAnimator.Play("Run");
        }
        else if (distance <= 2)
        {
            // Якщо ворог поруч із гравцем, він атакує
            myAgent.enabled = false;

            // Перевіряємо таймер атак
            if (Time.time - lastAttackTime > attackCooldown)
            {
                PerformRandomAttack(); // Викликаємо випадкову атаку
                lastAttackTime = Time.time; // Оновлюємо час останньої атаки
            }
        }
    }

    private void PerformRandomAttack()
    {
        // Генеруємо випадкове число: 0 або 1
        int randomAttack = Random.Range(0, 2);

        if (randomAttack == 0)
        {
            myAnimator.Play("Attack1"); // Перша анімація атаки
        }
        else
        {
            myAnimator.Play("Attack2"); // Друга анімація атаки
        }
    }
}