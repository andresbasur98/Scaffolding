using Scaffolding.Data;
using Scaffolding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scaffolding.Repositories
{
    public class RepositoryPaises
    {

        private PaisesContext context;

        public RepositoryPaises(PaisesContext context)
        {
            this.context = context;
        }

        public List<Pais> GetPaises()
        {
            var consulta = from datos in this.context.Paises
                           select datos;
            return consulta.ToList();
        }

        public Pais GetPais(int idpais)
        {
            var consulta = from datos in this.context.Paises
                           where datos.IdPais == idpais
                           select datos;
            if(consulta.Count() == 0)
            {
                return null;
            }
            else
            {
                return consulta.First();
            }
        }

        public void InsertarPais(int idpais, String nombre, String capital, String idioma)
        {
            Pais pais = new Pais();
            pais.IdPais = idpais;
            pais.Nombre = nombre;
            pais.Capital = capital;
            pais.Idioma = idioma;
            this.context.Paises.Add(pais);
            this.context.SaveChanges();
        }

        public void EliminarPais(int idpais)
        {
            Pais pais = this.GetPais(idpais);

            this.context.Paises.Remove(pais);

            this.context.SaveChanges();
        }

        public void ModificarPais(int idpais, String nombre, String capital, String idioma)
        {
            Pais pais = this.GetPais(idpais);
            pais.Nombre = nombre;
            pais.Capital = capital;
            pais.Idioma = idioma;
            this.context.SaveChanges();
        }

    }
}
