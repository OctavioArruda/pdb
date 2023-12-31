CREATE TABLE CagedNew (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Secao nvarchar(254),
    cd_municipio varchar (255),
    municipio varchar (255),
    uf varchar (150),
    faixa_empregados varchar (254),
    competencia date,
    fluxo bigint
);

-- More than 14.000.000 (14 mi) records
INSERT INTO CagedNew (Secao, cd_municipio, municipio, uf, faixa_empregados, competencia, fluxo)
SELECT secao, cd_municipio, municipio, uf, faixa_empregados, competencia, fluxo
FROM caged;

ALTER TABLE caged RENAME TO cagedOld;
ALTER TABLE CagedNew RENAME TO caged;
DROP TABLE cagedOld;

CREATE TABLE TEMP (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    tipo_de_registro            NVARCHAR (1073741823),
    indicador                   NVARCHAR (1073741823),
    tipo_atualizacao            NVARCHAR (1073741823),
    cnpj                        NVARCHAR (1073741823),
    identificador_matriz_filial NVARCHAR (1073741823),
    razao_social                NVARCHAR (1073741823),
    nome_fantasia               NVARCHAR (1073741823),
    situacao_cadastral          NVARCHAR (1073741823),
    data_situacao_cadastral     NVARCHAR (1073741823),
    motivo_situacao_cadastral   NVARCHAR (1073741823),
    nm_cidade_exterior          NVARCHAR (1073741823),
    cod_pais                    NVARCHAR (1073741823),
    nm_pais                     NVARCHAR (1073741823),
    codigo_natureza_juridica    NVARCHAR (1073741823),
    data_inicio_atividade       NVARCHAR (1073741823),
    cnae_fiscal                 NVARCHAR (1073741823),
    descricao_tipo_logradouro   NVARCHAR (1073741823),
    logradouro                  NVARCHAR (1073741823),
    numero                      NVARCHAR (1073741823),
    complemento                 NVARCHAR (1073741823),
    bairro                      NVARCHAR (1073741823),
    cep                         NVARCHAR (1073741823),
    uf                          NVARCHAR (150),
    codigo_municipio            NVARCHAR (1073741823),
    municipio                   NVARCHAR (1073741823),
    ddd_telefone_1              NVARCHAR (1073741823),
    ddd_telefone_2              NVARCHAR (1073741823),
    ddd_fax                     NVARCHAR (1073741823),
    correio_eletronico          NVARCHAR (1073741823),
    qualificacao_responsavel    NVARCHAR (1073741823),
    capital_social_empresa      DOUBLE,
    porte_empresa               NVARCHAR (1073741823),
    opcao_pelo_simples          NVARCHAR (1073741823),
    data_opcao_pelo_simples     NVARCHAR (1073741823),
    data_exclusao_simples       NVARCHAR (1073741823),
    opcao_pelo_mei              NVARCHAR (1073741823),
    situacao_especial           NVARCHAR (1073741823),
    data_situacao_especial      NVARCHAR (1073741823),
    filler                      NVARCHAR (1073741823),
    fim_registro                NVARCHAR (1073741823)
);

-- More than 44 million records
INSERT INTO TEMP (
    tipo_de_registro,
    indicador,
    tipo_atualizacao,
    cnpj,
    identificador_matriz_filial,
    razao_social,
    nome_fantasia,
    situacao_cadastral,
    data_situacao_cadastral,
    motivo_situacao_cadastral,
    nm_cidade_exterior,
    cod_pais,
    nm_pais,
    codigo_natureza_juridica,
    data_inicio_atividade,
    cnae_fiscal,
    descricao_tipo_logradouro,
    logradouro,
    numero,
    complemento,
    bairro,
    cep,
    uf,
    codigo_municipio,
    municipio,
    ddd_telefone_1,
    ddd_telefone_2,
    ddd_fax,
    correio_eletronico,
    qualificacao_responsavel,
    capital_social_empresa,
    porte_empresa,
    opcao_pelo_simples,
    data_opcao_pelo_simples,
    data_exclusao_simples,
    opcao_pelo_mei,
    situacao_especial,
    data_situacao_especial,
    filler,
    fim_registro )
    SELECT
    tipo_de_registro,
    indicador,
    tipo_atualizacao,
    cnpj,
    identificador_matriz_filial,
    razao_social,
    nome_fantasia,
    situacao_cadastral,
    data_situacao_cadastral,
    motivo_situacao_cadastral,
    nm_cidade_exterior,
    cod_pais,
    nm_pais,
    codigo_natureza_juridica,
    data_inicio_atividade,
    cnae_fiscal,
    descricao_tipo_logradouro,
    logradouro,
    numero,
    complemento,
    bairro,
    cep,
    uf,
    codigo_municipio,
    municipio,
    ddd_telefone_1,
    ddd_telefone_2,
    ddd_fax,
    correio_eletronico,
    qualificacao_responsavel,
    capital_social_empresa,
    porte_empresa,
    opcao_pelo_simples,
    data_opcao_pelo_simples,
    data_exclusao_simples,
    opcao_pelo_mei,
    situacao_especial,
    data_situacao_especial,
    filler,
    fim_registro
    FROM cnpj_dados_cadastrais_pj;


ALTER TABLE cnpj_dados_cadastrais_pj RENAME TO cnpj_dados_cadastrais_pjOld;
ALTER TABLE TEMP RENAME TO cnpj_dados_cadastrais_pj;
DROP TABLE cnpj_dados_cadastrais_pjOld;


CREATE TABLE TEMP (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    tipo_de_registro nvarchar (200),
    indicador nvarchar (200),
    tipo_atualizacao nvarchar (200),
    cnpj nvarchar (20),
    cnae_secundario nvarchar (200),
    filler nvarchar (200)
);

INSERT INTO TEMP (
    tipo_de_registro,
    indicador,
    tipo_atualizacao,
    cnpj,
    cnae_secundario,
    filler
)
SELECT tipo_de_registro,
       indicador,
       tipo_atualizacao,
       cnpj,
       cnae_secundario,
       filler
  FROM cnpj_dados_cnae_secundario_pj;

ALTER TABLE cnpj_dados_cnae_secundario_pj RENAME TO cnpj_dados_cnae_secundario_pjOld;
ALTER TABLE TEMP RENAME TO cnpj_dados_cnae_secundario_pj;
DROP TABLE cnpj_dados_cnae_secundario_pjOld;

ALTER TABLE cnpj_dados_socios RENAME TO cnpj_dados_sociosOld;

CREATE TABLE cnpj_dados_socios (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    tipo_de_registro                     NVARCHAR (200),
    indicador                            NVARCHAR (200),
    tipo_atualizacao                     NVARCHAR (200),
    cnpj                                 NVARCHAR (20),
    identificador_socio                  NVARCHAR (200),
    nome_socio                           NVARCHAR (200),
    cnpj_cpf_socio                       NVARCHAR (200),
    cod_qualificacao_socio               NVARCHAR (200),
    percentual_capital_socio             NVARCHAR (200),
    data_entrada_sociedade               NVARCHAR (200),
    cod_pais                             NVARCHAR (200),
    nome_pais_socio                      NVARCHAR (200),
    cpf_representante_legal              NVARCHAR (200),
    nome_representante                   NVARCHAR (200),
    cod_qualificacao_representante_legal NVARCHAR (200),
    fillter                              NVARCHAR (200),
    fim_registro                         NVARCHAR (200)
);

INSERT INTO cnpj_dados_socios
(
    tipo_de_registro,
    indicador,
    tipo_atualizacao,
    cnpj,
    identificador_socio,
    nome_socio,
    cnpj_cpf_socio,
    cod_qualificacao_socio,
    percentual_capital_socio,
    data_entrada_sociedade,
    cod_pais,
    nome_pais_socio,
    cpf_representante_legal,
    nome_representante,
    cod_qualificacao_representante_legal,
    fillter,
    fim_registro
)
SELECT
    tipo_de_registro,
    indicador,
    tipo_atualizacao,
    cnpj,
    identificador_socio,
    nome_socio,
    cnpj_cpf_socio,
    cod_qualificacao_socio,
    percentual_capital_socio,
    data_entrada_sociedade,
    cod_pais,
    nome_pais_socio,
    cpf_representante_legal,
    nome_representante,
    cod_qualificacao_representante_legal,
    fillter,
    fim_registro
FROM cnpj_dados_sociosOld;

DROP TABLE cnpj_dados_sociosOld;

SELECT
    *
FROM caged;
SELECT
    *
FROM cnpj_dados_cadastrais_pj;
SELECT
    *
FROM cnpj_dados_cnae_secundario_pj;
SELECT
    *
FROM cnpj_dados_socios;


alter table caged rename to cagedOld;
alter table cnpj_dados_cadastrais_pj rename to cnpj_dados_cadastrais_pjOld;
alter table cnpj_dados_cnae_secundario_pj rename to cnpj_dados_cnae_secundario_pjOld;
alter table cnpj_dados_socios rename to cnpj_dados_sociosOld;

--  improving tab_cnae
ALTER TABLE tab_cnae RENAME TO tab_cnae_OLD;

CREATE TABLE tab_cnae (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    cod_secao   NVARCHAR (150),
    nm_secao    NVARCHAR (150),
    cod_divisao NVARCHAR (150),
    nm_divisao  NVARCHAR (150),
    cod_grupo   NVARCHAR (150),
    nm_grupo    NVARCHAR (150),
    cod_classe  NVARCHAR (150),
    nm_classe   NVARCHAR (150),
    cod_cnae    NVARCHAR (150),
    nm_cnae     NVARCHAR (150)
);

CREATE INDEX idx_pk_tab_cnae ON tab_cnae (id);

INSERT INTO tab_cnae
(
    cod_secao,
    nm_secao,
    cod_divisao,
    nm_divisao,
    cod_grupo,
    nm_grupo,
    cod_classe,
    nm_classe,
    cod_cnae,
    nm_cnae
)
SELECT
    cod_secao,
    nm_secao,
    cod_divisao,
    nm_divisao,
    cod_grupo,
    nm_grupo,
    cod_classe,
    nm_classe,
    cod_cnae,
    nm_cnae
FROM tab_cnae_OLD;

DROP TABLE tab_cnae_OLD;

CREATE INDEX idx_cod_secao_tab_cnae ON tab_cnae (cod_secao);
CREATE INDEX idx_secao_caged ON caged (Secao);

