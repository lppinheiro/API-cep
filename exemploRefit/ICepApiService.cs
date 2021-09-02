using Refit;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace exemploRefit
{
   public interface  ICepApiService
    {      [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);
    }
}
