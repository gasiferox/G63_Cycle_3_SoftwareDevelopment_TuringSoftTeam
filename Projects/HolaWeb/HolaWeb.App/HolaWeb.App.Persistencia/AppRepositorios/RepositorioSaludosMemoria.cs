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

        public Saludo Update(Saludo saludoActualizado)
        {
            var saludo = saludos.SingleOrDefault<Saludo>(r => r.IdSaludo == saludoActualizado.IdSaludo);
            if (saludo != null)
            {
                saludo.Spanish = saludoActualizado.Spanish;
                saludo.English = saludoActualizado.English;
                saludo.Italian = saludoActualizado.Italian;
                saludo.German = saludoActualizado.German;
                saludo.Japanese = saludoActualizado.Japanese;
            }
        return saludo;
        }

        public Saludo Add(Saludo nuevoSaludo)
        {
            nuevoSaludo.IdSaludo = saludos.Max(r => r.IdSaludo) + 1;
            saludos.Add(nuevoSaludo);
            return nuevoSaludo;
        }
    }
}