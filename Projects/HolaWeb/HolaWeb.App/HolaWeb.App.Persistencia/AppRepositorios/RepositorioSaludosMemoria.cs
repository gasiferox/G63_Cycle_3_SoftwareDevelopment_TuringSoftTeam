using System.Collections;
using System.Collections.Generic;
using HolaWeb.App.Dominio.Entity;
using System.Linq;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioSaludosMemoria : IRepositorioSaludos
    {
        List<Saludo> saludos;
        public RepositorioSaludosMemoria()
        {
            this.saludos = new List<Saludo>()
            {
                new Saludo{IdSaludo=1, Spanish="Buenos días", English="Good morning", Italian="Buongiorno", German="Guten morgen", Japanese="おはよう"},
                new Saludo{IdSaludo=2, Spanish="Buenas tardes", English="Good afternoon", Italian="Buon pomeriggio", German="Guten Nachmittag", Japanese="こんにちは"},
                new Saludo{IdSaludo=3, Spanish="Buenas noches", English="Good evening", Italian="Buona serata", German="Guten Abend", Japanese="こんばんは"}
            };
        }
        public IEnumerable<Saludo> GetAll()
        {
            return saludos;
        }

        public Saludo GetSaludoPorId(int IdSaludo)
        {
            return saludos.SingleOrDefault(s => s.IdSaludo == IdSaludo);
        }
    }
}