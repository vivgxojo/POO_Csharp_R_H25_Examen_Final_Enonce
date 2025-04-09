using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace POO_Csharp_R_H25_Examen_Final
{
    class PlantesViewModel : INotifyPropertyChanged
    {
        // TODO : Ajouter les attributs/propriétés nécessaire pour géréer la plante sélectionner et l'jouts de nouvelles plantes.

        public ObservableCollection<OrganismeVivant> ListeOrganismeVivants { get; set; }
      
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //TODO : Ajouter la commande du bouton

        public PlantesViewModel()
        {
            //TODO : Initialiser la commande avec son gestionnaire d'évènement et une fonction anonyme pour gérer l'accessibilité du bouton
            //celui-ci doit être activé seulement si les 2 textbox ont un contenu. 

            ListeOrganismeVivants = new ObservableCollection<OrganismeVivant>() 
            { 
                new Plante
                {
                    NomScientifique = "Quercus robur",
                    NomCommun = "Chêne pédonculé",
                    FamilleBotanique = "Fagaceae",
                    Type = "Arbre",
                    Caracteristiques = new List<Caracteristique>
                    {
                        new Caracteristique { TailleMoyenne = 25.0, CouleurFeuilles = "Vert", TypeReproduction = "Graines", CycleDeVie = "Vivace" }
                    },
                    Environnements = new List<Environnement>
                    {
                        new Environnement { TypeSol = "Argileux", ClimatIdeal = "Tempéré", RegionDuMonde = "Europe" }
                    }
                },
                new Plante
                {
                    NomScientifique = "Lavandula angustifolia",
                    NomCommun = "Lavande vraie",
                    FamilleBotanique = "Lamiaceae",
                    Type = "Herbacée",
                    Caracteristiques = new List<Caracteristique>
                    {
                        new Caracteristique { TailleMoyenne = 0.6, CouleurFeuilles = "Gris-vert", TypeReproduction = "Bouturage", CycleDeVie = "Vivace" }
                    },
                    Environnements = new List<Environnement>
                    {
                        new Environnement { TypeSol = "Sableux", ClimatIdeal = "Méditerranéen", RegionDuMonde = "Bassin méditerranéen" }
                    }
                },
                new Plante
                {
                    NomScientifique = "Acer saccharum",
                    NomCommun = "Érable à sucre",
                    FamilleBotanique = "Sapindaceae",
                    Type = "Arbre",
                    Caracteristiques = new List<Caracteristique>
                    {
                        new Caracteristique { TailleMoyenne = 30.0, CouleurFeuilles = "Vert (rouge en automne)", TypeReproduction = "Graines", CycleDeVie = "Vivace" }
                    },
                    Environnements = new List<Environnement>
                    {
                        new Environnement { TypeSol = "Limoneux", ClimatIdeal = "Tempéré froid", RegionDuMonde = "Amérique du Nord" }
                    }
                }
            };
        }

        //TODO : Ajouter le gestionnaire d'évènement pour l'ajout des plantes. Les nouvelles plantes doivent s'afficher dans le ListBox.
    }
}
