using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance; // 싱글턴을 할당할 전역변수
    public bool isGameover = false; // 게임오버상태
    public TextMeshProUGUI scoreText; // 점수를 출력할 UI텍스트
    public GameObject gameoverUI;// 게임오버 시 활성화할 UI오브젝트

    private int score = 0;
    void Awake()
    {
        //싱글턴 변수 instance가 비어있는가?
        if(instance == null)
        {
            //instance가 비어있다면 (null) 그곳에 자기 자신을  할당
            instance = this;
        }
        else
        {
            //instance에 이미 다른 GameManager 오브젝트가 할당되어 있는 경우

            //씬에 두 개 이상의 GameManager 오브젝트가 존재한다는 의미
            //싱글 턴 오브젝트는 하나만 존재해야 하므로 자신으 게임 오브젝트를 파괴
            Debug.LogWarning("씬에 두 개 이상의 게임 매니저가 존재합니다");
            Destroy(gameObject);
        }
    }

   
    void Update()
    {
        //게임오버 상태에서 게임을 재시작 할 수 있게 하는처리
        if(isGameover && Input.GetMouseButtonDown(0))
        {
            //게임오버 상태에서 마우스 왼쪽버튼을 클릭하면 현재 씬 재시작
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
    //점수를 증가시키는 매서드
    public void AddScore(int newScore)
    {
        //게임오버가 아니라면 
        if(!isGameover)
        {
            //점수를 증가
            score = +newScore;
            scoreText.text = "Score:" + score;
        }
    }

    //플레이어 캐릭터 사망 시 게임 오버를 실행하는 매서드
    public void OnPlayerDead()
    {
        isGameover = true;
        gameoverUI.SetActive(true);
    }
}
