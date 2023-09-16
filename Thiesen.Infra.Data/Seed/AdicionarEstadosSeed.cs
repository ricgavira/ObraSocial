using Microsoft.EntityFrameworkCore.Migrations;

namespace ObraSocial.Infra.Data.Seed
{
    public class AdicionarEstadosSeed
    {
        public static void Seed(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'AC', N'Acre', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'AL', N'Alagoas', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'AP', N'Amapá', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'AM', N'Amazonas', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'BA', N'Bahia', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'CE', N'Ceará', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'DF', N'Distrito Federal', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'ES', N'Espírito Santo', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'GO', N'Goiás', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'MA', N'Maranhão', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'MT', N'Mato Grosso', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'MS', N'Mato Grosso do Sul', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'MG', N'Minas Gerais', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'PA', N'Pará', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'PB', N'Paraíba', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'PR', N'Paraná', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'PE', N'Pernambuco', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'PI', N'Piauí', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'RJ', N'Rio de Janeiro', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'RN', N'Rio Grande do Norte', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'RS', N'Rio Grande do Sul', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'RO', N'Rondônia', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'RR', N'Roraima', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'SC', N'Santa Catarina', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'SP', N'São Paulo', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'SE', N'Sergipe', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
                INSERT INTO Estado (Sigla, Nome, CreateAt, UpdateAt) VALUES (N'TO', N'Tocantins', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
            ");
        }
    }
}