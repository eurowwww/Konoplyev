using DNS.API.Models;
using DNS.Context;
using DNS.Context.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNS.Context
{
    public class SVContext : IContext
    {
        private ICollection<Nakladnaya> nakladnayas;
        private ICollection<Pokupatel> pokupatels;
        private ICollection<Postavshik> postavshiks;
        private ICollection<Tovar> tovars;

        public SVContext()
        {
            nakladnayas = new HashSet<Nakladnaya>();
            pokupatels = new HashSet<Pokupatel>();
            postavshiks = new HashSet<Postavshik>();
            tovars = new HashSet<Tovar>();
            Seed();
        }
        public ICollection<Nakladnaya> Nakladnayas => nakladnayas;

        public ICollection<Pokupatel> Pokupatels => pokupatels;

        public ICollection<Postavshik> Postavshiks => postavshiks;

        public ICollection<Tovar> Tovars => tovars;


        private void Seed()
        {
            /// <summary>
            /// Информация накладной
            /// </summary>
            Nakladnayas.Add(new Nakladnaya
            {
                Id = Guid.NewGuid(),
                Name = "ООО <НАР>",
                Description = "Накладная № 12324563213 от «10» Августа 2023г.\r\nПродавец: ООО Кижар, ИНН 12121213124\r\nАдрес продавца: Энгельса 72\r\nПокупатель: ИП Нарышкин, ИНН 12121213124, КПП 342423\r\nАдрес покупателя: Богатырский 49"
            });
            Nakladnayas.Add(new Nakladnaya
            {
                Id = Guid.NewGuid(),
                Name = "ДНС",
                Description = "Накладная № 12343433234 от «29» Декабря 2023г.\\r\\nПродавец: ООО Кижар, ИНН 1213123323\\r\\nАдрес продавца: Фрунзенская 17\\r\\nПокупатель: ИП Михейко, ИНН 12343433234, КПП 1133322\\r\\nАдрес покупателя: Невский пр 17\""
            });
            /// <summary>
            /// Информация покупателя
            /// </summary>
            Pokupatels.Add(new Pokupatel
            {
                Id = Guid.NewGuid(),
                Name = "Даниил",
                Number = 891102774,
                Adres = "Приморский район Богатырский 2а",
                Index = 8757874,
                Email = "barbar@mail.ru"
            });
            Pokupatels.Add(new Pokupatel
            {
                Id = Guid.NewGuid(),
                Name = "Стас",
                Number = 893344563,
                Adres = " ул. Коменданский 56",
                Index = 87433874,
                Email = "baraban@mail.ru"
            });
            Postavshiks.Add(new Postavshik
            {
                Id = Guid.NewGuid(),
                Email = "bububu@mail.ru",
                Name = "Иван",
                Adres = "СПБ Фрунзенская 17",
                Index = 147318,
                Inn = 1234567812,
                RS = 43434234
            });
            Postavshiks.Add(new Postavshik
            {
                Id = Guid.NewGuid(),
                Email = "mouseD4@mail.ru",
                Name = "Dark project",
                Adres = "Санкт-Петербург, ул. Пушкинская 19",
                Index = 112334,
                Inn = 1235675,
                RS = 4575674
            });
            Tovars.Add(new Tovar
            {
                Id = Guid.NewGuid(),
                Name = "Мышь DarkProject ME4",
                Edizmer = "5",
                Value = 6000
            });
            Tovars.Add(new Tovar
            {
                Id = Guid.NewGuid(),
                Name = "микрофон Maono DM30",
                Edizmer = "87",
                Value = 3299
            });
        }
    }
}
