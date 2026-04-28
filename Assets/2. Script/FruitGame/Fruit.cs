using UnityEngine;

/// <summary>
/// === | 수박 게임 과일 | ===
/// </summary>
public class Fruit : MonoBehaviour
{

    /// <summary>
    ///| public 변수 | ======================================
    /// </summary>
    
    public int fruitType;               //과일 (0 : 사과, 1 : 블루베리, 2 : 코코넛) int 로 index 설정

    public bool hasMerged = false;      //과일이 합쳐졌는지 확인하는 플래그

    /// <summary>
    ///| private 변수 | ======================================
    /// </summary>

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasMerged) return;          //이미 합쳐진 과일은 무시

        Fruit otherFruit = collision.gameObject.GetComponent<Fruit>();      //다른 과일과 충돌 했는지 확인

        if (otherFruit != null && !otherFruit.hasMerged && otherFruit.fruitType == fruitType)       //충돌한 것이 과일이고 타입이 같다면(합쳐지지 않았을 경우)
        {
            hasMerged = true;       //합쳐짐 표시
            otherFruit.hasMerged = true;

            Vector3 mergePosition = (transform.position + otherFruit.transform.position) / 2f;      //두 과일의 중간 위치 계산

            //게임 매니저에서 Merge 구현 된 것을 호출 (아직 미구현)
            FruitGame gameManager = FindAnyObjectByType<FruitGame>();
            if (gameManager != null)
            {
                gameManager.MergeFruits(fruitType, mergePosition);
            }


            //과일들 제거
            Destroy(otherFruit.gameObject);
            Destroy(gameObject);
        }
    }
}
