﻿using System;
using System.Collections.Generic;
using System.Text;
using PizzaDelivery.Domain.Models.Orders;
using PizzaDelivery.Domain.Models.Persons;

namespace PizzaDelivery.Domain
{
    internal class DBInitializer
    {
        private static bool _isInit = false;

        public static void Initialize(PizzaDeliveryDBContext context)
        {
            if (!_isInit)
            {
                InitPizzas(context);
                InitClients(context);
                InitEmployees(context);
                context.SaveChanges();
                _isInit = true;
            }
        }

        private static void InitPizzas(PizzaDeliveryDBContext context)
        {
            context.Add(new Pizza()
            {
                Id = Guid.NewGuid(),
                Name = "Барбекю",
                Recipe = "Пицца с ветчиной, беконом, пепперони, болгарским перцем и томатным соусом для ценителей мясных деликатесов",
                Cost = 410
            });
            context.Add(new Pizza()
            {
                Id = Guid.NewGuid(),
                Name = "Гавайская",
                Recipe = "Волшебное сочетание нежного куриного мяса, ананасов и спелой груши.",
                Cost = 335
            });
            context.Add(new Pizza()
            {
                Id = Guid.NewGuid(),
                Name = "Карбонара",
                Recipe = "Итальянский колорит бекона, сыра, грибов и красного лука",
                Cost = 340
            });
            context.Add(new Pizza()
            {
                Id = Guid.NewGuid(),
                Name = "Маргарита",
                Recipe = "Пицца с классическим сочетанием томатов и сыра",
                Cost = 255
            });
            context.Add(new Pizza()
            {
                Id = Guid.NewGuid(),
                Name = "Мексиканская",
                Recipe = "Острая мексиканская пицца с куриной грудкой, кукурузой, сыром, вялеными томатами и перчиком халапеньо",
                Cost = 330
            });
            context.Add(new Pizza()
            {
                Id = Guid.NewGuid(),
                Name = "Филадельфия",
                Recipe = "Лосось,сливочный сыр,икра.",
                Cost = 600
            });
        }

        private static void InitClients(PizzaDeliveryDBContext context)
        {
            context.Add(new Client()
            {
                Id = Guid.NewGuid(),
                Person = new Person
                {
                    Id = Guid.NewGuid(),
                    FIO = "Alexander",
                    Birthday = new DateTime(1990, 3, 13),
                    Email = "email1@mail.ru",
                    PhoneNumber = "230-23-23",
                    Login = "asd32",
                    Password = @" ,�b�Y[�K-#Kp",
                    Address = "Street 21"
                },
                BonusCount = 0
            });
            context.Add(new Client()
            {
                Id = Guid.NewGuid(),
                Person = new Person
                {
                    Id = Guid.NewGuid(),
                    FIO = "Mihail",
                    Birthday = new DateTime(1994, 11, 21),
                    Email = "email2@mail.ru",
                    PhoneNumber = "153-11-23",
                    Login = "qwe",
                    Password = "321"
                },
                BonusCount = 100
            });
            context.Add(new Client()
            {
                Id = Guid.NewGuid(),
                Person = new Person
                {
                    Id = Guid.NewGuid(),
                    FIO = "Anonymous",
                    Birthday = new DateTime(1994, 11, 21),
                    Email = "Anonymous@mail.ru",
                    PhoneNumber = "153-11-23",
                    Login = "Anonymous",
                    Password = "Anonymous"
                },
                BonusCount = 0
            });
        }

        private static void InitEmployees(PizzaDeliveryDBContext context)
        {
            context.Add(new Employee()
            {
                Id = Guid.NewGuid(),
                Person = new Person
                {
                    Id = Guid.NewGuid(),
                    FIO = "Vladislav",
                    Birthday = new DateTime(1995, 5, 13),
                    Email = "email3@mail.ru",
                    PhoneNumber = "563-23-32"
                },
                HireDate = new DateTime(2010, 2, 1),
                PostName = "Operator"
            });
            context.Add(new Employee()
            {
                Id = Guid.NewGuid(),
                Person = new Person
                {
                    Id = Guid.NewGuid(),
                    FIO = "Alexander",
                    Birthday = new DateTime(1998, 1, 9),
                    Email = "email4@mail.ru",
                    PhoneNumber = "123-54-65"
                },
                HireDate = new DateTime(2012, 12, 1),
                PostName = "Deliveryman"
            });
        }
    }
}
