using Diksi.API.Models;
using DNS.API.Models;
using DNS.Context.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNS.Context.Contracts.Models
{
    public class Tovar : BaseEntyty
    {
        /// <summary>
        /// Наименование товара
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Единица измерения
        /// </summary>
        public string Edizmer { get; set; } = string.Empty;

        /// <summary>
        /// Количество
        /// </summary>
        public int Value { get; set; }
    }
}
