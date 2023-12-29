﻿using Diksi.API.Models;
using DNS.API.Models;
using DNS.Context.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNS.Context.Contracts.Models
{
    public class Postavshik : BaseEntyty
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// ИНН
        /// </summary>
        public int Inn { get; set; }

        /// <summary>
        /// Индекс
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// почта
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Адрес
        /// </summary>
        public string Adres { get; set; } = string.Empty;

        /// <summary>
        /// Расчетный счет
        /// </summary>
        public int RS { get; set; }
    }
}
