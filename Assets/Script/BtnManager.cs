using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnManager : MonoBehaviour
{
    [SerializeField] GameObject MenuPanel;
    Timer timer;

    public bool isMenu = false;
    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        timer = FindObjectOfType<Timer>();
    }
    public void StartBtn()
    {
        // �޴� ȭ��(�������� ���� ȭ��)���� �̵�
        SceneManager.LoadScene("MenuScene");
    }
    
    public void ExitBtn()
    {
        // ���� ���� ��ư
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void Stage_1Btn()
    {
        // �������� 1�� �̵�
        SceneManager.LoadScene("Stage-1");
    }

    public void Stage_2Btn()
    {
        // �������� 1�� �̵�
        SceneManager.LoadScene("Stage-2");
    }

    public void StartSceneBtn()
    {
        // ��ŸƮ ȭ������ �̵�
        SceneManager.LoadScene("StartScene");
    }

    public void GameMenuBtn()
    {
        if (!isMenu)
        {
            // ���� �޴� �ǳ��� ����.
            isMenu = true;
            MenuPanel.SetActive(true);
            timer.StopTimer();
            audioSource.Pause();
        }
        else
        {
            isMenu = false;
            MenuPanel.SetActive(false);
            timer.TimerStart();
            audioSource.Play();
        }
    }
}
