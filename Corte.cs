Corte.cs
Public class Corte : Cliente
{
    string NomeCortador;
    int Quantidade;

    Public void SetNomeCortador(string NomeCortador)
{
    thisNomeCortador= NomeCortador;
}
Public string GetNomeCortador()
{
    return NomeCortador;
}
Public void SetQuantidade(int Quantidade)
{
    thisQuantidade= Quantidade;
}
Public int GetQuantidade()
{
    return Quantidade;
}
}