using System.Collections.Generic;
using System.Linq;
using FodApi.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;  

using System.Text;  
using System.Threading.Tasks; 
namespace FodApi.Data
{
    public class DummyData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<FodContext>();
                context.Database.EnsureCreated();
                //context.Database.Migrate();

                // Look for any candidats
                if (context.Candidats != null && context.Candidats.Any())
                    return;   // DB has already been seeded

                var candidats = DummyData.GetCandidats(context).ToArray();
                context.Candidats.AddRange(candidats);
                context.SaveChanges();

                var candidatures = DummyData.GetCandidatures(context).ToArray();
                context.Candidatures.AddRange(candidatures);
                context.SaveChanges();

                var competences = DummyData.GetCompetences().ToArray();
                context.Competences.AddRange(competences);
                context.SaveChanges();
            }
        }

        public static List<Candidat> GetCandidats(FodContext db)
        {             
            List<Candidat> candidats = new List<Candidat>() {
            new Candidat {nom="Slim",prenom="Chaari",email="slim@gmail.com",cv="cv.pdf",experience=2,datenaissance=DateTime.Now,
            candidature  = new List<Candidature>(db.Candidatures.Take(2)),
            },
            

            };
            return candidats;
        }

        public static List<Candidature> GetCandidatures(FodContext db)
        {
            List<Candidature> candidatures = new List<Candidature>() {
            new Candidature {type="PFA",datecandidature=DateTime.Now,
            competences = new List <Competence>(db.Competences.Take(2)),            },

            };
            return candidatures;
        }

        public static List<Competence> GetCompetences()
        {
            List<Competence> competences = new List<Competence>() {
            new Competence {
                libele="Java",
            },
          
            };
            return competences;
        }
    }

}