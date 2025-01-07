## DoToList
1. C# 윈폼으로 개발
2. DB는 PostgreSQL__16 사용

## 테이블 구조 (변경 가능)
1. users 
 - id SERIAL PRIMARY KEY,       -- 고유 ID (자동 증가)
 - username VARCHAR(50) NOT NULL UNIQUE, -- 사용자 이름 (고유, NOT NULL)
 - password VARCHAR(255) NOT NULL -- 비밀번호 (NOT NULL)

2. todo_list 
- id SERIAL PRIMARY KEY,       -- 고유 ID (자동 증가)
- user_id INT NOT NULL,        -- 회원 테이블의 id를 참조
- title VARCHAR(100) NOT NULL, -- 할 일 제목
- description TEXT,            -- 상세 설명 (NULL 허용)
- is_completed BOOLEAN DEFAULT FALSE, -- 완료 여부 (기본값: false)
- created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP, -- 생성 시간
- FOREIGN KEY (user_id) REFERENCES users (id) -- 외래 키 설정