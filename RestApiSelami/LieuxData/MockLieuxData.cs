using RestApiSelami.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiSelami.LieuxData
{
    public class MockLieuxData : ILieuxData
    {
        private List<Lieux> lieuxs = new List<Lieux>()
        {
            new Lieux()
            { Id =Guid.NewGuid(), Name=" Gouraya " , Adresse=" bejaia" , Photo="gouraya", },

            new Lieux()
            {Id =Guid.NewGuid(), Name=" cap carbon " , Adresse="bejaia" ,Photo="cap" ,},


        };

        public Lieux AddLieux(Lieux lieux)
        {
            lieux.Id = Guid.NewGuid();
            lieuxs.Add(lieux);
            return lieux;
        }

        public void DeleteLieux(Lieux lieux)
        {
            lieuxs.Remove(lieux);
        }

        public Lieux EditLieux(Lieux lieux)
        {
            var existingLieux = GetLieux(lieux.Id);
            existingLieux.Name = lieux.Name;
            existingLieux.Adresse = lieux.Adresse;
            existingLieux.Photo = lieux.Photo;
            return existingLieux;
        }

        public Lieux GetLieux(Guid Id)
        {
            return lieuxs.SingleOrDefault(x => x.Id == Id);
        }

        public List<Lieux> GetLieuxs()
        { 
            return lieuxs;



        }
    }
}


