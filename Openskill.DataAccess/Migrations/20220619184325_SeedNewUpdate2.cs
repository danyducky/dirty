using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Openskill.DataAccess.Migrations
{
    public partial class SeedNewUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "09959a79-17de-4207-8171-b2f1e506a655");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "50db0baf-9dfe-4cce-a589-b9268db004df");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "d52c0a3b-b396-4a14-aed2-3ebc4471a2d9");

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Добро пожаловать на модуль «Проблемные коммуникации»!<br><br>Основная цель модуля - приобретение навыков проблемной коммуникации: умение определять проблему, исследовать, рассуждать и производить знания.<br><br>Модуль состоит из восьми блоков. Каждый блок занимает от двух до десяти минут.<br><br><b>Преподаватель модуля «Проблемные коммуникации»</b>: Никитина Алёна Сергеевна, кандидат социологических наук, доцент кафедры управления персоналом<br><br>Длительность обучения: шестьдесят минут");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
