drop database if exists carroDB;
CREATE DATABASE if not EXISTS carroDB;
use carroDB;

create table tbCarro
(
       Brand_Carro text not null,
       Nome_Carro text not null,
       Placa_Carro varchar(7) not null primary key,
       Cor_Carro text not null,
       Preco_Carro decimal not null,
	   Disponivel_Carro char(1) default "s"
);  
 

select * from tbCarro;

create table if not exists tbAluguel(
	ID_Aluguel integer primary key auto_increment,
	Data_Inicial date not null,
	Data_Final date not null,
    Cliente_nome text not null,
    Cliente_CPF text not null,
	Placa_Carro varchar(7) not null,
        
	constraint fk_placa foreign key (Placa_Carro) REFERENCES tbCarro (Placa_Carro)
);
select * from tbAluguel;

truncate tbAluguel;



