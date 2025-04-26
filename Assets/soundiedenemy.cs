using UnityEngine;

public class WolfHealth : MonoBehaviour
{
    public int EnemyHP = 50;              // Здоров'я вовка
    public AudioClip deathSound;          // Звук смерті
    public AudioSource audioSource;      // Компонент для програвання звуку
    public bool isDead = false;          // Перевірка, чи вовк уже помер

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
            // Тут можна також викликати анімацію смерті або знищити об'єкт
        }
    }

    void PlayDeathSound()
    {
        if (deathSound != null)
        {
            audioSource.PlayOneShot(deathSound);
        }
    }

    // Цей метод можна викликати з іншого скрипта, щоб зменшити HP
    public void TakeDamage(int damage)
    {
        EnemyHP += damage;
    }
}
