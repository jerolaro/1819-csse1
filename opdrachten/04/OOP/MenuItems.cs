class MenuItem : Product
{
    // Fields
    private double waarde;
    private string valuta;

    // Properties
    public double Waarde {get; set;}
    public string Valuta {get; set;}

    // Methods
    public string ToString()
    {
        string productString =  "Het item " + this.Naam + " (" + this.Type;
        string prijsString = ") kost " + this.Waarde + " " + this.Valuta + ".";
        string ingredient = "De ingredienten zijn ";

        try {
            int length = this.Ingredienten.Length;
            for(int i = 0; i < length; i++) {
                ingredient += this.Ingredienten[i];
                if(i < length - 1) {
                    ingredient += ", ";
                }
                if(i == length-1) {
                    ingredient += '.';
                }
            }
        }
        catch(System.NullReferenceException) {
            ingredient += "onbekend.";
        }
        return productString + prijsString + ingredient;
    }

    // Constructors
    public MenuItem() {}
    
    public MenuItem(string naam, string type, double waarde, string valuta)
    {
        this.Name = naam;
        this.Type = type;
        this.Waarde = waarde;
        this.Valuta = valuta;
    }

    public MenuItem(string naam, string type, string[] ingredienten, double waarde, string valuta) 
    {
        this.Name = naam;
        this.Type = type;
        this.Ingredienten = ingredienten;
        this.Waarde = waarde;
        this.Valuta = valuta;
    }
}