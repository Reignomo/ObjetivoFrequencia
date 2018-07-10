
use objetivo;

create table Alunos(
Matricula varchar(6) primary key,
Nome_aluno varchar(150)
);

create table Apontamento (
PK_Matricula varchar(6) not null,
FOREIGN KEY (PK_Matricula) REFERENCES Alunos(Matricula),
status_apontamento varchar(7) not null,
dia varchar(2) not null,
mes varchar(2) not null,
ano varchar(4) not null,
hora varchar(2) not null,
minuto varchar(2) not null,
segundo varchar(2) not null,
tipo varchar(12) not null
);