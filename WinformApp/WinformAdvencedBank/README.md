## Winform Advence

## Project
이전에 배웠던 C#의 내용들을 활용해 책 대여점 홈페이지를 만들어 보았습니다. 회원목록, 책목록과 책의 구분코드를 SqlDB에서 받아와 WinFome과 연동해 관리목록들을 만들었고, 
WinForm의 MetroFrameWork를 사용해 디자인적인 요소를 넣었습니다. 또한 MainForm안에 SubForm, PopupForm을 넣는 등의 다양한 형태의 템플릿을 만들어보았습니다.


-----------
<br/>
### 1. SQL DB화면

![DB_Image](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_100324_001.png)

만들어 두었던 BookRentalShop의 DB입니다. 이것을 활용해 책대여 프로그램을 만들어 보겠습니다.

<br/>
<br/>
### 2. 로그인 화면
<br/>
![ShopLogin_Image](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_100344_001.png) <br/>
프로그램을 열면 가장 먼저 실행되는 로그인 화면입니다. 아이디와 비밀번호를 입력해야 들어갈 수 있으며, 비밀번호는 보안을 위해 PasswordChar를 썼습니다.
<br/>
![ShopLogin_Images2](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_170322_001.png)
<br/>
로그인 성공이후 관리 시스템에 접근할 수 있습니다.

<br/>
<br/>
### 3. 구분코드 화면

MenuStrip을 활용해 관리부분의 하위 콘텐츠에 구분코드, 회원, 도서, 대여관리의 항목을 추가로 넣었습니다. 구분코드와 이름으로 구성되어있는 형태의 데이터를 넣고 삭제, 저장, 신규 버튼을 넣고 동작하도록 만들었습니다. 

<br/>
![DivCode_Images_1](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_170324_001.png)
<br/>
위는 구분코드의 화면입니다. 신규추가, 수정, 삭제들의 기능을 넣어 도서의 종류별 관리를 용이하게 만들었습니다.


<br/>
![DivCode_Images_2](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_170327_001.png)
<br/>
위는 구분코드 추가를 성공한 화면입니다. 프로그래밍 아래에 '자기계발서'라는 항목을 추가했습니다.


<br/>
![DivCode_Images_3](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_170330_001.png)
<br/>
항목이 추가된화면입니다.


 <br/>
![DivCode_Images_4](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_170352_001.png)
<br/>
이번에는 추가했던 자기계발서 항목을 삭제해보았습니다.


<br/>
![DivCode_Images_5](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_170300_001.png)
<br/>
아래는 결과화면입니다.


<br/>
<br/>
### 4. 회원관리 화면
회원의 효율적인 관리를위해 GroupBox로 상태라는 그룹을 만들어 그 안에 인덱스, 이름, 레벨, 주소, 아이디, 패스워드 등의 신상정보를 Label과 TextBox, ComboBox를 사용하여 만들었습니다.
앞의 구분코드와 마찬가지로 DB데이터를 넣고 삭제, 신규, 저장의 버튼을 넣고 동작하게 만들었습니다.

<br/>
![Memeber_Images_1](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_100325_001.png)
<br/>
위의 화면은 회원관리 초기화면입니다. 클릭을 하면 회원들의 인적사항이 오른쪽의 상태그룹에 표시됩니다.


<br/>
![Memeber_Images_2](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_180330_001.png)
<br/>
위의 화면은 새로운 회원을 추가해 저장한 모습입니다.


<br/>
![Memeber_Images_3](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_180354_001.png)
<br/>
결과화면입니다. 27번째 인덱스에 '홍길동'이 추가되었습니다.

<br/>
<br/>
### 5. 책관리 화면
책관리를 용이하게 하기위해 GroupBox로 책의 정보를 그룹화하여 그 안에 인덱스, 저자, 장르, 도서명, 출판일 등의 책정보를 Label과 TextBox, ComboBox, DateTimePicker를 사용하여 만들었습니다.
앞의 회원관리와 마찬가지로 DB데이터를 넣고 삭제, 신규, 저장의 버튼을 넣고 동작하게 만들었습니다.


<br/>
![Book_Images_1](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_100315_001.png)
<br/>
위의 화면은 책관리 초기화면입니다. 클릭을 하면 책의 정보들이 오른쪽의 상태그룹에 표시됩니다.


<br/>
![Book_Images_2](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_180304_001.png)
<br/>
위의 화면은 '홍길동자서전'이라는 책을 추가하고 저장한 화면입니다.


<br/>
![Book_Images_3](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_180357_001.png)
<br/>
책 추가 결과화면입니다. 62번째 인덱스에 '홍길동자서전'이 추가되었습니다.

<br/>
이번에는 책의 상태를 수정해보겠습니다.
<br/>
![Book_Images_4](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_180354_002.png)
<br/>
41번째 책인 '대나무가 우는 꿈'의 이름과 장르, 설명을 수정해보겠습니다.

<br/>
![Book_Images_5](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_180308_001.png)
<br/>
수정 후 저장에 성공했습니다. 이제 결과화면을 보겠습니다.

<br/>
![Book_Images_6](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_180339_001.png)
<br/>
결과화면입니다. '대나무가 우는 꿈'의 이름을 'C# 잘하는 법'으로 장르는 '프로그래밍'으로 바뀐결과를 확인할 수 있습니다.

<br/>
<br/>

### 5. 대여관리
대여관리를 용이하게 하기위해 GroupBox로 대여정보를 그룹화하여 그 안에 인덱스, 대여회원, 도서명, 대여일, 반납일, 대여상태를 Label과 TextBox, ComboBox, DateTimePicker를 사용하여 만들었습니다. 앞의 책관리와 마찬가지로 DB데이터를 넣고 삭제, 신규, 저장의 버튼을 넣고 동작하게 만들었습니다. 또한, 대여회원과 도서명에 검색버튼을 넣어 클릭하면 책과 회원의 리스트 정보를 담고있는 팝업창을 만들어 프로그램을 좀 더 사용하기 쉽게 만들었습니다. 
<br/>

![Rental_PopupImages_1](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_180300_001.png)
<br/>
(회원리스트 팝업창)
<br/>
![Rental_PopupImages_2](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_180357_002.png)
<br/>
(책리스트 팝업창)

<br/>

![Rental_Images_1](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_180348_001.png)
<br/>
'홍길동'을 책 대여리스트에 추가한 후 저장에 성공한 모습입니다.
<br/>

![Rental_Images_2](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_180328_001.png)
<br/>
결과화면입니다. 20번째 인덱스에 홍길동이 대여중으로 추가된 것을 확인할 수 있습니다.
<br/>

<br/>
### 6. 그 외
<br/>
그 외에도 Sql쿼리문 작성, Sql Injection에 대한 Secure Code작성, 빈값에 대한 처리 메세지나 회원들의 접속 기록 등 다양한 기능들을 활용해 보았습니다. 자세한 내용은 BookRentalShop의 소스코드를 참고해주세요! 긴 글 봐주셔서 감사합니다.😉
















