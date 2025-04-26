using UnityEngine;

public class WolfHealth : MonoBehaviour
{
    public int EnemyHP = 50;              // ������'� �����
    public AudioClip deathSound;          // ���� �����
    public AudioSource audioSource;      // ��������� ��� ����������� �����
    public bool isDead = false;          // ��������, �� ���� ��� �����

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (deathSound == null)
        {
            Debug.LogWarning("deathSound");
        }
    }

    void Update()
    {
        if (EnemyHP <= 0 && !isDead)
        {
            PlayDeathSound();
            isDead = true;
            // ��� ����� ����� ��������� ������� ����� ��� ������� ��'���
        }
    }

    void PlayDeathSound()
    {
        if (deathSound != null)
        {
            audioSource.PlayOneShot(deathSound);
        }
    }

    // ��� ����� ����� ��������� � ������ �������, ��� �������� HP
    public void TakeDamage(int damage)
    {
        EnemyHP += damage;
    }
}
