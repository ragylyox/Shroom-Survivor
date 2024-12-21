using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistol : MonoBehaviour
{

    public GameObject pylaPrefab;    // Префаб кулі
    public Transform shootingPoint;  // Точка, з якої стріляє куля
    public float shootingForce = 500f; // Сила, з якою куля буде відправлена
   

    private void Update()
    {
        // Кнопка для стрільби (можна змінити на будь-яку іншу)
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    // Функція для стрільби
    private void Shoot()
    {
        // Створюємо кулю
        GameObject ball = Instantiate(pylaPrefab, shootingPoint.position,shootingPoint.rotation);

        // Додаємо компонент Rigidbody, якщо його ще немає
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = ball.AddComponent<Rigidbody>();
        }

        // Додаємо силу для руху кулі
        rb.AddForce(shootingPoint.forward * shootingForce);
        Destroy(ball, 10f);
    }
}


