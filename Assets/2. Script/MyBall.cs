using UnityEngine;

public class MyBall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) //collision은 충돌체
    {
        Debug.Log(collision.gameObject.name + "와 충돌함");         //이름으로도 접근할 수 있다.

        if (collision.gameObject.tag == "Ground")       //만약 충돌이 일어난 물체의 Tag가 Ground일경우
            {
                Debug.Log("땅과 충돌");         //디버그 로그를 실행.
            }
    }

    private void OnTriggerEnter(Collider other) //other는 오브젝트
    {
        Debug.Log("트리거 안에 들어옴");
    }

    private void OnTriggerExit(Collider other) //other는 오브젝트
    {
        Debug.Log("트리거 밖으로 나감");
    }
}
