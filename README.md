이름: 버튼 잡기
##개요
-c# 프로그래밍 학습
-핵심기능: 버튼 도망(하지만 창 밖으로 나가지 않음),
-화면 구성:

스크린샷
1단계 스크린 샷



<img width="789" height="462" alt="image" src="https://github.com/user-attachments/assets/205091e4-46b8-44f3-b6e4-a9fdb3a60d43" />


기본 화면



2단계 스크린 샷

<img width="830" height="484" alt="image" src="https://github.com/user-attachments/assets/532dd83b-3f7a-48a7-a028-271b2a28468d" />



3단계 스크린 샷
(점수 구현)


점수 표시를 했음에도 폼 화면에 점수가 나오지 않음 - 좌표 표시가 점수 표시 화면을 가림

<img width="774" height="473" alt="image" src="https://github.com/user-attachments/assets/91b18232-e7bf-485a-9281-a04674aa2075" />


좌표 표시 코드를 지웠더니 정상 작동함

<img width="779" height="464" alt="image" src="https://github.com/user-attachments/assets/c83585f3-e5d3-47fc-a3a4-c386b462d3b5" />


(난이도 조절)

<img width="773" height="471" alt="image" src="https://github.com/user-attachments/assets/c38db562-fb6e-442f-b629-51a7228c766f" />



4 단계 스크린 샷

<img width="794" height="481" alt="image" src="https://github.com/user-attachments/assets/fb6f7b79-d9a3-417f-93df-7efdecd395a2" />

<img width="787" height="475" alt="image" src="https://github.com/user-attachments/assets/602c72a3-e42f-4677-8886-fef753dc2ec6" />


구현 시 어려웠던 점

버튼 간의 상호 작용과
다른 버튼 들이 내가 원하고자 하는 버튼을 가려버리는 것을 처리하는 것이 힘들었다
다시시작 키를 눌렀을 때 다시시작 키가 사라지지 않았다.
-다시시작 키는 처음 만들었을 때 false 값으로 보이지 않게 만들고 "game over"상태 때 보이는 ture 상태로 나온 것이 false 값으로 다시 
돌아가지 않아서 생긴 문제였다.


