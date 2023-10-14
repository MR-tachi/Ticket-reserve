create table Employee1(
E_id int not null primary  key,
E_name varchar(50) not null,
Email_id varchar(30) check(Email_id like'%@%.%'),
Phone_no varchar(12) not null check(Phone_no like'0%'),
Addrees varchar(100),
fk_T_id int,
foreign  key (fk_T_id) references Theatre(T_id)
on update  cascade on delete cascade,
);

create table Theatre(
T_id int not null primary key,
T_name varchar(30) not null, 
T_location varchar(100),
);


create table Ticket(
Tichet_no int not null  primary key, 
Show_date date not null ,
Seat_no int not null,
Price int not null,
Hall_no int not null,
Booking_data date,

 fk_C_id int,
foreign key(fk_C_id)references Customer(C_id),

fk_Th_id int ,
foreign key (fk_Th_id) references Theatre(T_id)
on update  cascade on delete cascade,

fk_Show_id int,
foreign key (fk_Show_id) references Show(Show_id)
on update  cascade on delete cascade,

fk_E_id int,
foreign key (fk_E_id) references Employee1(E_id)
);



create table Show(
Show_id int primary key not null,
St_time time not null,
End_time time not null,
check(St_time<End_time),

fk_M_id int
foreign key (fk_M_id) references Movie(M_id)
on update  cascade on delete cascade,

fk_D_id int
foreign key (fk_D_id) references Drama(D_id)
on update  cascade on delete cascade,
);
create table Movie(
M_id int not null primary key,
M_name varchar(40) not null,
genre varchar(30),
Ratting int check(Ratting>=1 and Ratting<=10),
);
create table Drama(
D_id int not null primary key,
D_name varchar(40) not null,
D_Type varchar(30),
);

create table Customer(
C_id int not null primary key,
C_name varchar(50) not null, 
Email_id varchar(30) check(Email_id like'%@%.%'),
);


create proc Mycustomer @c_id int,@c_name varchar(50),@email_id varchar(30)
as
begin
insert into Customer(C_id,C_name,Email_id)values(@c_id,@c_name,@email_id)
end
go


create proc pymovie @m_id int,@m_name varchar(40),@genrec varchar(30),@ratting int
as
begin
insert into Movie(M_id,M_name,genre,Ratting) values(@m_id,@m_name,@genrec,@ratting)
end
go

create proc pydrama @d_id int,@d_name varchar(40),@type varchar(30)
as
begin
insert into Drama(D_id,D_name,D_Type) values(@d_id,@d_name,@type)
end
go


create trigger Mytrigg
on Ticket
after insert
as
begin 
print 'You Have Added New item';
end

drop trigger mytrigg


