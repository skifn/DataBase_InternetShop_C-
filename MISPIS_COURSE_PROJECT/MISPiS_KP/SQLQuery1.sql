CREATE TABLE �����(
	[ID] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[�������] [char](30) NULL,
	[���] [char](30) NULL,
	[�������] [char](20) NULL,
	[�����] [varchar](256) NULL,
	[����] [int] NULL,
	[������] [char](64) NULL
)

CREATE TABLE �������(
	[ID] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[���������] [char](64) NULL,
	[�������������] [char](64) NULL,
	[������] [char](20) NULL,
	[����] [int] NULL,
	[��������] [char](20) NULL,
)

CREATE TABLE ������(
	[ID] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[���������] [char](64) NULL,
	[�������������] [char](64) NULL,
	[������] [char](20) NULL,
	[����] [int] NULL,
	[��������] [char](20) NULL,
)

ALTER TABLE ������
ADD ������������ Char(40)

ALTER TABLE �������
ADD ������������ Char(40)




CREATE TABLE ��������(
	[ID] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[�������] [char](30) NULL,
	[���] [char](30) NULL,
	[�������] [char](20) NULL,
	[�����] [varchar](256) NULL,
	[����] [int] NULL,
	[������] [char](64) NULL,
)

CREATE TABLE ���_������(
[ID] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[�������] [char](30) NULL,
	[���] [char](30) NULL,
	[�������] [char](20) NULL,
	[�����] [varchar](256) NULL,
	[����] [int] NULL,
	[������] [char](64) NULL
)