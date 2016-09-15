using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Service
{
    public interface IClientService
    {
        IEnumerable<mstr_client> GetAll();
        mstr_client Get(int ID);
        mstr_client Add(mstr_client input);
        void Remove(int ID);
        bool Update(mstr_client input);
    }
}
