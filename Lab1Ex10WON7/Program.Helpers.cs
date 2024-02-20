partial class Program
{
    static string ReadNumber(uint numarCifre)
    {
        Console.WriteLine("Scrieti un numar de la tastatura pentru ai afisa suma cifrelor");
        var numarRaw=Console.ReadLine();
        if (numarRaw?[0].ToString()=="-")
            numarRaw=numarRaw[1..];
        if(numarRaw?.Length!=numarCifre || !int.TryParse(numarRaw, out _))
        {
            Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
            return ReadNumber(numarCifre);
        }
        return numarRaw;
    }
    static int ComputeSum(string numarRaw)
    {
        int suma = default;
        foreach (var cifraRaw in numarRaw)
            suma += int.Parse(cifraRaw.ToString());
        return suma;
    }
    static void ShowSum(int suma)
    {
        Console.WriteLine($"Suma cifrelor este {suma}");
    }
}