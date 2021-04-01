# RPG 게임

Unity에서 C++을 사용해 RPG 게임 만들기

- Game
- C++


## 3D quest
스테이지별로 1분 내에 정해진 퀘스트를 수행하는 게임이다.
스테이지를 거듭할수록 퀘스트의 난이도가 올라간다.
화살표/스페이스키를 이용해 플레이어를 조작해 장애물을 피해 시간 내에 퀘스트를 수행해야 한다.


- [3D quest](https://github.com/hyejeong99/Game/tree/master/Unity) -RPG Game

## 코드 설명 
게임이 시작되면 시간이 흘러가고, 1분 내에 장애물을 피해 골 지점에 도달해야 한다. 시간이 지나면 게임이 종료된다.
각 스테이지 별로 퀘스트 또한 수행해야 다음 스테이지로 넘어갈 수 있다. 퀘스트를 수행하면 retry로 다시 게임을 진행할 수 있고, Nextstage로 다음 스테이지로 넘어갈 수 있다.

#### STAGE 01
![stage1](https://user-images.githubusercontent.com/59854960/113237104-32a67a00-92e1-11eb-96cc-712641e65d58.png)

START 버튼을 누르면 게임이 시작된다.

![stage1-1](https://user-images.githubusercontent.com/59854960/113237105-34703d80-92e1-11eb-9043-1519b8af71d3.png)

시간 내에 도착 지점에 도달하면 다음 스테이지로 넘어가거나 재도전할 수 있다.

#### STAGE 02
![stage2](https://user-images.githubusercontent.com/59854960/113237205-65507280-92e1-11eb-9373-6d75576dc3b6.png)

START 버튼을 눌러서 게임을 시작한다. 

![stage2-1](https://user-images.githubusercontent.com/59854960/113237208-66819f80-92e1-11eb-9b0b-647373f6ff51.png)

1분 내에 아이템을 먹어 100점 이상을 획득해야 한다.
퀘스트를 수행하면 retry로 다시 게임을 진행할 수 있고, 
Nextstage로 다음 스테이지로 넘어갈 수 있다.
 
