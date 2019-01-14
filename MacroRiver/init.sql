drop table if exists db_connection;
create table db_connection
(
    id text primary key not null, -- GUID
	hostname text not null,
    port integer null,
    username text not null,
    password text null
);