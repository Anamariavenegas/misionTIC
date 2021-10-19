//base para crear las clases
using System;
using System.ComponentModel.DataAnnotations;
namespace ProyectoCiclo3.App.Dominio
{
    public class Rutas{
        public int id {get;set;}
        [Required]
        public Estaciones origen {get;set;}
        [Required]
        public Estaciones destino {get;set;}
        [Required]
        public int tiempo_estimado {get;set;}
    }
}