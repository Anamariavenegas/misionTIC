using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEstaciones
    {
        List<Estaciones> estaciones;
 
    public RepositorioEstaciones()
        {
            estaciones= new List<Estaciones>()
            {
                new Estaciones{id=1,nombre="Portal",direccion= "Norte",coord_x= 1,coord_y= 10,tipo= "Base"},
                new Estaciones{id=2,nombre="Portal",direccion= "Sur",coord_x= 10,coord_y= 1,tipo= "Base"},
                new Estaciones{id=3,nombre="Portal_80",direccion= "Occidente",coord_x= 4,coord_y= 2,tipo= "Base"}
 
            };
        }
 
        public IEnumerable<Estaciones> GetAll()
        {
            return estaciones;
        }
 
        public Estaciones GetEstacionWithId(int id){
            return estaciones.SingleOrDefault(b => b.id == id);
        }
        public Estaciones Create(Estaciones newEstacion)
        {
           newEstacion.id=estaciones.Max(r => r.id) +1; 
           estaciones.Add(newEstacion);
           return newEstacion;
        }

        public Estaciones Update(Estaciones newEstacion){
            var estacion= estaciones.SingleOrDefault(b => b.id == newEstacion.id);
            if(estacion != null){
                estacion.nombre = newEstacion.nombre;
                estacion.direccion = newEstacion.direccion;
                estacion.coord_x = newEstacion.coord_x;
                estacion.coord_y = newEstacion.coord_y;
                estacion.tipo = newEstacion.tipo;
            }
        return estacion;
        }
        public Estaciones Delete(int id)
        {
        var estacion= estaciones.SingleOrDefault(b => b.id == id);
        estaciones.Remove(estacion);
        return estacion;
        }

    }
}
