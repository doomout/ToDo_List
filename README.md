## DoToList
1. C# �������� ����
2. DB�� PostgreSQL__16 ���
3. Npgsql ��Ű�� ���(DB ����)
4. DB ��ȣȭ�� ����  pgcrypto Ȯ�� ���
	- CREATE EXTENSION IF NOT EXISTS pgcrypto;

## ���̺� ���� (���� ����)
1. users 
 - no SERIAL PRIMARY KEY,       -- ���� ID (�ڵ� ����)
 - id VARCHAR(50) NOT NULL UNIQUE, -- ����� �̸� (����, NOT NULL)
 - password VARCHAR(255) NOT NULL -- ��й�ȣ (NOT NULL)

2. todo_list 
- id SERIAL PRIMARY KEY,       -- ���� ID (�ڵ� ����)
- user_id INT NOT NULL,        -- ȸ�� ���̺��� id�� ����
- title VARCHAR(100) NOT NULL, -- �� �� ����
- description TEXT,            -- �� ���� (NULL ���)
- is_completed BOOLEAN DEFAULT FALSE, -- �Ϸ� ���� (�⺻��: false)
- created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP, -- ���� �ð�
- FOREIGN KEY (user_id) REFERENCES users (no) -- �ܷ� Ű ����

## ȭ�� ����
1. �α��� ȭ��  
![1](https://github.com/user-attachments/assets/dac3af9f-9a87-4919-96db-9948442f024e)

2. ȸ�� ���� ȭ��  
![2](https://github.com/user-attachments/assets/ecdd142d-d2dc-4b0e-a312-986a240379b9)

3. ���� ȭ��  
![3](https://github.com/user-attachments/assets/e54eca2d-3a0c-490a-a5b9-e9d7ac20069c)

