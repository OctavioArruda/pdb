# pdb project

## API Implementation
- Implemented using a clean architecture with .NET 6 API, leveraging the power of EF Core framework and SQLite.
- Managing approximately 18GB of raw data within the SQLite database.
- Addressing a fundamental domain problem: Uncleansed data and unestablished relationships between tables.

## DB Transformation
- Introduction of Primary Keys (PKs) for the following tables:
    - caged
    - cnpj_dados_cadastrais_pj
    - cnpj_dados_cnae_secundario_pj
    - cnpj_dados_socios

## DB Optimization
- Added Foreign Key caged (cnpj_dados_cadastrais_pj_id) referencing cnpj_dados_cnae_secundario_pj
- Added Foreign Key cnpj_dados_cnae_secundario_pj (socio_id) referencing cnpj_dados_socios
- Insertion of indexes for caged.id, caged.cnpj_dados_cadastrais_pj_id, caged.uf, cnpj_dados_cadastrais_pj.uf cnpj_dados_socios.id, cnpj_dados_cnae_secundario_pj.id, cnpj_dados_socios.cnpj, cnpj_dados_cnae_secundario_pj.cnpj
    - The indexes were necessary to the insertion of the FKs in the PKs table

## Queries implemented:
- By implementing database transformation and adding primary keys to recreate the tables, four efficient endpoints were created. These endpoints can seamlessly query through more than 30 million records, with pagination parameters in place to prevent throttling.
-

