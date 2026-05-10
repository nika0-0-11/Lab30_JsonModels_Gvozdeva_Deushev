# Лабораторная работа №30. JSON и модели данных

---

## Основная информация

**ФИО:** Гвоздева В.А, Деушев Т.Т  
**Группа:** ИСП-231  
**Дата:** 07.04.2026  

---

## Таблица всех маршрутов

|Метод|Маршрут|
|:---|:-----|
|**GET**|`/api/Heroes`|
|**GET**|`/api/Heroes/{id}`|
|**GET**|`/api/Heroes/demo`|
|**GET**|`/api/Heroes/serialize`|
|**GET**|`/api/Heroes/search`|

---

## Таблица атрибутов JSON

|Атрибут / настройка|Что делает|Пример|
|:------------------|:---------|:-----|
|[JsonPropertyName("name")]|Задаёт имя поля в JSON|"name" вместо "Name"|
|[JsonIgnore]|Поле не попадает в JSON|Пароли, внутренние поля|
|PropertyNamingPolicy.CamelCase|Все поля в camelCase|"realName" вместо "RealName"|
|JsonStringEnumConverter|Enum как строка|"Marvel" вместо 0|
|WriteIndented = true|JSON с отступами|Для удобства при разработке|

---

## Главные выводы

1. **Сериализация** - это превращение C#-объекта в текстовую строку формата JSON.
**Десериализация** - обратный процесс сериализации.
2. **[JsonIgnore]** - поле не попадает в JSON
Пример:
```csharp
public class Hero {
    [JsonIgnore]
    public string? InternalNotes { get; set; }
}
```
3. **JsonStringEnumConverter** - **enum** сериализуется как строка. `Universe.Marvel -> "Marvel"` вместо 0. Это удобно - клиент сразу видит смысл значения
4. **CamelCase** - имена свойств в JSON будут в формате camelCase (`powerLevel` вместо `PowerLevel`)