## DoToList
1. C# �������� ����
2. DB�� PostgreSQL__16 ���

## ���̺� ���� (���� ����)
1. users 
 - id SERIAL PRIMARY KEY,       -- ���� ID (�ڵ� ����)
 - username VARCHAR(50) NOT NULL UNIQUE, -- ����� �̸� (����, NOT NULL)
 - password VARCHAR(255) NOT NULL -- ��й�ȣ (NOT NULL)

2. todo_list 
- id SERIAL PRIMARY KEY,       -- ���� ID (�ڵ� ����)
- user_id INT NOT NULL,        -- ȸ�� ���̺��� id�� ����
- title VARCHAR(100) NOT NULL, -- �� �� ����
- description TEXT,            -- �� ���� (NULL ���)
- is_completed BOOLEAN DEFAULT FALSE, -- �Ϸ� ���� (�⺻��: false)
- created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP, -- ���� �ð�
- FOREIGN KEY (user_id) REFERENCES users (id) -- �ܷ� Ű ����