UserData Tablosu İçin:

        CREATE TABLE UserData (
        ID int identity(1,1) primary key,
        Username nvarchar(25) not null,
        Email nvarchar(50) not null,
        Pass nvarchar(50) not null,
        )
PostData Tablosu İçin (Forigen Key için):

        CREATE TABLE PostData (
    PostID INT IDENTITY(1,1) PRIMARY KEY,
    postDate DATE NOT NULL,
    ID INT NOT NULL

    CONSTRAINT FK_PostData_UserData
        FOREIGN KEY (ID)
        REFERENCES UserData(ID)
        ON DELETE CASCADE
        ON UPDATE CASCADE
    );
