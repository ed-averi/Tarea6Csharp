using Leccion6TareaCSharp.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Leccion6TareaCSharp
{
    public  class Program
    {
        static void Main(string[] args)
        {

            List<Alumno> alumnos = new() 
            {

                new("10076559", "Henry Estuardo", "Marquez Fernandez", DateTime.Parse("1988/07/04"), 1),
                new("10076560", "Edgar Rodolfo", "Gonzalez Martinez", DateTime.Parse("1988/07/04"), 2),
                new("10076561", "Jose Maria", "Gutierrez Gonzalez", DateTime.Parse("1988/07/04"), 2),
                new("10076562", "Paulina Estefany", "Fernandez Martinez", DateTime.Parse("1988/07/04"), 1),
                new("10076563", "Maria Fernanda", "Davila Archila", DateTime.Parse("1988/07/04"), 1),
                new("10076564", "Madelyn Haydee", "Berduo Urrutia", DateTime.Parse("1988/07/04"), 3),
                new("10076565", "Mayerli Isabel", "Puac Avila", DateTime.Parse("1988/07/04"), 3),
                new("10076566", "Carmen Elizabeth", "Flores Martinez", DateTime.Parse("1988/07/04"), 3),
                new("10076567", "Hector Ivan", "Mardoqueo Pa", DateTime.Parse("1988/07/04"), 3),
                new("10076568", "Jelena Ivanka", "Serovic Ramazzini", DateTime.Parse("1988/07/04"), 3),
                new("10076569", "Maia Jose", "Godoy Sagarminaga", DateTime.Parse("1988/07/04"), 3),
            };
            SerializarDatosXml(alumnos);
            SerializarDatosJson(alumnos);
            DeserializeDatosXml(alumnos);
        }
        public static void listadoAlumnos()
        {
        }
        public static void SerializarDatosXml(List<Alumno> alumnos)
        {
            string archivoXML = @"C:\DatosAlumnos\Alumnos.xml"; 
            XmlSerializer escritor = new(alumnos.GetType());  



            using (FileStream fs = File.Create(archivoXML)) 
            {
                escritor.Serialize(fs, alumnos); 
            }


            string xmlSerializado = string.Empty; 
            using (StringWriter sw = new StringWriter())
            {
                xmlSerializado = sw.ToString();  
                escritor.Serialize(sw, alumnos);  
            }
            Console.WriteLine(xmlSerializado); 

        }

        public static void SerializarDatosJson(List<Alumno> alumnos)
        {


            Console.WriteLine("\n\n------------Serializar Datos Json String-------------------");
            string json = JsonSerializer.Serialize(alumnos); 
            Console.WriteLine(json);
        }

        public static void DeserializeDatosXml(List<Alumno> alumnos)
        {
            string archivoXML = @"C:\DatosAlumnos\Alumnos.xml";  
            using (FileStream cargarXML = File.Open(archivoXML, FileMode.Open))
            {
                XmlSerializer lector = new(typeof(List<Alumno>)); 
                List<Alumno> Alumnos = lector.Deserialize(cargarXML) as List<Alumno>;
            }

            int cont = 1;

            Console.WriteLine("\n\n------------------Muestra los datos de la lista Alumnos ---------------------");

            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine($"Alumno Numero {cont++}: {alumno.Carne}, {alumno.Nombre}, {alumno.Apellido},{alumno.FechaNac}, {alumno.ClaseAsignada}");
            }

        }
    }
    
}
