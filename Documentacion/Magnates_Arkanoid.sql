create table player(
id_player serial not null primary key,
player varchar(25) unique
)
create table score(
id_score serial not null primary key,
points int not null,
id_player int not null 
)  
alter table score 
add CONSTRAINT fk_player_score FOREIGN KEY (id_player) REFERENCES player(id_player) 