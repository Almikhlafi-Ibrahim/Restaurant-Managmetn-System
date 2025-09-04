CREATE TABLE [dbo].[users] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [username]     VARCHAR (MAX) NULL,
    [password]     VARCHAR (MAX) NULL,
    [status]       VARCHAR (MAX) NULL,
    [date_created] DATE          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);




select * from users;


Create table categories (
        [id]           INT   primary key        IDENTITY (1, 1) NOT NULL,
        category  VARCHAR (MAX),
            [status]       VARCHAR (MAX) NULL,
            date_inserted date null
);


select * from categories;




