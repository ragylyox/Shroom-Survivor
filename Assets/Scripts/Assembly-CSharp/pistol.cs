using UnityEngine;

public class pistol : MonoBehaviour
{
    public GameObject pylaPrefab;
    public Transform shootingPoint;
    public float shootingForce = 500f;
    public AudioSource audioSource;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        // ��������� ������
        GameObject projectile = Instantiate(pylaPrefab, shootingPoint.position, shootingPoint.rotation);

        // ������ ������
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = projectile.AddComponent<Rigidbody>();
        }
        rb.AddForce(shootingPoint.forward * shootingForce);

        // ������� ����� 10 ������
        Destroy(projectile, 10f);

        // �������� ���� �������
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }

       
    }
}
