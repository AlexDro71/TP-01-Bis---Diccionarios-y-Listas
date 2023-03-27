Dictionary<string, int> recaudacionPorCurso = new Dictionary<string, int>();
int numIngresado = ingresarInt("1. Ingrese los importes de un curso\n2. Ver estadisticas\n3. Salir");
do
{
    switch (numIngresado)
    {

        case 1:
            {

                ingresarImportes(recaudacionPorCurso);
                break;
            }
        case 2:
            {
                verEstadisticas(recaudacionPorCurso);
                break;
            }
        case 3:
            {
                break;
            }

    }
    numIngresado = ingresarInt("1. Ingrese los importes de un curso\n2. Ver estadisticas\n3. Salir");
} while (numIngresado != 3);


static string ingresarString(string txt)
{
    string devolver;
    Console.WriteLine(txt);
    devolver = Console.ReadLine();
    return devolver;
}

static int ingresarInt(string txt)
{
    int devolver;
    Console.WriteLine(txt);
    devolver = int.Parse(Console.ReadLine());
    return devolver;
}

static void ingresarImportes(Dictionary<string, int> recaudacionPorCurso)
{
    int recaudacion = 0;
    int dinreoIngrsado = 0;
    string curso = ingresarString("Ingrese el nombre del curso: ");
    int alumnos = ingresarInt("Ingrese la cantidad de alumnos que hay en el curso");
    for (int i = 0; i < alumnos; i++)
    {
        dinreoIngrsado = ingresarInt("Ingrese la cantidad de dinero que va a importar: ");
        verificarValor(dinreoIngrsado);
        recaudacion += dinreoIngrsado;
        
    }
    recaudacionPorCurso.Add(curso, recaudacion);
}

static int verificarValor(int dinreoIngrsado)
{
    while(dinreoIngrsado == 0)
    {
        Console.WriteLine("El dinero ingresado no puede ser 0");
        dinreoIngrsado = ingresarInt("Ingrese la cantidad de dinero que va a importar:");        
    }
    return dinreoIngrsado;
}

static void verEstadisticas(Dictionary<string, int> recaudacionPorCurso)
{
    string mayorCurso = "";
    int cursoMayorRecaudacion = 0;
    int recaudacionTotal = 0;
    int cantCursos = 0;
    foreach (string clave in recaudacionPorCurso.Keys)
    {
        cantCursos++;
        recaudacionTotal += recaudacionPorCurso[clave];
        if (recaudacionPorCurso[clave] > cursoMayorRecaudacion)
        {
            cursoMayorRecaudacion = recaudacionPorCurso[clave];
            mayorCurso = clave;
        }
    }

    Console.WriteLine($"El curso que mas deposito fue el {mayorCurso} \nEntre todos los cursos se recaudo ${recaudacionTotal} \nEl promedio recudado por curso es de {recaudacionTotal / cantCursos} \nParticiparon {cantCursos} cursos en la recaudacion");

}