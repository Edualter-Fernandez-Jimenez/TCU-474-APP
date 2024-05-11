using System.Collections;
using System.IO;
using ConsoleApp1;
using Newtonsoft.Json;
using static Program;

class Program
{
   static List<ProvinciaBD> listaProvincias = new List<ProvinciaBD>();
    static List<DistritoBD> listaDistritos = new List<DistritoBD>();
    static List<CantonBD> listaCantones = new List<CantonBD>();
    static void Main(string[] args)
    {
        DBConnection _db = new DBConnection();
        listaProvincias.Add(new ProvinciaBD(1,"San José"));
        listaProvincias.Add(new ProvinciaBD(2, "Alajuela"));
        listaProvincias.Add(new ProvinciaBD(3, "Cartago"));
        listaProvincias.Add(new ProvinciaBD(4, "Heredia"));
        listaProvincias.Add(new ProvinciaBD(5, "Guanacaste"));
        listaProvincias.Add(new ProvinciaBD(6, "Puntarenas"));
        listaProvincias.Add(new ProvinciaBD(7, "Limón"));

        int provID = 0;
        int cantID = 0;
        string filePath = "D:\\Root\\Users\\Edu\\Downloads\\apps\\provincias_cantones_distritos_costa_rica.json"; // Ruta al archivo JSON en tu computadora
                                                                                                   // Verificar si el archivo existe
        if (File.Exists(filePath))
        {
            string jsonContent = File.ReadAllText(filePath);

            RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(jsonContent);

            if (rootObject != null)
            {
                // Ahora puedes acceder a los datos deserializados
                foreach (var provinciaEntry in rootObject.Provincias)
                {
                    int idProvincia = int.Parse(provinciaEntry.Key.ToString());
                    string nombreProvincia = provinciaEntry.Value.ToString();
                    provID++;

                    foreach (var cantonEntry in provinciaEntry.Value.Cantones)
                    {
                        string aux = cantonEntry.Key;
                        string idDef = provID + "" + aux;  
                        int idCanton = int.Parse(idDef);
                        cantID = idCanton;
                        string nombreCanton = cantonEntry.Value.Nombre;
                        listaCantones.Add(new CantonBD(idCanton,nombreCanton));

                        foreach (var distritoEntry in cantonEntry.Value.Distritos)
                        {
                            string aux2 = distritoEntry.Key;
                            string idDef2 = cantID + "" + aux2;
                            int idDistrito = int.Parse(idDef2);
                            string nombreDistrito = distritoEntry.Value;

                            listaDistritos.Add(new DistritoBD(idDistrito,nombreDistrito));
                        }
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("El archivo JSON no existe en la ruta especificada.");
        }

        foreach (ProvinciaBD provincia in listaProvincias)
        {
            _db.InsertData("Provincia", provincia.Id, provincia.Nombre);

        }
        foreach (DistritoBD distrito in listaDistritos)
        {
            _db.InsertData("Distrito", distrito.Id, distrito.Nombre);
        }
       foreach (CantonBD canton in listaCantones)
        {
            _db.InsertData("Canton", canton.Id, canton.Nombre);
        }
    }



    public class Distrito
    {
        public string Nombre { get; set; }
    }

    public class Canton
    {
        public string Nombre { get; set; }
        public Dictionary<string, string> Distritos { get; set; }
    }

    public class Provincia
    {
        public string Nombre { get; set; }
        public Dictionary<string, Canton> Cantones { get; set; }
    }

    public class RootObject
    {
        public Dictionary<string, Provincia> Provincias { get; set; }
    }
}
