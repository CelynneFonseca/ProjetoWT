using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WhereTo.Dominio.Entidades;

namespace WhereTo.Dados.Repositorio
{
    public class ItemDetalhesRepositorio : RepositorioBase<ItemDetalhes>
    {
        public IEnumerable<ItemDetalhes> Item_Nome()
        {
            return Contexto
                .ItemDetalhes
                .Where(f => f.Item_Nome == null);
        }

        public IEnumerable<ItemDetalhes> Descricao()
        {
            return Contexto
                .ItemDetalhes
                .Where(f => f.Descricao == null);
        }

        public IEnumerable<ItemDetalhes> Item_Preco()
        {
            return Contexto
                .ItemDetalhes
                .Where(f => f.Item_Preco == null);
        }

        public IEnumerable<ItemDetalhes> Image_Nome()
        {
            return Contexto
                .ItemDetalhes
                .Where(f => f.Image_Nome == null);
        }
    }
}
