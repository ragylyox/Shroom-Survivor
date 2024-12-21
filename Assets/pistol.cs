using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistol : MonoBehaviour
{

    public GameObject pylaPrefab;    // ������ ���
    public Transform shootingPoint;  // �����, � ��� ������ ����
    public float shootingForce = 500f; // ����, � ���� ���� ���� ����������
   

    private void Update()
    {
        // ������ ��� ������� (����� ������ �� ����-��� ����)
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    // ������� ��� �������
    private void Shoot()
    {
        // ��������� ����
        GameObject ball = Instantiate(pylaPrefab, shootingPoint.position,shootingPoint.rotation);

        // ������ ��������� Rigidbody, ���� ���� �� ����
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = ball.AddComponent<Rigidbody>();
        }

        // ������ ���� ��� ���� ���
        rb.AddForce(shootingPoint.forward * shootingForce);
        Destroy(ball, 10f);
    }
}


