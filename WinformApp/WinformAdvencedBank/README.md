## Winform Advence

### Project
이전에 배웠던 C#의 내용들을 활용해 책 대여점 홈페이지를 만들어 보았습니다. 회원목록, 책목록과 책의 구분코드를 SqlDB에서 받아와 WinFome과 연동해 관리목록들을 만들었고, 
WinForm의 MetroFrameWork를 사용해 디자인적인 요소를 넣었습니다. 또한 MainForm안에 SubForm, PopupForm을 넣는 등의 다양한 형태의 템플릿을 만들어보았습니다.


-----------

1. SQL DB화면

[DB_Image](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_100324_001.png)
만들어 두었던 BookRentalShop의 DB입니다. 이것을 활용해 대여프로그램을 만들어 보겠습니다.



2. 로그인 화면

[ShopLogin_Image](https://github.com/zizi0308/StudyDesktopApp/blob/main/images/img_20210319_100344_001.png)
프로그램을 열면 자장 먼저 실행되는 로그인 화면입니다. 아이디와 비밀번호를 입력해야 들어갈 수 있으며 비밀번호는 보안을 위해 PasswordChar를 썼습니다.


3. 초기 프로그램화면

MenuStrip을 활용해 관리부분의 하위 콘텐츠에 구분코드, 회원, 도서, 대여관리의 항목을 추가로 넣었습니다.

