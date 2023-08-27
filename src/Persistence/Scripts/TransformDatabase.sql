CREATE TABLE CagedNew (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Secao nvarchar(254),
    cd_municipio varchar (255),
    municipio varchar (255),
    uf varchar (255),
    faixa_empregados varchar (254),
    competencia date,
    fluxo bigint
);

INSERT INTO CagedNew (Secao, cd_municipio, municipio, uf, faixa_empregados, competencia, fluxo)
SELECT secao, cd_municipio, municipio, uf, faixa_empregados, competencia, fluxo
FROM caged

ALTER TABLE caged RENAME TO cagedOld
ALTER TABLE CagedNew RENAME TO caged
DROP TABLE cagedOld