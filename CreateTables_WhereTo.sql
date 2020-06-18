/* Roda essa parte daqui */
Create Database WhereTo
Go

Use WhereTo
Go
/* até aqui, só na 1° vez */

/*Create tables, primary keys e foreign keys*/

Create Table Usuario(
    UsuarioID           int             Not Null    Primary Key,
    Nome                varchar(200)    Not Null,
    Email               varchar(200)    Not Null,
    DataNascimento      datetime        Not Null
)
Go

Create Table Codigo(
    CodigoID    int     Primary Key,
    CodigoQR    int     Not Null
)
Go

Create Table Avatar(
    AvatarID        int            Primary Key,
    UsuarioID       int            Foreign Key References Usuario(UsuarioID),
    NomeAvatar      varchar(30)    Not Null,
    Sexo            varchar(10)    Not Null
)
Go

Create Table RoupaAvatar(
    RoupaID     int             Not Null    Primary Key,
    AvatarID    int             Foreign Key References Avatar(AvatarID),
    Cor         varchar(50)     Not Null,
    Local       int             Not Null
)
Go

Create Table Local(
    LocalID         int         Not Null    Primary Key,
    RoupaID         int         Foreign Key References RoupaAvatar(RoupaID),
    PartesDeCima    char(1)     Not Null,
    PartesDeBaixo   char(1)     Not Null,
    Acessorios      char(1)     Not Null
)
Go

Create Table Estabelecimento(
    EstabelecimentoID       int             Not Null    Primary Key,
    UsuarioID               int             Foreign Key References Usuario(UsuarioID),
    CodigoID                int             Foreign Key References Codigo(CodigoID),
    Classificacao           int,
    Comentarios             varchar(1000),
    RoupaPersonalizada      char(1)         Not Null,
    CEPEstabelecimento      varchar(8)      Not Null
)
Go

Create Table AdmEstabelecimento(
    AdmID                   int             Not Null    Primary Key,
    EstabelecimentoID       varchar(8)      Foreign Key References Estabelecimento(EstabelecimentoID),
    NomeAdm                 varchar(200)    Not Null,
    TelefonePrincipal       varchar(12)     Not Null,
    TelefoneSecundario      varchar(12)     Not Null
)
Go

Create Table LocalEstabelecimento(
    NomeEstabelecimento     varchar(200)    Not Null    Primary Key,
    EstabelecimentoID       varchar(8)      Foreign Key References Estabelecimento(EstabelecimentoID),
    CEPEstabelecimento      varchar(8)      Not Null,
    RuaEstabelecimento      varchar(200)    Not Null,
    NumeroEstabelecimento   int             Not Null,
    BairroEstabelecimento   varchar(200)    Not Null,
    CidadeEstabelecimento   varchar(200)    Not Null,
    PaisEstabelecimento     varchar(200)    Not Null
)
Go
