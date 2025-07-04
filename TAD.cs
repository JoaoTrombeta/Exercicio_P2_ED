using System;

public class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; }
    public int CargaHorariaSemanal { get; set; }
    public DateTime DataAdmissao { get; set; }

    public Funcionario(string nome, string cargo, double salario, int cargaHoraria, DateTime dataAdmissao)
    {
        Nome = nome;
        Cargo = cargo;
        Salario = salario;
        CargaHorariaSemanal = cargaHoraria;
        DataAdmissao = dataAdmissao;
    }

    [cite_start]
    [cite_start]public void AumentoSalarialPorPromocaoEmValor(double valorAumento) [cite: 8, 10]
    {
        if (valorAumento > 0)
        {
            Salario += valorAumento;
            Console.WriteLine($"Salário de {Nome} aumentado em R${valorAumento:F2}. Novo salário: R${Salario:F2}.");
        }
        else
        {
            Console.WriteLine("O valor de aumento deve ser positivo.");
        }
    }

    [cite_start]public void Promover(string novoCargo, double valorAumento) [cite: 9]
    {
        Console.WriteLine($"{Nome} foi promovido(a) de {Cargo} para {novoCargo}.");
        Cargo = novoCargo;
        AumentoSalarialPorPromocaoEmValor(valorAumento);
    }

    [cite_start]public void DescontoSalarialPorFaltaEmValor(double valorDesconto) [cite: 11]
    {
        if (valorDesconto > 0 && Salario >= valorDesconto)
        {
            Salario -= valorDesconto;
            Console.WriteLine($"Desconto de R${valorDesconto:F2} aplicado no salário de {Nome} por falta. Novo salário: R${Salario:F2}.");
        }
        else if (valorDesconto <= 0)
        {
            Console.WriteLine("O valor de desconto deve ser positivo.");
        }
        else
        {
            Console.WriteLine("O valor de desconto é maior que o salário atual.");
        }
    }

    [cite_start]public void AumentarCargaHorariaDeTrabalho(int horasAdicionais, double reajustePorHora) [cite: 12]
    {
        if (horasAdicionais > 0)
        {
            CargaHorariaSemanal += horasAdicionais;
            double aumentoSalario = horasAdicionais * reajustePorHora;
            Salario += aumentoSalario;
            Console.WriteLine($"Carga horária de {Nome} aumentada em {horasAdicionais} horas. Nova carga horária: {CargaHorariaSemanal}h/semana.");
            Console.WriteLine($"Salário reajustado em R${aumentoSalario:F2}. Novo salário: R${Salario:F2}.");
        }
        else
        {
            Console.WriteLine("O número de horas adicionais deve ser positivo.");
        }
    }

    [cite_start]public void Imprimir() [cite: 14]
    {
        Console.WriteLine("\n--- Dados do Funcionário ---");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Salário: R${Salario:F2}");
        Console.WriteLine($"Carga Horária Semanal: {CargaHorariaSemanal}h");
        Console.WriteLine($"Data de Admissão: {DataAdmissao.ToShortDateString()}");
        Console.WriteLine("---------------------------\n");
    }
}

