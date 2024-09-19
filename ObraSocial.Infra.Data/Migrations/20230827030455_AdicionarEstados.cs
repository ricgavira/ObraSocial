using Microsoft.EntityFrameworkCore.Migrations;
using ObraSocial.Infra.Data.Seed;

#nullable disable

namespace ObraSocial.Infra.Data.Migrations
{
    public partial class AdicionarEstados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            AdicionarEstadosSeed.Seed(migrationBuilder);
        }
    }
}