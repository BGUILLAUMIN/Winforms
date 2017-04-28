using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExplorateurFichier
{
    public delegate void DelegueExplorateur(FileInfo file);
    public class Explorateur
    {
        List<string> Liste = new List<string>();
        public static void Explorer(string chemin, DelegueExplorateur delegue)
        {
                var dinfo = new DirectoryInfo(chemin);
                var txtFiles = dinfo.EnumerateFiles("*", SearchOption.AllDirectories); //AllDirectories cherche dans tous les sous dossiers
                foreach (var currentFile in txtFiles)
                {
                    delegue(currentFile);
                }
        }
    }
}
