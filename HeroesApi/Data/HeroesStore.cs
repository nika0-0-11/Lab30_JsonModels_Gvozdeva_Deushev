using HeroesApi.Models;

namespace HeroesApi.Data;

public static class HeroeStore {    
    public static List<Hero> Heroes { get; } = new() {
        new Hero {
            Id = 1,
            Name = "Человек-паук",
            RealName = "Питер Паркер",
            Universe = Universe.Marvel,
            PowerLevel = 75,
            Powers = new() { "паутина", "лазание по стенам", "паучье чутье" },
            Weapon = new() { Name = "Веб-шутер",  IsRanged = true },
            InternalNotes = "Любимый герой редактора"
        },
        new Hero {
            Id = 2,
            Name = "Бэтмен",
            RealName = "Брис Уэйн",
            Universe = Universe.DC,
            PowerLevel = 70,
            Powers = new() { "интеллект", "боевые искусства", "технологии" },
            Weapon = new() { Name = "Бэтаранг", IsRanged = true },
            InternalNotes = "Без суперсил, только деньги и упорство" 
        },
        new Hero {
            Id = 3,
            Name = "Железный человек",
            RealName = "Тони Старк",
            Universe = Universe.Marvel,
            PowerLevel = 85,
            Powers = new() { "броня", "полет", "интеллект", "лазеры" },
            Weapon = new() { Name = "Костюм Марк 50", IsRanged = true },
            InternalNotes = "Я - Железный человек" 
        },
        new Hero {
            Id = 4,
            Name = "Грут",
            RealName = "Грут",
            Universe = Universe.Marvel,
            PowerLevel = 80,
            Powers = new() { "регенерация", "управление деревом", "суперсила" },
            Weapon = new() { Name = "Ветви", IsRanged = false },
            InternalNotes = "Я есть Грут" 
        },
        new Hero {
            Id = 5,
            Name = "Тор",
            RealName = "Тор Одинсон",
            Universe = Universe.Marvel,
            PowerLevel = 95,
            Powers = new() { "молния", "полет", "суперсила", "бессмертие" },
            Weapon = new() { Name = "Мьёльнир", IsRanged = false },
            InternalNotes = "Бог грома" 
        },
        new Hero {
            Id = 6,
            Name = "Росомаха",
            RealName = "Логан",
            Universe = Universe.Marvel,
            PowerLevel = 85,
            Powers = new() { "регенерация", "когти", "суперсила", "замедленное старение" },
            Weapon = new() { Name = "Адамантиевые когти", IsRanged = false },
            InternalNotes = "Лучший у меня есть" 
        },
        new Hero {
            Id = 7,
            Name = "Дэдпул",
            RealName = "Уэйд уилсон",
            Universe = Universe.Marvel,
            PowerLevel = 80,
            Powers = new() { "регенерация", "владение оружием", "болтовня" },
            Weapon = new() { Name = "Катаны и пистолеты", IsRanged = true },
            InternalNotes = "Разрушает четвертую стену" 
        },
    };
}