using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace Snake
{
    class Joueur
    {
        private string nom = "Player";
        private int meilleurScore = 0;
        private int multiplicateurScore = 0;
        private XmlDocument xmlDoc;
      
    public List<Joueur> recuperationJoueurs()
    {
        List<Joueur> listeJoueur = new List<Joueur>();
        
        XmlNodeList joueurs;
        joueurs = xmlDoc.GetElementsByTagName("donneesJoueurs");
        XmlNodeList infoJoueurs;

        infoJoueurs = xmlDoc.GetElementsByTagName("joueur");
        foreach (XmlNode infoJoueur in infoJoueurs)
        {
            Joueur joueur = new Joueur();
            joueur.Nom = infoJoueur.ChildNodes[0].InnerText;
            joueur.MeilleurScore = int.Parse(infoJoueur.ChildNodes[1].InnerText);
            joueur.MultiplicateurScore = int.Parse(infoJoueur.ChildNodes[2].InnerText);

            listeJoueur.Add(joueur);
        }
        return listeJoueur;
    }

        public Joueur()
        {
            xmlDoc = new XmlDocument();
            xmlDoc.Load("donneesJoueurs.xml");
        }

        public void supprimeJoueursXML()
        {
            XmlNode root = xmlDoc.DocumentElement;
            root.RemoveAll();

            xmlDoc.Save("donneesJoueurs.xml");
        }

        public void ajoutJoueurXML(string nom, int meilleurScore, int multiplicateur)
        {
            // Création noeud "Joueur"
            XmlNode nouveauJoueur = xmlDoc.CreateNode(XmlNodeType.Element, "joueur", null);

            // 
            XmlNode joueurName = xmlDoc.CreateElement("nom");
            joueurName.InnerText = nom;

            XmlNode joueurScore = xmlDoc.CreateElement("meilleurScore");
            joueurScore.InnerText = Convert.ToString(meilleurScore);

            XmlNode joueurDifficulte = xmlDoc.CreateElement("difficulte");
            joueurDifficulte.InnerText = Convert.ToString(multiplicateur);

            nouveauJoueur.AppendChild(joueurName);
            nouveauJoueur.AppendChild(joueurScore);
            nouveauJoueur.AppendChild(joueurDifficulte);

            xmlDoc.DocumentElement.AppendChild(nouveauJoueur);

            xmlDoc.Save("donneesJoueurs.xml");

            Console.WriteLine("save");
        }



        public void ajouterJoueur(List<Joueur> joueurs, string nom)
        {
            Joueur joueur = new Joueur();
            joueur.Nom = nom;
            joueurs.Add(joueur);
        }

        public void supprimerJoueur(List<Joueur> joueurs, int index)
        {
            if(index >= 0 && index <= joueurs.Count -1)
            joueurs.RemoveAt(index);
        }



    public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }

        public int MeilleurScore
        {
            get
            {
                return meilleurScore;
            }
            set
            {
                meilleurScore = value;
            }
        }

        public int MultiplicateurScore
        {
            get
            {
                return multiplicateurScore;
            }
            set
            {
                multiplicateurScore = value;
            }
        }
    }
}
