﻿namespace ProjetoCrud;
public readonly struct Cpf
{
    public readonly string Valor;
    private Cpf(string possivelCPF)
    {
        Valor = Utilidades.ValorCpfEhValido(possivelCPF) ? Utilidades.FormateCpf(possivelCPF) : "inválido";
    }

    public static implicit operator string(Cpf cpf) => cpf.Valor;
    public static explicit operator Cpf(string v) => new(v);
}