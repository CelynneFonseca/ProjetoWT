using System;
using System.Collections.Generic;
using System.Text;

namespace WhereTo.Dominio.Entidades
{
    public class ItemDetalhes
    {
        public int Item_ID { get; set; }
        public string Item_Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Item_Preco { get; set; }
        public string Image_Nome { get; set; }
    }
}
