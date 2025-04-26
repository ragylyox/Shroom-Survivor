using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public AudioClip soundClip;  // �������� ���
    public AudioSource audioSource;  // ��������� AudioSource
    private bool isPlaying = false;  // �������� �� ���� ��� ���

    void Start()
    {
        // �������� ��������� AudioSource
        audioSource = GetComponent<AudioSource>();

        // ����������, �� ���� ��� ����������� � ���������
        if (soundClip != null)
        {
            audioSource.clip = soundClip;
        }
        else
        {
            Debug.LogError("�� ���� ����");
        }
    }

    void Update()
    {
        // ����������, �� ��������� ������ 'W'
        if (Input.GetKey(KeyCode.W) && !isPlaying)
        {
            // ���� ������ ��������� � ���� �� �� ���, �� ���������� ����
            audioSource.Play();
            isPlaying = true;
        }
        // ���� ������ ��������
        else if (!Input.GetKey(KeyCode.W) && isPlaying)
        {
            // ��������� ����
            audioSource.Stop();
            isPlaying = false;
        }
    }
}