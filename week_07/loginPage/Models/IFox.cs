using System.Collections.Generic;

namespace loginPage.Models
{
    public interface IFox
    {
        List<Fox> ListOfFoxes { get; set; }
        List<Fox> AddFox(Fox fox);
        Fox FindFoxByName(string name);
        Fox GetCurrentFox();
        Fox SetCurrentFox(string name);
    }
}