# Youtube-Downloader 2019 윈도우즈 프로그래밍 프로젝트

<img width="1168" alt="Screen Shot 2022-02-06 at 10 29 56 PM" src="https://user-images.githubusercontent.com/61814500/152683288-33290ecb-9606-4bce-8cee-3bcf03c69f87.png">


* youtube api 사용
* 사용자가 입력한 Video의 정보(이름, 저장경로)를 생성하고 정의하는 Videoclass 생성 
* MyVideo Page에서 ‘Save Your Video Information’ 버튼 클릭시 이벤트 발생 => NewVideoInfo창 띄워서 저장한 정보 넘김 
* NewVideoInfo 창에서 입력된 값들을 Videoclass에 넘겨줌 
* LocationControl에서 Dependency Property로 Videoclass 생성함
* MyVideo Page에서 ListView에 UserControl – LocationControl에서 생성한 Dependency Property-Videoclass를 Binding 해준다.
