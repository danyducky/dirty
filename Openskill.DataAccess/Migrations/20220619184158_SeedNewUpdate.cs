using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Openskill.DataAccess.Migrations
{
    public partial class SeedNewUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2f0fbb1a-7182-4958-a8b2-46286b086bdb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "87be70e0-499b-479d-8b11-3e430506fb3e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "d869a157-cc57-4c60-8ccb-0dcf92d1ec61");

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Добро пожаловать на модуль «Проблемные коммуникации»!<br><br>Основная цель модуля - приобретение навыков проблемной коммуникации: умение определять проблему, исследовать, рассуждать и производить знания.<br><br>Модуль состоит из восьми блоков .Каждый блок занимает от двух до десяти минут.<br><br><b>Преподаватель модуля «Проблемные коммуникации»</b>: Никитина Алёна Сергеевна, кандидат социологических наук, доцент кафедры управления персоналом<br><br>Длительность обучения: шестьдесят минут");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "90c9cb78-d45d-45e5-a79b-a713d4ae31f9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "1c1794d9-0989-458f-8622-81833e1df3b5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "e5383025-70db-40fc-ac7f-433220861e60");

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Добро пожаловать на модуль «Проблемные коммуникации»!<br><br>Основная цель модуля - приобретение навыков проблемной коммуникации: умение определять проблему, исследовать, рассуждать и производить знания.<br><br>Модуль состоит из восьми блоков.Каждый блок занимает от двух до десяти минут.<br><br><b>Преподаватель модуля «Проблемные коммуникации»</b>: Никитина Алёна Сергеевна, кандидат социологических наук и доцент кафедры управления персоналом<br><br>Длительность обучения: шестьдесят минут");
        }
    }
}
