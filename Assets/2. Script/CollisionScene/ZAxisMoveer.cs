using UnityEngine;
/// <summary>
/// === | Z축으로 n초 움직임 | ===
/// </summary>
public class ZAxisMoveer : MonoBehaviour
{
    /// <summary>
    /// public | ======================================
    /// </summary>
    public float speed = 5.0f;      //이동 속도
    public float timer = 5.0f;      //타이머 설정

    /// <summary>
    /// private | ======================================
    /// </summary>

    void Update()
    {
        //z축 방향으로 앞으로 이동
        transform.Translate(0, 0, speed * Time.deltaTime);

        timer -= Time.deltaTime;        //시간을 카운트 다운 한다.

        if (timer < 0 )
        {
            Destroy(gameObject);        //자기 자신을 파괴 한다.
        }
    }
}
