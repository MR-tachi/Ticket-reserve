insert into Theatre values(20,'Shahr','Tehran')
insert into Theatre values(30,'Central','Arak')
insert into Theatre values(40,'Shadi','Shiraz')
insert into Theatre values(50,'HarbezhiKord','Songhor')
insert into Theatre values(60,'arakth','markazi')



insert into Movie values(300,'Inception','sci-fi',8)
insert into Movie values(301,'Skyfall','action',6)
insert into Movie values(302,'Forestgump','advanture',9)
insert into Movie values(303,'Marmolak','Comedy',10)
insert into Movie values(304,'fightClub','Drama',9)


insert into Drama values(400,'Romeo&Juliet','love')
insert into Drama values(401,'rostam&sohrab','historical')
insert into Drama values(402,'gozhposht','impresive')
insert into Drama values(403,'Shirin&Farhad','love')
insert into Drama values(404,'Standup','Comedy')



insert into Show(Show_id,St_time,End_time,fk_M_id) values(1000,'08:00:00','10:00:00',300)
insert into Show(Show_id,St_time,End_time,fk_M_id) values(1001,'10:00:00','12:00:00',301)
insert into Show(Show_id,St_time,End_time,fk_M_id) values(1002,'14:00:00','16:00:00',302)

insert into Show(Show_id,St_time,End_time,fk_D_id) values(1003,'08:00:00','10:00:00',404)
insert into Show(Show_id,St_time,End_time,fk_D_id) values(1004,'10:00:00','12:00:00',400)
insert into Show(Show_id,St_time,End_time,fk_D_id) values(1005,'20:00:00','22:00:00',401)


insert into Customer values(500,'Mehrdad','mehrdadsalahshori98@gmail.com')
insert into Customer values(501,'Amir','amirfani2410@gmail.com')
insert into Customer values(502,'Mohammad','mr.haj77@gmail.com')
insert into Customer values(503,'asghar','pirzad98@gmail.com')
insert into Customer values(504,'asghar','pirzad98@gmail.com')
insert into Customer values(505,'milad','farhad@gmail.com')


insert into Employee1 values(1,'abbasghadri','AAA@gmail.com','09370224266','SonghorleftHand',20)
insert into Employee1 values(2,'amirfani','bbbb@gmail.com','09370442266','ArakleftHand',20)
insert into Employee1 values(3,'amirasadi','amirabbas99@gmail.com','09180224741','BabakRightHand',20)
insert into Employee1 values(4,'rezanaderi','assadi@gmail.com','0189872564','shirazleftHand',20)
insert into Employee1 values(5,'miladnaderi','javadi@gmail.com','0189872585','shirazleftHand',30)

select*from Employee1

delete from Ticket where Seat_no=1

insert into Ticket(Tichet_no,Show_date,Seat_no,Price,Hall_no,fk_Th_id,fk_Show_id,fk_E_id)
values(2000,'2019-05-14',1,20000,01,20,1000,1)
insert into Ticket(Tichet_no,Show_date,Seat_no,Price,Hall_no,fk_Th_id,fk_Show_id,fk_E_id)
values(2001,'2019-05-14',2,20000,1,20,1002,2)
insert into Ticket(Tichet_no,Show_date,Seat_no,Price,Hall_no,fk_Th_id,fk_Show_id,fk_E_id)
values(2002,'2019-05-14',3,20000,1,20,1003,1)
insert into Ticket(Tichet_no,Show_date,Seat_no,Price,Hall_no,fk_Th_id,fk_Show_id,fk_E_id)
values(2003,'2019-05-14',4,20000,1,20,1004,3)
insert into Ticket(Tichet_no,Show_date,Seat_no,Price,Hall_no,fk_Th_id,fk_Show_id,fk_E_id)
values(2004,'2019-05-15',5,30000,2,30,1004,1)
insert into Ticket(Tichet_no,Show_date,Seat_no,Price,Hall_no,fk_Th_id,fk_Show_id,fk_E_id)
values(2005,'2019-05-15',6,30000,2,30,1005,2)
insert into Ticket(Tichet_no,Show_date,Seat_no,Price,Hall_no,fk_Th_id,fk_Show_id,fk_E_id)
values(2006,'2019-05-15',7,20000,4,20,1001,4)
insert into Ticket(Tichet_no,Show_date,Seat_no,Price,Hall_no,fk_Th_id,fk_Show_id,fk_E_id)
values(2007,'2019-05-15',8,20000,4,20,1001,3)
insert into Ticket(Tichet_no,Show_date,Seat_no,Price,Hall_no,fk_Th_id,fk_Show_id,fk_E_id)
values(2013,'2019-05-15',15,20000,4,20,1001,3)

insert into Ticket(Tichet_no,Show_date,Seat_no,Price,Hall_no,fk_Th_id,fk_Show_id,fk_E_id)
values(2009,'2019-05-17',10,20000,4,20,1003,3)

insert into Ticket(Tichet_no,Show_date,Seat_no,Price,Hall_no,fk_Th_id,fk_Show_id,fk_E_id)
values(2010,'2019-05-17',11,40000,4,40,1003,2)

insert into Ticket(Tichet_no,Show_date,Seat_no,Price,Hall_no,fk_Th_id,fk_Show_id,fk_E_id)
values(2011,'2019-05-17',12,40000,4,20,1003,2)



select * from Customer

create view myview4 as
select*from Ticket,Show,Theatre
where fk_Show_id=Show_id and fk_Th_id=T_id;

create view myview5 as
select*from myview4,Movie
where fk_M_id=M_id;

select*from myview4

create view myview6 as
select*from myview4,Drama
where fk_D_id=D_id

select * from myview6

select Tichet_no,Price,Show_date,St_time,Hall_no,Seat_no,T_name,M_name AS ShowName
from myview5
where Tichet_no=2002
union
select Tichet_no,Price,Show_date,St_time,Hall_no,Seat_no,T_name,D_name
from myview6
where Tichet_no=2002


create proc get_time time , @end_time time
