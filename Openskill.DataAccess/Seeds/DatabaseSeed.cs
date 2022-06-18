using Friendly.Domain.Structs;
using Microsoft.EntityFrameworkCore;
using Openskill.Domain.Entities;

namespace Openskill.DataAccess.Seeds
{
    public static class DatabaseSeed
    {
        public static void Execute(ModelBuilder modelBuilder)
        {
            foreach (UserRoles userRole in Enum.GetValues(typeof(UserRoles)))
            {
                var name = userRole.ToString();
                var role = new Role { Id = (int)userRole, Name = name, NormalizedName = name.ToUpper() };
                modelBuilder.Entity<Role>().HasData(role);
            }

            var modules = new List<Module>
            {
                new Module { Id = 1, Title = "О модуле", Content = "<ul>" + "<li>понятия проблемных коммуникаций</li>" + "<li>формы и виды проблемных коммуникаций</li>" + "<li>факторы, определяющие специфику проблемных коммуникаций</li>" + "<li>основные приёмы преодоления проблемных коммуникаций</li>" + "</ul>", VideoPath = "content/videos/IMG_1802.mp4" },
                new Module { Id = 2, Title = "Теоретические основы. Часть 1", Content = "Проблемная коммуникация – это экстремальное проявление обычной организационной коммуникации", VideoPath = "content/videos/IMG_2143.mp4" },
                new Module { Id = 3, Title = "Теоретические основы. Часть 2", Content = "Проблемная коммуникация состоит из:<br>" + 
                "<ul>" + 
                "<li>Адресат</li>" + 
                "<li>Реципиент</li>" + 
                "</ul><br><br>"+ 
                "Каналы проблемной коммуникации бывают: устные, цифровые, неформальные", VideoPath = "content/videos/IMG_2151.mp4" },
                new Module { Id = 4, Title = "Решаем проблемные коммуникации", Content = "Основные методы решения проблемных коммуникаций<br>" +
                "МЕТОД 1. Личностная диагностика<br>" +
                "МЕТОД 2. Невербальный тренинг<br>" +
                "МЕТОД 3. Социально-психологические практики", VideoPath = "content/videos/IMG_2154.mp4" },
                new Module { Id = 5, Title = "Колесо баланса", Content = "Жизнь каждого из нас состоит из нескольких важных сфер, в которых мы балансируем изо дня в день. Часто случается так, что мы фокусируемся только на одной или двух, при этом забывая заботиться об улучшении остальных.<br><br>" +
"Колесо баланса — это методика, с помощью которой оценивается наполненность различных сфер жизни человека. Она помогает сделать анализ всех аспектов, рассчитать время и силы, выбрать правильный вектор движения.<br><br>" +
"Ответы присылайте на почту <b>openskills.ranepa@yandex.ru</b>", VideoPath = "content/videos/IMG_2159.mp4" },
                new Module { Id = 6, Title = "Самодиагностика", Content = "Диагностика личности – это совокупность принципов и методов определения наиболее существенных (для решения проблемных коммуникаций) особенностей личности.<br><br>" + "Ответы присылайте на почту <b>openskills.ranepa@yandex.ru</b>", VideoPath = "content/videos/IMG_2163.mp4" },
                new Module { Id = 7, Title = "Проблема – Цель", Content = "У каждого из нас есть свои проблемы. Некоторые из них мы должны принять и жить с ними так, как можем. Но к счастью, многие наши проблемы могут быть решены, если мы сможем представить их для себя в виде целей, которых хотели бы достичь.<br><br>" + "Для визуализации цели Вы можете воспользоваться виртуальной онлайн-доской, которая представлена ниже.<br><br>" + "Ответы присылайте на почту <b>openskills.ranepa@yandex.ru</b>", VideoPath = "content/videos/IMG_2165.mp4" },
                new Module { Id = 8, Title = "Итоги модуля", Content = "С Вами было интересно заниматься! Переходите на следующий модуль трека openskills.", VideoPath = "content/videos/IMG_2167.mp4" },
            };

            modelBuilder.Entity<Module>().HasData(modules);

            var tracks = new Track[]
            {
                new Track { Id = 1, Title = "Проблемные коммуникации", Description = "Добро пожаловать на модуль «Проблемные коммуникации»!<br><br>" +
"Основная цель модуля - приобретение навыков проблемной коммуникации: умение определять проблему, исследовать, рассуждать и производить знания.<br><br>" +
"Модуль состоит из восьми блоков.Каждый блок занимает от двух до десяти минут.<br><br>" +
"<b>Преподаватель модуля «Проблемные коммуникации»</b>: Никитина Алёна Сергеевна, кандидат социологических наук и доцент кафедры управления персоналом<br><br>" +
"Длительность обучения: шестьдесят минут" },
                new Track { Id = 2, Title = "Цифровая грамотность", Description = "Рассчитан для госслужащих, которым необходимо поддерживать цифровую трансформацию государства." },
                new Track { Id = 3, Title = "Договоримся?", Description = "Направлен на развитие навыков в деловых переговорах." },
                new Track { Id = 4, Title = "Русский язык", Description = "Помогает поддерживать русский язык в тонусе.", IsAdditional = true },
                new Track { Id = 5, Title = "На вершине или как работать в напряженных условиях", Description = "Позволит снизить стрессоустойчивость и повысить работоспособность.", IsAdditional = true },
                new Track { Id = 6, Title = "Вместе", Description = "Направлен на работу в командах.", IsAdditional = true },
            };

            modelBuilder.Entity<Track>().HasData(tracks);

            var trackModules = new List<TrackModule>
            {
                new TrackModule { TrackId = 1, ModuleId = 1 },
                new TrackModule { TrackId = 1, ModuleId = 2 },
                new TrackModule { TrackId = 1, ModuleId = 3 },
                new TrackModule { TrackId = 1, ModuleId = 4 },
                new TrackModule { TrackId = 1, ModuleId = 5 },
                new TrackModule { TrackId = 1, ModuleId = 6 },
                new TrackModule { TrackId = 1, ModuleId = 7 },
                new TrackModule { TrackId = 1, ModuleId = 8 },
            };

            modelBuilder.Entity<TrackModule>().HasData(trackModules);
        }
    }
}