// Non-nullable y default
int edad = default(int);
Console.WriteLine($"Éste es un entero por defecto: {edad}");

bool variableBooleana = default(bool);
Console.WriteLine($"Ésta es una variable booleana por defecto: {variableBooleana}");

decimal precio = default(decimal); //base 10 -> valor más preciso y es recomendable
                                        //para operaciones con dinero.
Console.WriteLine($"Éste es un décimal por defecto: {precio}");

DateTime fecha = default(DateTime);
Console.WriteLine($"Ésta es una variable de tipo DateTime por defecto: {fecha}");

//El valor por defecto de un string es null
string? nombre = null;
Console.WriteLine($"Éste es un string por defecto: {nombre}");
//Console.WriteLine(nombre.ToUpper());

// Desbordamiento de memoria (overflow) y cómo evitarla
int maxValue = int.MaxValue;
Console.WriteLine(maxValue + 1); //desbordamiento de la memoria
Console.WriteLine(checked(maxValue + 1)); //advertencia de overflow

checked //advertencia de desbordamiento de memoria
{
    int maxValue2 = int.MaxValue;
    Console.WriteLine(maxValue2 + 1);
}

