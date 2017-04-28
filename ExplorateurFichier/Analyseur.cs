using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExplorateurFichier
{
    class Analyseur
    {
        public int NbFichier { get; private set; }
        public int NbFichierCS { get; private set; }
        public string NomFichierLong { get; private set; }
        public List<string> ListeFichier { get; } //Ajouter un élément dans une liste n'a pas besoin d'être en get, set

        public Analyseur()
        {
            ListeFichier = new List<string>();
        }

        public void AnalyserDossier(string chemin)
        {
            //RAZ des compteurs
            NbFichier = 0;
            NbFichierCS = 0;
            NomFichierLong = string.Empty;
            ListeFichier.Clear();

            DelegueExplorateur delegue = null;
            delegue += Compterfichiers;
            delegue += AnalyserNom;
            delegue += FiltrerProjet;
            Explorateur.Explorer(chemin, delegue);
        }

        public void Compterfichiers(FileInfo info)
        {
            if (info.Extension.ToLower() == ".cs")
                NbFichierCS++;
            NbFichier++;
        }

        public void AnalyserNom(FileInfo info)
        {
            if (info.Length > NomFichierLong.Length)
                NomFichierLong = info.FullName;

            foreach (char c in NomFichierLong)
            {
                if (c == '\\')
                    NomFichierLong = NomFichierLong.Replace(c, '.');
            }
        }

        public void FiltrerProjet(FileInfo info)
        {
            if (info.Extension.ToLower() == ".csproj")
                ListeFichier.Add(Path.GetFileNameWithoutExtension(info.Name)); //Récupérer le nom sans l'extension
        }
    }
}
