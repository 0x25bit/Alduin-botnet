create table bot (id  serial, user_name varchar(255), key_unique varchar(255), key_certified varchar(255), country_code varchar(255), domain varchar(255), last_ipaddress varchar(255), last_logged_in_utc timestamp, creation_date_utc timestamp, modification_date_utc timestamp, primary key (id));
create table bot_info (id  serial, hardware_name varchar(255), hardware_type varchar(255), performance varchar(255), other_information varchar(255), creation_date_utc timestamp, modification_date_utc timestamp, bot_id int4, primary key (id));
create table invitation (id  serial, invitation_key varchar(255), used boolean, creation_date_utc timestamp, modification_date_utc timestamp, user_id int4, primary key (id));
create table user_claim (id  serial, claim_type varchar(255), claim_value varchar(255), creation_date_utc timestamp, modification_date_utc timestamp, user_id int4, primary key (id));
create table "user" (id  serial, name varchar(255), user_name varchar(255), normalized_user_name varchar(255), password_hash varchar(255), email varchar(255), last_attempt_utc timestamp, access_failed_count int4, last_logged_in_utc timestamp, is_last_login_persistent boolean, security_stamp varchar(255), lockout_enabled boolean, lockout_end timestamp, is_deleted boolean, deletion_date_utc timestamp, creation_date_utc timestamp, modification_date_utc timestamp, primary key (id));
create index ix_bot_info_bot_id on bot_info (bot_id);
alter table bot_info add constraint fk_bot_bot_info foreign key (bot_id) references bot;
create index ix_invitation_user_id on invitation (user_id);
alter table invitation add constraint fk_user_invitation foreign key (user_id) references "user";
create index ix_user_claim_user_id on user_claim (user_id);
alter table user_claim add constraint fk_user_user_claim foreign key (user_id) references "user"