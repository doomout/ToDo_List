## 공사중
"개발 공부 및 실사용 목적으로 시작한 개인 프로젝트입니다. 현재는 미완성이며, 추후 리팩토링 및 개선 예정입니다."
## DoToList
1. C# 윈폼으로 개발
2. DB는 PostgreSQL__16 사용
3. Npgsql 패키지 사용(DB 연결)
4. DB 암호화를 위해  pgcrypto 확장 사용
	- CREATE EXTENSION IF NOT EXISTS pgcrypto;

## 테이블 구조 (변경 가능)
1. users 
 - no SERIAL PRIMARY KEY,       -- 고유 ID (자동 증가)
 - id VARCHAR(50) NOT NULL UNIQUE, -- 사용자 이름 (고유, NOT NULL)
 - password VARCHAR(255) NOT NULL -- 비밀번호 (NOT NULL)

2. todo_list 
- id SERIAL PRIMARY KEY,       -- 고유 ID (자동 증가)
- user_id INT NOT NULL,        -- 회원 테이블의 id를 참조
- title VARCHAR(100) NOT NULL, -- 할 일 제목
- description TEXT,            -- 상세 설명 (NULL 허용)
- is_completed BOOLEAN DEFAULT FALSE, -- 완료 여부 (기본값: false)
- created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP, -- 생성 시간
- FOREIGN KEY (user_id) REFERENCES users (no) -- 외래 키 설정

## 화면 구성
1. 로그인 화면  
![1](https://github.com/user-attachments/assets/dac3af9f-9a87-4919-96db-9948442f024e)

2. 회원 가입 화면  
![2](https://github.com/user-attachments/assets/ecdd142d-d2dc-4b0e-a312-986a240379b9)

3. 메인 화면  
![3](https://github.com/user-attachments/assets/e54eca2d-3a0c-490a-a5b9-e9d7ac20069c)

