using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class MyCharacter : MonoBehaviour
{
    public int health = 100; //체력을 선언한다. (변수 정수 포현)
    public float timer = 1.0f; //타이머를 설정한다. (변수 실수 표현)

    void Start()
    {
        health = health + 100; //첫 시작 할때 10의 체력을 추가한다.
    }

    void Update()
    {
        timer = timer - Time.deltaTime; //시간을 매 프레임마다 감소 시킨다. (deltaTime은 프레임간의 시간 간격 의미한다.)

        if (timer <= 0) // 만약 timer의 수치가 0이하로 내려갈 경우
        {
            timer = 1.0f; //다시 1초로 변경 시켜 준다.
            health = health - 20; //1마차 체력이 20 줄어 든다.
        }

        if(Input.GetKeyDown(KeyCode.Space)) //스페이스 키를 눌렀을때
        {
            health = health + 2; //체력 포인트를 2 올려 준다.
        }

        if(health <= 0) //체력이 0 이하가 될 경우
        {
            Destroy(this.gameObject); // 이 오브제그를 없엔다.
        }
    }
}
