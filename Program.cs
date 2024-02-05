using System.Globalization;

Console.WriteLine("Defina quantos alunos há na turma: ");
int tamanho = int.Parse(Console.ReadLine());
double[] notas = new double[tamanho];

for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine("Digite a nota do aluno" + (i + 1) + ":");
    notas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

}

double media = calcularMedia(notas);

Console.WriteLine("Média das notas é: " + media);

static double calcularMedia(double[] notas){
    double soma = 0;
    for (int i = 0; i < notas.Length; i++){
        soma += notas[i];
    }
    return soma/notas.Length;
}    
