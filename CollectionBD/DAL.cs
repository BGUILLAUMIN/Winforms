using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CollectionBD
{
    class DAL
    {
        public static List<string> RecupTitreAlbumAnnee60(string annee)
        {
            //Chargement du fichier XML
            XDocument doc = XDocument.Load(@"..\..\CollectionsBD.xml");

            //Récupération de tous les titres des albums de 1960
            var ListTitre = doc.Descendants("Album").Where(c => c.Attribute("Année").Value.Substring(0,3) == annee).Select(t => t.Attribute("Titre").Value).ToList();

            return ListTitre;
        }

        public static void AjouterAuteur()
        {
            //Chargement du fichier XML
            XDocument doc = XDocument.Load(@"..\..\CollectionsBD.xml");

            var auteur = doc.Descendants("CollectionBD").Where(t => t.Attribute("Nom").Value == "Lucky Luke").Descendants("Auteurs").FirstOrDefault();
            auteur.Add(new XElement("Auteur", "Pascal Dabère"));

            doc.Save(@"..\..\CollectionsBD.xml");
        }

        public static void AjouterAlbum()
        {
            //Chargement du fichier XML
            XDocument doc = XDocument.Load(@"..\..\CollectionsBD.xml");

            var album = doc.Descendants("CollectionBD").Where(t => t.Attribute("Nom").Value == "Lucky Luke").Descendants("Albums").FirstOrDefault();
            album.Add(new XElement("Album", new XAttribute("Id", 32), new XAttribute("Titre", "Le pont sur le Mississippi"), new XAttribute("Année", "1994")));

            doc.Save(@"..\..\CollectionsBD.xml");
        }

        public static void MettreEnMajuscule()
        {
            //Chargement du fichier XML
            XDocument doc = XDocument.Load(@"..\..\CollectionsBD.xml");

            var maj = doc.Descendants("CollectionBD").Where(t => t.Attribute("Nom").Value == "Astérix").Descendants("Album").Where(r => r.Attribute("Id").Value == "15").FirstOrDefault();
            maj.Attribute("Titre").Value = maj.Attribute("Titre").Value.ToUpper();

            doc.Save(@"..\..\CollectionsBD.xml");
        }
    }
}
