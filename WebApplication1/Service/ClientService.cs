using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Service
{
    public class ClientService : IClientService
    {
        protected WebEntities dbCon;

        public ClientService()
        {
            dbCon = new WebEntities();
        }

        public IEnumerable<mstr_client> GetAll()
        {
            return dbCon.mstr_client.AsEnumerable();
        }

        public mstr_client Get(int ID)
        {
            return dbCon.mstr_client.Where(o => o.ID == ID).SingleOrDefault();
        }

        public mstr_client Add(mstr_client input)
        {
            var ToUpdate = dbCon.mstr_client.Where(o => o.ID == input.ID).SingleOrDefault();
            if (ToUpdate != null)
            {
                ToUpdate = input;
                dbCon.SaveChanges();
                return ToUpdate;
            }
            else
                return null;
        }

        void Remove(int ID) {
        }
        
        bool Update(mstr_client input) {
            return false;
        }

    }
}