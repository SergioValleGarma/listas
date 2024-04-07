// See https://aka.ms/new-console-template for more information

int[] notas = new int[5];

List<string> asistente = new List<string>();

void Ingresar()
{
    int cantidad = 0;
    Console.WriteLine("Ingrese cantidad de notas");
    cantidad = Convert.ToInt32(Console.ReadLine());
    //arreglos
    notas = new int[cantidad];

    for (int i = 0; i < notas.Length; i++)
    {
        int numeroNotas = i + 1;
        Console.WriteLine("Ingrese nota "+ numeroNotas);
        notas[i] = Convert.ToInt32(Console.ReadLine());
    }
}

Ingresar();
/////carga inicial


