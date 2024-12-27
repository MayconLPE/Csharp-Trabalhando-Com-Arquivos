internal class Program
{
    private static void Main(string[] args)
    {
        // var conta = ContaCorrente(524, 4518);

        var enderecoDoArquivo = @"M:\DEV\Csharp-Arquivos\contas.txt";
        var numeroDeBytesLidos = -1;
        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        var buffer = new byte[1024];

        while (numeroDeBytesLidos != 0)
        {
            // Read(byte[] array, int offset, int count);
            numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
            EscreverBuffer(buffer);
        }

    }

    static void EscreverBuffer(byte[] buffer)
    {
        foreach (var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }

    }
}