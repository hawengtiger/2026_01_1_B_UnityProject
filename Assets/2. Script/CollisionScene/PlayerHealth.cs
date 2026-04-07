using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// === | 플레이어 HP | ===
/// </summary>
public class PlayerHealth : MonoBehaviour
{
    /// <summary>
    /// public | ======================================
    /// </summary>

    public int maxLives = 3;        //최대 생명력
    public int curentLives;         //현재 생명력

    public float invincibleTime = 1.0f;     //피격 후 무적 시간 (반복 피격 방지)
    public bool isinvincible = false;       //무적 여부의 값

    /// <summary>
    /// private | ======================================
    /// </summary>

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        curentLives = maxLives;     //생명력 초기화
    }

    private void OnTriggerEnter(Collider other)     //트리거 영역 안에 들어왔나를 검사하는 함수
    {
        if (other.CompareTag("Missile"))            //미사일과 충돌했는가?
        {
            curentLives--;                          //플레이어 목숨 -1
            Destroy(other.gameObject);              //미사일 오브젝트를 없앤다.
        }

        if (curentLives <= 0)                       //만약 체력이 0 이하인가?
        {
            GameOver();                             //종료 함수를 호출 한다.
        }
    }

    /// <summary>
    /// === | 게임 오버 | ===
    /// </summary>
    void GameOver()
    {
        gameObject.SetActive(false);        //플레이어 비활성화
        Invoke("RestartGame", 3.0f);        //3초후 "RestartGame" 함수를 불러옴.
    }

    /// <summary>
    /// === | 게임 재시도 | ===
    /// </summary>
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);     //현재 씬 재시작
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
