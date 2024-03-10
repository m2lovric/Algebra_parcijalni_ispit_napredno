using Ispit.Konzola.Sucelja;

namespace Ispit.Konzola;

public class PametniTelefon: IPametniTelefon
{
    public string Model { get; private set; }

    public PametniTelefon(string model)
    {
        Model = model;
    }

    public string Poziv(string telefonski_broj)
    {
        if (ProvjeriAkoJeValidanBroj(telefonski_broj))
        {
            return $"Evo zovem... {telefonski_broj}";    
        }
        
        return "Neispravan telefonski broj!";
    }

    public string Surfanje(string url)
    {
        if (ProvjeriAkoJeValidanUrl(url))
        {
            return $"Surfam na: {url}";    
        }
        
        return "Neispravan url!";
    }

    private bool ProvjeriAkoJeValidanUrl(string url)
    {
        var urlArr = url.ToCharArray();
        char[] nums = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];

        foreach (var c in urlArr)
        {
            foreach (var num in nums)
            {
                if (c.Equals(num))
                {
                    return false;
                }
            }
        }
        
        return true;
    }
    
    private bool ProvjeriAkoJeValidanBroj(string telefonski_broj)
    {
        var urlArr = telefonski_broj.ToCharArray();
        char[] nums = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
        
        foreach (var c in urlArr)
        {
            int index = Array.IndexOf(nums, c);

            if (index == -1)
            {
                return false;
            }
        }
        
        return true;
    }
}