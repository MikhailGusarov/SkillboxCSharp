using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Example_2010
{
    class Program
    {
        static void Main(string[] args)
        {
            // Тема. ASP.NET Core ч.1
            // Ролик 1. Общие понятия. Архитектура ASP.NET Core. Первый проект
            // Ролик 2. Конфигурирование проекта
            // Ролик 3. Добавление HTML и CSS содержимого
            // Ролик 4. Элементы управления
            // Ролик 5. Добашнее задание

            #region 



            // История 
            // 1996 начало
            // 2002 - 2009 ASP.NET, MVC
            // 2016 ASP.NET Core

            // ASP.NET Core – кросс-платформенная технология для разработки веб-приложений и сервисов
            // - Язык C#
            // - Windows, Mac OS, Linux, https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/linux-apache?view=aspnetcore-2.2
            // - Open Source, https://github.com/aspnet/AspNetCore
            // - Удобная работа с БД
            // - Репозиторий NuGet, https://docs.microsoft.com/ru-ru/nuget/what-is-nuget

            // Клиент-серверная архитектура (Запросы - ответы)

            // Типы запросов:
            // GET - запрашивает представление ресурса. Запросы с использованием этого метода могут только извлекать данные
            // POST - используется для отправки сущностей к определённому ресурсу.
            //        Часто вызывает изменение состояния или какие-то побочные эффекты на сервере
            // PUT - заменяет все текущие представления ресурса данными запроса
            // DELETE - удаляет указанный ресурс

            // HEAD - запрашивает ресурс так же, как и метод GET, но без тела ответа
            // и др. CONNECT, OPTIONS, TRACE, PATCH

            // Демонстрация https://skillbox.ru/

            // Сервер сообщает клиенту результат запроса используя статус-коды
            // HttpStatusCode
            // 1хх - информационные
            // 2хх - успешные запросы
            // 3хх - перенаправление
            // 4хх - ошибка на стороне клиента
            // 5хх - ошибка на сервере

            // HttpStatusCode

            // Компоненты vs.png

            #endregion

        }
    }
}
