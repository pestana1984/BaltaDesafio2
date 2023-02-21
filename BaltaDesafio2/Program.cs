internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe sua altura");
        float altura = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe seu peso");
        float peso = float.Parse(Console.ReadLine());

        float imc = peso/(altura*2);

        Console.WriteLine("Seu IMC é: " +imc.ToString("F2"));

        if(imc <= 16)
        {
            Console.WriteLine("Magreza Grau III");
        }
        else
        {
            if(imc <= 16.9)
            {
                Console.WriteLine("Magreza Grau II");
            }
            else{
                if (imc <= 18.4)
                {
                    Console.WriteLine("Magreza Grau I");
                }
                else
                {
                    if (imc <= 24.9)
                    {
                        Console.WriteLine("Eutrofia");
                    }
                    else
                    {
                        if (imc <= 29.9)
                        {
                            Console.WriteLine("Sobrepeso\nRisco: Aumentado");
                        }
                        else
                        {
                            if (imc <= 34.9)
                            {
                                Console.WriteLine("Obesidade Grau I\nRisco: Moderado");
                            }
                            else
                            {
                                if (imc <= 40)
                                {
                                    Console.WriteLine("Obesidade Grau II\nRisco: Grave");
                                }
                                else
                                {
                                    Console.WriteLine("Obesidade Grau III\nRisco: Muito Grave");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}