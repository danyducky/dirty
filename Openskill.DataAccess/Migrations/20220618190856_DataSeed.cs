using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Openskill.DataAccess.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "Title", "VideoPath" },
                values: new object[] { "<ul><li>понятия проблемных коммуникаций</li><li>формы и виды проблемных коммуникаций</li><li>факторы, определяющие специфику проблемных коммуникаций</li><li>основные приёмы преодоления проблемных коммуникаций</li></ul>", "О модуле", "content/videos/IMG_1802.mp4" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "Title", "VideoPath" },
                values: new object[] { "Проблемная коммуникация – это экстремальное проявление обычной организационной коммуникации", "Теоретические основы. Часть 1", "content/videos/IMG_2143.mp4" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "Title", "VideoPath" },
                values: new object[] { "Проблемная коммуникация состоит из:<br><ul><li>Адресат</li><li>Реципиент</li></ul><br><br>Каналы проблемной коммуникации бывают: устные, цифровые, неформальные", "Теоретические основы. Часть 2", "content/videos/IMG_2151.mp4" });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "Content", "Title", "VideoPath" },
                values: new object[,]
                {
                    { 4, "Основные методы решения проблемных коммуникаций<br>МЕТОД 1. Личностная диагностика<br>МЕТОД 2. Невербальный тренинг<br>МЕТОД 3. Социально-психологические практики", "Решаем проблемные коммуникации", "content/videos/IMG_2154.mp4" },
                    { 5, "Жизнь каждого из нас состоит из нескольких важных сфер, в которых мы балансируем изо дня в день. Часто случается так, что мы фокусируемся только на одной или двух, при этом забывая заботиться об улучшении остальных.<br><br>Колесо баланса — это методика, с помощью которой оценивается наполненность различных сфер жизни человека. Она помогает сделать анализ всех аспектов, рассчитать время и силы, выбрать правильный вектор движения.<br><br>Ответы присылайте на почту <b>openskills.ranepa@yandex.ru</b>", "Колесо баланса", "content/videos/IMG_2159.mp4" },
                    { 6, "Диагностика личности – это совокупность принципов и методов определения наиболее существенных (для решения проблемных коммуникаций) особенностей личности.<br><br>Ответы присылайте на почту <b>openskills.ranepa@yandex.ru</b>", "Самодиагностика", "content/videos/IMG_2163.mp4" },
                    { 7, "У каждого из нас есть свои проблемы. Некоторые из них мы должны принять и жить с ними так, как можем. Но к счастью, многие наши проблемы могут быть решены, если мы сможем представить их для себя в виде целей, которых хотели бы достичь.<br><br>Для визуализации цели Вы можете воспользоваться виртуальной онлайн-доской, которая представлена ниже.<br><br>Ответы присылайте на почту <b>openskills.ranepa@yandex.ru</b>", "Проблема – Цель", "content/videos/IMG_2165.mp4" },
                    { 8, "С Вами было интересно заниматься! Переходите на следующий модуль трека openskills.", "Итоги модуля", "content/videos/IMG_2167.mp4" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2fab1d4c-13d0-47b3-a586-29c714a8e3a3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b84c4ce9-c31a-4165-bbff-5f219318c92e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "27458192-d694-43a5-a7bd-befb4671da56");

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Добро пожаловать на модуль «Проблемные коммуникации»!<br><br>Основная цель модуля - приобретение навыков проблемной коммуникации: умение определять проблему, исследовать, рассуждать и производить знания.<br><br>Модуль состоит из восьми блоков.Каждый блок занимает от двух до десяти минут.<br><br><b>Преподаватель модуля «Проблемные коммуникации»</b>: Никитина Алёна Сергеевна, кандидат социологических наук и доцент кафедры управления персоналомДлительность обучения: шестьдесят минут");

            migrationBuilder.InsertData(
                table: "TrackModules",
                columns: new[] { "ModuleId", "TrackId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrackModules",
                keyColumns: new[] { "ModuleId", "TrackId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "TrackModules",
                keyColumns: new[] { "ModuleId", "TrackId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "TrackModules",
                keyColumns: new[] { "ModuleId", "TrackId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "TrackModules",
                keyColumns: new[] { "ModuleId", "TrackId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "TrackModules",
                keyColumns: new[] { "ModuleId", "TrackId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "Title", "VideoPath" },
                values: new object[] { "asd", "Видео1", "content/videos/IMG_1802.MOV" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "Title", "VideoPath" },
                values: new object[] { "asd", "Видео2", "content/videos/IMG_2143.MOV" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "Title", "VideoPath" },
                values: new object[] { "asd", "Видео3", "content/videos/IMG_2151.MOV" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d390d857-6f4c-4b11-b47d-426e6982c086");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2b76e861-58d4-4154-9ae2-acb93a4216bd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "66268402-b7fd-4872-a491-d7688d955290");

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Направлен на улучшения навыков решения конфликтных ситуаций.");
        }
    }
}
