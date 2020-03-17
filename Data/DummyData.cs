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

                var competences = DummyData.GetCompetences(context).ToArray();
                context.Competences.AddRange(competences);
                context.SaveChanges();

                var candidatures = DummyData.GetCandidatures(context).ToArray();
                context.Candidatures.AddRange(candidatures);
                context.SaveChanges();

                var roles = DummyData.GetRoles(context).ToArray();
                context.Roles.AddRange(roles);
                context.SaveChanges();

                var utilisateurs = DummyData.GetUtilisateurs(context).ToArray();
                context.Utilisateurs.AddRange(utilisateurs);
                context.SaveChanges();

            }
        }

        public static List<Candidat> GetCandidats(FodContext db)
        {
            List<Candidat> candidats = new List<Candidat>() {
            new Candidat {photo="pdpc1.jpg", nom="Hogarth",prenom="Matt",email="mhogarth@gmail.com",experience=2,date_de_naissance="22/02/1995"},
            new Candidat {photo="pdpc2.jpg", nom="Zargouni",prenom="Hassen",email="hzargouni@gmail.com",experience=10,date_de_naissance="10/01/1971"},
            new Candidat {photo="pdpc3.jpg", nom="Ben Salah",prenom="Mahmoud",email="mahmoudbs@gmail.com",experience=3,date_de_naissance="10/10/1988"},
            new Candidat {photo="pdpc4.jpg", nom="Ben Mohamed",prenom="Aymen",email="aymounbm@gmail.com",experience=4,date_de_naissance="17/11/1991"},
            new Candidat {photo="pdpc5.jpg", nom="Mezghani",prenom="Walid",email="walidm@gmail.com",experience=2,date_de_naissance="01/12/1994"},
            new Candidat {photo="pdpc6.jpg", nom="Masmoudi",prenom="Farah",email="marah95@gmail.com",experience=2,date_de_naissance="03/05/1995"}
            };
            return candidats;
        }

        public static List<Competence> GetCompetences(FodContext db)
        {
            List<Competence> competences = new List<Competence>() {
            new Competence {libele="Java"},
            new Competence {libele="asp.net"},
            new Competence {libele="C#"},
            new Competence {libele="Python"},
            new Competence {libele="AI"},
            new Competence {libele="JavaScript"}
            };
            return competences;
        }
        public static List<Candidature> GetCandidatures(FodContext db)
        {
            List<Candidature> candidatures = new List<Candidature>() {
            
            new Candidature {datepostulation=DateTime.Now.ToString("dd/MM/yyyy"),type="PFA",
            candidat = new List <Candidat>(db.Candidats.Take(1)),
            competence = new List <Competence>(db.Competences.Take(2)),
            cv="cvslim.pdf",status="En Attente" },
            
            new Candidature {datepostulation=DateTime.Now.ToString("dd/MM/yyyy"),type="PFE",
            candidat = new List <Candidat>(db.Candidats.Take(2)),
            competence = new List <Competence>(db.Competences.Take(1)),
            cv="cv1.pdf",status="En Attente" },
            
            new Candidature {datepostulation=DateTime.Now.ToString("dd/MM/yyyy"),type="Stage d'ete",
            candidat = new List <Candidat>(db.Candidats.Take(3)),
            competence = new List <Competence>(db.Competences.Take(5)),
            cv="cvslim.pdf",status="En Attente" },
            
            new Candidature {datepostulation=DateTime.Now.ToString("dd/MM/yyyy"),type="Travail",
            candidat = new List <Candidat>(db.Candidats.Take(4)),
            competence = new List <Competence>(db.Competences.Take(4)),
            cv="cvslim.pdf",status="En Attente" },
           
            new Candidature {datepostulation=DateTime.Now.ToString("dd/MM/yyyy"),type="PFA",
            candidat = new List <Candidat>(db.Candidats.Take(5)),
            competence = new List <Competence>(db.Competences.Take(2)),
            cv="cvslim.pdf",status="En Attente" }
            };
            return candidatures;
        }


        public static List<Role> GetRoles(FodContext db)
        {
            List<Role> roles = new List<Role>() {
            new Role {designation="Administrateur"},
            new Role {designation="HR"},
            new Role {designation="RTechnique"},
            new Role {designation="Candidat"}
            };
            return roles;
        }
        public static List<Utilisateur> GetUtilisateurs(FodContext db)
        {
            List<Utilisateur> utilisateurs = new List<Utilisateur>() {
            new Utilisateur {photo="pdp1.jpg", nom="Chaari",prenom="Slim",email="slimchaari@gmail.com",mdp="slim123",role = new List <Role>(db.Roles.Take(1))},
            new Utilisateur {photo="pdp2.jpg", nom="Mrabet",prenom="Anis",email="aniismrabet@gmail.com",mdp="anis123",role = new List <Role>(db.Roles.Take(2))},
            new Utilisateur {photo="pdp3.jpg", nom="Trigui",prenom="Mohamed",email="mohamedtrigui96@gmail.com",mdp="med123",role = new List <Role>(db.Roles.Take(1))},
            new Utilisateur {photo="pdp4.jpg", nom="Karaa",prenom="Tayeb",email="karaatayeb@gmail.com",mdp="tayeb123",role = new List <Role>(db.Roles.Take(1))}
            };
            return utilisateurs;
        }

    }

}