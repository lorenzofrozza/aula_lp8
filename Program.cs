int quit= 1; //interando valor de saída

while(quit!=0) //lopping para gerar relatórios
{
Console.WriteLine(""); //estilizando
Console.WriteLine("\n-- Relatório de Notas --");  //estilizando

Console.Write("\nDigite seu nome: "); 
string name = Console.ReadLine(); //coletando nome
double plus= 0; //interando valores as variáveis
double grade1 = 0; 
double grade2 = 0; 
double grade3 = 0;

Console.WriteLine("");
    for (int i = 1; i <=3; i++) //looping para coletar as notas 
{
        Console.Write($"Digite sua {i}° nota: ");
            double grade = double.Parse(Console.ReadLine()); 
            plus+=grade; //iterando os valores a soma
        
            if (i==1) //condicões criadas para iterar valores as notas na hora certa
            {
                grade1+=grade; //iterando os valores
            }
            if (i==2)
            {
                grade2+=grade;
            }
            if (i==3)
            {
                grade3+=grade;
            }

    }

double average= plus/3; //cálculo da média

    if (average <7) //condição para print do desempenho de reprovados
{
    Console.WriteLine("");
    Console.WriteLine("\n-- Relatório de Desempenho --");
    Console.WriteLine($"\n{name} suas notas foram, \n1°= {grade1} \n2°= {grade2} \n3°= {grade3}, sua média final foi {average:F2}, você está Reprovado.\n ");
}
else //condição para print do desempenho de aprovados
{
    Console.WriteLine("");
    Console.WriteLine("\n-- Relatório de Desempenho --\n");
    Console.WriteLine($"\n{name} suas notas foram, \n1°= {grade1} \n2°= {grade2} \n3°= {grade3}, sua média final foi {average:F2}, você está Aprovado.\n ");
}

Console.WriteLine("\n- Digite 1 para continuar gerando relatórios - \n- Digite 0 para sair - ");
Console.Write(" \n --> ");
quit =0;
int quit1 = Convert.ToInt32(Console.ReadLine()); //iterando valores para geração ou não geração de novos relatórios
quit+=quit1;

}
Console.WriteLine("");
