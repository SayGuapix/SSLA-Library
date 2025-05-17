namespace LibreriaUniversitaria.ENTITIES
{
    public class Multa
    {
        public string idUsuario { get; set; }
        public int dias_retraso { get; set; }
        public decimal monto { get; set; }
        public bool estado_pago { get; set; }
    }
}
