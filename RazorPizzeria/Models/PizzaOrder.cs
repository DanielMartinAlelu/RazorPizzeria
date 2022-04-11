namespace RazorPizzeria.Models
{
    public class PizzaOrder
    {
        //Trabajamos con database y entity framework
        //Si cambias aqui atributos, lo tienes que cambiar en nuestra db tambien (tools, nuget package manager, package manager console)
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; }
    }
}
