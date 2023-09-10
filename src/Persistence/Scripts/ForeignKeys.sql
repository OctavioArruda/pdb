-- Create a new caged table with the necessary structure
CREATE TABLE caged (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    cnpj_dados_cadastrais_pj_id INTEGER,
    FOREIGN KEY (cnpj_dados_cadastrais_pj_id) REFERENCES cnpj_dados_cadastrais_pj(Id)
    Secao NVARCHAR(254),
    municipio VARCHAR(255),
    uf VARCHAR(255),
    faixa_empregados VARCHAR(254),
    competencia DATE,
    fluxo BIGINT,
);

-- index for making the join real:
CREATE INDEX idx_uf ON cagedOld (uf);
CREATE INDEX idx_cnpj_dados_cadastrais_pjOld_uf ON cnpj_dados_cadastrais_pjOld (uf)

-- Copy data from cagedOld to caged, including the foreign key reference
-- The selected row to bind the data was UF
INSERT INTO caged (Secao, municipio, uf, faixa_empregados, competencia, fluxo)
SELECT Secao, municipio, uf, faixa_empregados, competencia, fluxo
FROM cagedNew;

UPDATE caged
SET cnpj_dados_cadastrais_pj_id =
(
    SELECT id
    FROM cnpj_dados_cadastrais_pjNew
    WHERE uf = caged.uf
);

CREATE INDEX idx_pk_caged ON caged (id);
CREATE INDEX idx_fk_cnpj_dados_cadastrais_pj_id ON caged (cnpj_dados_cadastrais_pj_id);

-- relation:
-- caged.cnpj_dados_cadastrais_pj_id = cnpj_dados_cadastrais_pj.id

--- New secton of data update
-- Create new tables with foreign key reference
CREATE TABLE cnpj_dados_cnae_secundario_pj (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    tipo_de_registro NVARCHAR(250),
    indicador NVARCHAR(250),
    tipo_atualizacao NVARCHAR(150),
    cnpj NVARCHAR(150),
    cnae_secundario NVARCHAR(250),
    filler NVARCHAR(250),
    socio_id INTEGER,
    FOREIGN KEY (socio_id) REFERENCES cnpj_dados_socios(id)
);

CREATE TABLE cnpj_dados_socios (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    tipo_de_registro NVARCHAR(250),
    indicador NVARCHAR(250),
    tipo_atualizacao NVARCHAR(250),
    cnpj NVARCHAR(250),
    identificador_socio NVARCHAR(250),
    nome_socio NVARCHAR(250),
    cnpj_cpf_socio NVARCHAR(250),
    cod_qualificacao_socio NVARCHAR(250),
    percentual_capital_socio NVARCHAR(250),
    data_entrada_sociedade NVARCHAR(250),
    cod_pais NVARCHAR(250),
    nome_pais_socio NVARCHAR(250),
    cpf_representante_legal NVARCHAR(250),
    nome_representante NVARCHAR(250),
    cod_qualificacao_representante_legal NVARCHAR(250),
    fillter NVARCHAR(250),
    fim_registro NVARCHAR(250)
);

-- Populate the new tables from old tables
INSERT INTO cnpj_dados_cnae_secundario_pj
    (tipo_de_registro, indicador, tipo_atualizacao, cnpj, cnae_secundario, filler)
SELECT
    tipo_de_registro, indicador, tipo_atualizacao, cnpj, cnae_secundario, filler
FROM cnpj_dados_cnae_secundario_pjOld;

INSERT INTO cnpj_dados_socios
    (tipo_de_registro, indicador, tipo_atualizacao, cnpj, identificador_socio, nome_socio, cnpj_cpf_socio,
     cod_qualificacao_socio, percentual_capital_socio, data_entrada_sociedade, cod_pais, nome_pais_socio,
     cpf_representante_legal, nome_representante, cod_qualificacao_representante_legal, fillter, fim_registro)
SELECT
    tipo_de_registro, indicador, tipo_atualizacao, cnpj, identificador_socio, nome_socio, cnpj_cpf_socio,
    cod_qualificacao_socio, percentual_capital_socio, data_entrada_sociedade, cod_pais, nome_pais_socio,
    cpf_representante_legal, nome_representante, cod_qualificacao_representante_legal, fillter, fim_registro
FROM cnpj_dados_sociosOld;

CREATE INDEX idx_pk_cnpj_dados_socios ON cnpj_dados_socios (id);
CREATE INDEX idx_pk_cnpj_dados_cnae_secundario_pj ON cnpj_dados_cnae_secundario_pj (id);
CREATE INDEX idx_cnpj_cnpj_dados_socios ON cnpj_dados_socios (cnpj);
CREATE INDEX idx_cnpj_cnpj_dados_cnae_secundario_pj ON cnpj_dados_cnae_secundario_pj (cnpj);

UPDATE cnpj_dados_cnae_secundario_pj
SET socio_id = (SELECT id FROM cnpj_dados_socios WHERE cnpj = cnpj_dados_cnae_secundario_pj.cnpj);

-- new view
CREATE VIEW caged_cnpj_data_view AS
SELECT
    c.Id,
    c.Secao,
    cnpj.Id AS cnpj_dados_cadastrais_pj_id,
    c.municipio,
    c.uf,
    c.faixa_empregados,
    c.competencia,
    c.fluxo,
    cnpj.cnpj,
    cnpj.tipo_de_registro,
    cnpj.indicador,
    cnpj.tipo_atualizacao,
    cnpj.identificador_matriz_filial,
    cnpj.razao_social,
    cnpj.nome_fantasia,
    cnpj.situacao_cadastral,
    cnpj.data_situacao_cadastral,
    cnpj.motivo_situacao_cadastral,
    cnpj.nm_cidade_exterior,
    cnpj.cod_pais,
    cnpj.nm_pais,
    cnpj.codigo_natureza_juridica,
    cnpj.data_inicio_atividade,
    cnpj.cnae_fiscal,
    cnpj.descricao_tipo_logradouro,
    cnpj.logradouro,
    cnpj.numero,
    cnpj.complemento,
    cnpj.bairro,
    cnpj.cep,
    cnpj.uf
FROM caged c
JOIN cnpj_dados_cadastrais_pj cnpj ON c.cnpj_dados_cadastrais_pj_id = cnpj.Id;
