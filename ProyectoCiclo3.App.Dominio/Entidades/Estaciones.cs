//base para crear las clases
using System;
using System.ComponentModel.DataAnnotations;
namespace ProyectoCiclo3.App.Dominio
{
    public class Estaciones{
        public int id {get;set;}
        [Required]
        public string nombre {get;set;}
        [Required]
        public string direccion {get;set;}
        [Required]
        public float coord_x {get;set;}
        [Required]
        public float coord_y {get;set;}
        [Required]
        public string tipo {get;set;}
    }
}