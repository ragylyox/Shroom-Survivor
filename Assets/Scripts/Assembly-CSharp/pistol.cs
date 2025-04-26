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
        // Створюємо снаряд
        GameObject projectile = Instantiate(pylaPrefab, shootingPoint.position, shootingPoint.rotation);

        // Додаємо фізику
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = projectile.AddComponent<Rigidbody>();
        }
        rb.AddForce(shootingPoint.forward * shootingForce);

        // Знищити через 10 секунд
        Destroy(projectile, 10f);

        // Програти звук пострілу
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }

       
    }
}
