## Winform Advence

## Project
이전에 배웠던 C#의 내용들을 활용해 책 대여점 홈페이지를 만들어 보았습니다. 회원목록, 책목록과 책의 구분코드를 SqlDB에서 받아와 WinFome과 연동해 관리목록들을 만들었고, 
WinForm의 MetroFrameWork를 사용해 디자인적인 요소를 넣었습니다. 또한 MainForm안에 SubForm, PopupForm을 넣는 등의 다양한 형태의 템플릿을 만들어보았습니다.


-----------

### 1. SQL DB화면

![DB_Image](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_100324_001.png)

만들어 두었던 BookRentalShop의 DB입니다. 이것을 활용해 책대여 프로그램을 만들어 보겠습니다.



### 2. 로그인 화면

![ShopLogin_Image](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_100344_001.png)

프로그램을 열면 가장 먼저 실행되는 로그인 화면입니다. 아이디와 비밀번호를 입력해야 들어갈 수 있으며, 비밀번호는 보안을 위해 PasswordChar를 썼습니다.

![ShopLogin_Images2](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_170322_001.png)

로그인 성공이후 관리 시스템에 접근할 수 있습니다.



### 3. 구분코드 화면

MenuStrip을 활용해 관리부분의 하위 콘텐츠에 구분코드, 회원, 도서, 대여관리의 항목을 추가로 넣었습니다. 구분코드와 이름으로 구성되어있는 형태의 데이터를 넣고 삭제, 저장, 신규 버튼을 넣고 동작하도록 만들었습니다. 


![DivCode_Images_1](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_170324_001.png)
위는 구분코드의 화면입니다. 신규추가, 수정, 삭제들의 기능을 넣어 도서의 종류별 관리를 용이하게 만들었습니다.



아래는 구분코드 추가를 성공한 화면입니다. 프로그래밍 아래에 '자기계발서'라는 항목을 추가했습니다.
![DivCode_Images_2](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_170327_001.png)



항목이 추가된화면입니다.
![DivCode_Images_3](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_170330_001.png)



이번에는 추가했던 자기계발서 항목을 삭제해보았습니다. 
![DivCode_Images_4](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_170352_001.png)



아래는 결과화면입니다.
![DivCode_Images_5](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_170300_001.png)




### 4. 회원관리 화면
회원의 효율적인 관리를위해 GroupBox로 상태라는 그룹을 만들어 그 안에 인덱스, 이름, 레벨, 주소, 아이디, 패스워드 등의 신상정보를 Lable과 TextBox, ComboBox를 사용하여 만들었습니다.
앞의 구분코드와 마찬가지로 DB데이터를 넣고 삭제, 신규, 저장의 버튼을 넣고 동작하게 만들었습니다.


![Memeber_Images_1](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_100325_001.png)
위의 화면은 회원관리 초기화면입니다. 클릭을 하면 회원들의 인적사항이 오늘쪽의 상태그룹에 표시됩니다.


![Memeber_Images_2]()



