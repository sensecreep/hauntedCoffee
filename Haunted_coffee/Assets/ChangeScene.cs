using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    [Header("���������")]
    public string menuSceneName = "StartMenu"; // ��� ����� ����
    public string targetSceneName = "Loading"; // ����� ��� �������� ���� ������

    void Update()
    {
        // ��������� ������� ����� � ������� Esc
        if (SceneManager.GetActiveScene().name == targetSceneName && Input.GetKeyDown(KeyCode.Escape))
        {
            ReturnToMainMenu();
        }
    }

    public void ReturnToMainMenu()
    {
        // �������� ����� ����
        SceneManager.LoadScene(menuSceneName);

        // �������������: ������������ ������ (���� ��� ������������)
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // ��������� ������� (���� ���� �����)
        Time.timeScale = 1f;
    }
}