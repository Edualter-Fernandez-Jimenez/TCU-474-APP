namespace Datos.Models
{
    public class Direccion

    {
        public int Id { get; set; }
        public string OtrasSenas { get; set; }
        public int IdProvincia { get; set; }
        public int IdCanton { get; set; }
        public int IdDistrito { get; set; }

        public Direccion(int Id, string OtrasSenas, int IdProvincia, int IdCanton, int IdDistrito)
        {
            this.Id = Id;
            this.OtrasSenas = OtrasSenas;
            this.IdProvincia = IdProvincia;
            this.IdCanton = IdCanton;
            this.IdDistrito = IdDistrito;
        }
        public Direccion() { }
    }
}
