create table bot_info (id  serial, hardware_name varchar(255), hardware_type varchar(255), performance varchar(255), other_information varchar(255), creation_date_utc timestamp, modification_date_utc timestamp, bot_id int4, primary key (id));
alter table bot_info add constraint fk_bot_bot_info foreign key (bot_id) references bot;
create index ix_bot_info_bot_id on bot_info (bot_id)