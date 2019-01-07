drop table if exists db_connection;
create table db_connection
(
    id text primary key not null, -- GUID
    name text not null,
	hostname text not null,
    port integer not null,
    username text not null,
    password text null
);