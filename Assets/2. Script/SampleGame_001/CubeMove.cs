using UnityEngine;

/// <summary>
/// === | 땅 움직임 | ===
/// </summary>
public class CubeMove : MonoBehaviour
{
    /// <summary>
    /// public | ======================================
    /// </summary>

    public float moveSpeed = 5.0f;      //큐브 이동 속도

    /// <summary>
    /// private | ======================================
    /// </summary>

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -moveSpeed * Time.deltaTime);      //z축 마이너스 방향으로 이동

        if(transform.position.z < -20)      //큐브가 z축 -20 이하로 갔는지 확인
        {
            Destroy(gameObject);            //자기 자신 제거
        }
    }
}
