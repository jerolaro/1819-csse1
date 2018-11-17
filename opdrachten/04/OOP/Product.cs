class Product {
    // Fields
    private string name;
    private string type;
    private string[] ingredienten;

    // Properties
    public string Name {get; set;}
    public string Type {get; set;}
    public string[] Ingredienten {get; set;}

    // Methods

    // Constructors
    public Product() {}

    public Product(string name, string type)
    {
        this.name = name;
        this.type = type;
    }

    public Product(string name, string type, string[] ingredienten)
    {
        this.name = name;
        this.type = type;
        this.ingredienten = ingredienten;
    }

}