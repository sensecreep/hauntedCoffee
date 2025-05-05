using UnityEngine;
using System.Collections;

public class SequentialImageDisplay : MonoBehaviour
{
    [Header("���������")]
    public GameObject[] images; // ������ �� 3 �����������
    public float stepDelay = 0.85f; // �������� ����� ������

    private int currentStep = 0;

    void Start()
    {
        // �������� ������� �����������
        if (images == null || images.Length != 3)
        {
            Debug.LogError("��������� ����� 3 �����������!");
            return;
        }

        // ��������� ��� ����������� ��� ������
        SetAllImages(false);

        // ��������� ����
        StartCoroutine(ImageSequence());
    }

    IEnumerator ImageSequence()
    {
        while (true)
        {
            switch (currentStep)
            {
                case 0: // ������ ������� - 1 �����������
                    SetImageState(0, true);
                    SetImageState(1, false);
                    SetImageState(2, false);
                    break;

                case 1: // ������ ������� - 2 �����������
                    SetImageState(0, true);
                    SetImageState(1, true);
                    SetImageState(2, false);
                    break;

                case 2: // ������ ������� - 3 �����������
                    SetImageState(0, true);
                    SetImageState(1, true);
                    SetImageState(2, true);
                    break;

                case 3: // ��������� ������� - ��� ���������
                    SetAllImages(false);
                    break;
            }

            // ���� ��������� �����
            yield return new WaitForSeconds(stepDelay);

            // ��������� � ���������� ����
            currentStep = (currentStep + 1) % 4;
        }
    }

    void SetAllImages(bool state)
    {
        foreach (var img in images)
        {
            if (img != null) img.SetActive(state);
        }
    }

    void SetImageState(int index, bool state)
    {
        if (index >= 0 && index < images.Length && images[index] != null)
        {
            images[index].SetActive(state);
        }
    }
}
